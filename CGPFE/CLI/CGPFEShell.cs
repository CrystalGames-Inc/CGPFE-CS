using CGPFE.Management;
using System;
using System.Collections.Generic;

namespace CGPFE.Core.CLI
{
    public class CGPFEShell
    {
        private readonly Dictionary<string, ICommand> _commands = new();
        private bool _running = true;

        public string? CurrentCampaign { get; private set; }

        public CGPFEShell() {
            RegisterCommand(new NewCommand());
            RegisterCommand(new LoadCommand(this));
            RegisterCommand(new DeleteCommand());
            RegisterCommand(new ListCommand());
            RegisterCommand(new ExitCommand(this));

            // Commands that require a loaded campaign
            RegisterCommand(new SaveCommand(this));
            RegisterCommand(new AddCharacterCommand(this));
        }

        private void RegisterCommand(ICommand cmd) {
            _commands[cmd.Name] = cmd;
        }

        public void Start() {
            Console.Clear();
            Console.WriteLine("CGPFE Command Shell");
            Console.WriteLine("Type 'help' to see available commands.\n");

            while (_running) {
                ShowPrompt();
                string? input = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(input)) continue;

                HandleInput(input);
            }
        }

        private void ShowPrompt() {
            if (CurrentCampaign == null) {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("CGPFE> ");
            } else {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"CGPFE ({CurrentCampaign})> ");
            }
            Console.ResetColor();
        }

        private void HandleInput(string input) {
            var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string cmdName = parts[0].ToLower();
            string[] args = parts.Length > 1 ? parts[1..] : Array.Empty<string>();

            if (cmdName == "help") {
                PrintHelp();
                return;
            }

            if (!_commands.TryGetValue(cmdName, out var command)) {
                Error($"Unknown command '{cmdName}'. Type 'help' for a list.");
                return;
            }

            // Check if this command requires a campaign loaded
            if (command.RequiresCampaign && CurrentCampaign == null) {
                Error("This command requires an active campaign.");
                return;
            }

            command.Execute(args);
        }

        private void PrintHelp() {
            Console.WriteLine("\nAvailable Commands:");
            foreach (var cmd in _commands.Values)
                Console.WriteLine($"  {cmd.Name.PadRight(15)} - {cmd.Description}");
            Console.WriteLine();
        }

        public void LoadCampaign(string name) {
            CurrentCampaign = name;
            Success($"Loaded campaign '{name}'.");
        }

        public void UnloadCampaign() {
            CurrentCampaign = null;
        }

        public void Stop() {
            _running = false;
        }

        public static void Success(string msg) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static void Error(string msg) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }

    // =====================================================================
    // COMMAND INTERFACE
    // =====================================================================

    public interface ICommand
    {
        string Name { get; }
        string Description { get; }
        bool RequiresCampaign { get; }
        void Execute(string[] args);
    }

    // =====================================================================
    // COMMAND IMPLEMENTATIONS
    // =====================================================================

    public class NewCommand : ICommand
    {
        public string Name => "new";
        public string Description => "Creates a new campaign";
        public bool RequiresCampaign => false;

        public void Execute(string[] args) {
            FileManager.SaveGameData();
        }
    }

    public class LoadCommand : ICommand
    {
        private readonly CGPFEShell _shell;

        public LoadCommand(CGPFEShell shell) {
            _shell = shell;
        }

        public string Name => "load";
        public string Description => "Loads a campaign";
        public bool RequiresCampaign => false;

        public void Execute(string[] args) {
            if (args.Length == 0) {
                Console.Write("Campaign name to load: ");
                args = [Console.ReadLine() ?? ""];
            }

            if (string.IsNullOrWhiteSpace(args[0])) {
                CGPFEShell.Error("No campaign name provided.");
                return;
            }

            _shell.LoadCampaign(args[0]);
        }
    }

    public class DeleteCommand : ICommand
    {
        public string Name => "delete";
        public string Description => "Deletes a campaign";
        public bool RequiresCampaign => false;

        public void Execute(string[] args) {
            string? target;

            if (args.Length == 0) {
                Console.Write("Campaign name to delete: ");
                target = Console.ReadLine();
            } else {
                target = args[0];
            }

            if (string.IsNullOrWhiteSpace(target)) {
                CGPFEShell.Error("No campaign name provided.");
                return;
            }

            Console.Write($"Are you sure you want to delete '{target}'? (y/n): ");
            if (Console.ReadLine()?.ToLower() == "y")
                Console.WriteLine($"Deleted campaign '{target}'.");
        }
    }

    public class ListCommand : ICommand
    {
        public string Name => "list";
        public string Description => "Lists all campaigns";
        public bool RequiresCampaign => false;

        public void Execute(string[] args) {
            FileManager.ListCampaigns();
        }
    }

    public class ExitCommand : ICommand
    {
        private readonly CGPFEShell _shell;

        public ExitCommand(CGPFEShell shell) {
            _shell = shell;
        }

        public string Name => "exit";
        public string Description => "Exits CGPFE or closes the current campaign";
        public bool RequiresCampaign => false;

        public void Execute(string[] args) {
            if (_shell.CurrentCampaign != null) {
                Console.WriteLine($"Exiting campaign '{_shell.CurrentCampaign}'...");
                _shell.UnloadCampaign();
                return;
            }

            Console.WriteLine("Goodbye!");
            _shell.Stop();
        }
    }

    public class SaveCommand : ICommand
    {
        private readonly CGPFEShell _shell;

        public SaveCommand(CGPFEShell shell) => _shell = shell;

        public string Name => "save";
        public string Description => "Saves the current campaign";
        public bool RequiresCampaign => true;

        public void Execute(string[] args) {
            Console.WriteLine($"Saved campaign '{_shell.CurrentCampaign}'.");
            // TODO: Save campaign data.
        }
    }

    public class AddCharacterCommand : ICommand
    {
        private readonly CGPFEShell _shell;

        public AddCharacterCommand(CGPFEShell shell) => _shell = shell;

        public string Name => "add_char";
        public string Description => "Adds a new character to the current campaign";
        public bool RequiresCampaign => true;

        public void Execute(string[] args) {
            Console.Write("Character Name: ");
            string? name = Console.ReadLine();

            Console.WriteLine($"Added character '{name}' to {_shell.CurrentCampaign}.");
        }
    }
}
