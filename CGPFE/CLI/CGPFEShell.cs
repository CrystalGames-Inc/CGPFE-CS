using CGPFE.CLI;
using CGPFE.CLI.Commands;
using CGPFE.Core.Utilities;
using CGPFE.Domain.Game;
using CGPFE.Management;

namespace CGPFE.Core.CLI
{
    public class CGPFEShell
    {
        private readonly Dictionary<string, ICommand> _commands = new();
        private bool _running = true;

        public string? CurrentCampaign { get; private set; }

        public CGPFEShell() {
            RegisterCommand(new NewCommand());
            RegisterCommand(new ClearCommand());
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
            foreach (var cmd in _commands.Values) {
                if (CurrentCampaign == null && cmd.RequiresCampaign)
                    continue;
                Console.WriteLine($"  {cmd.Name.PadRight(15)} - {cmd.Description}");
            }
            Console.WriteLine();
        }

        public void LoadCampaign(string name) {
            CurrentCampaign = name;
            Success($"Loaded campaign '{name}'.");
        }

        public void UnloadCampaign() {
            if (PromptHelper.YesNoPrompt("Would you like to save any changes made?", true))
                FileManager.RegisterGameData();
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

    public class AddCharacterCommand : ICommand
    {
        private readonly CGPFEShell _shell;

        public AddCharacterCommand(CGPFEShell shell) => _shell = shell;

        public string Name => "add_char";
        public string Description => "Adds a new character to the current campaign";
        public bool? RequiresCampaign => true;

        public void Execute(string[] args) {
            Console.Write("Character Name: ");
            string? name = Console.ReadLine();

            Console.WriteLine($"Added character '{name}' to {_shell.CurrentCampaign}.");
        }
    }
}
