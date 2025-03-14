namespace CGPFE.Management;

public class CommandManager {
	public static void CheckCommand(string text) {
		var words = text.Split(" ");
		switch (words[0].ToUpper()) {
			case "EXIT":
				Environment.Exit(0);
			break;
			case "HELP":
                Help();
			break;
		}
	}

	private static void Help() {
		Console.WriteLine("Commands:");
		Console.WriteLine("		exit - Exit the program.");
	}

	public static void Wait(int millis) {
		Thread.Sleep(millis);
	}

	public static void AwaitUserInput() {
		Console.ReadKey();
	}
}