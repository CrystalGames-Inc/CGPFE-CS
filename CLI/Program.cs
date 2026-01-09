using CGPFE.CLI;

namespace CGPFE.CLI;

internal class Program
{
    public static void Main(string[] args) {
        // If you want to support "CGPFE new campaign" from the OS command line:
        if (args.Length > 0) {
            RunSingleCommand(args);
            return;
        }

        // Otherwise start the interactive shell:
        var shell = new CGPFEShell();
        shell.Start();
    }

    private static void RunSingleCommand(string[] args) {
        var shell = new CGPFEShell();

        // Combine args into a normal CLI input string
        string command = string.Join(" ", args);

        Console.WriteLine($"Running: {command}");
        shell.GetType()
            .GetMethod("HandleInput", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
            ?.Invoke(shell, [command]);
    }
}
