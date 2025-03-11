namespace CGPFE.Management;

public class CommandManager {
	public void CheckCommand(string text) {
		string[] words = text.Split(" ");
		switch (words[0].ToUpper()) {
			case "EXIT":
				Environment.Exit(0);
			break;
			case "HELP":
				Help();
			break;
		}
	}

	private void Help() {
		Console.WriteLine("Commands:");
		Console.WriteLine("		exit - Exit the program.");
	}

	public void Wait(int millis) {
		Thread.Sleep(millis);
	}

	public void AwaitUserInput() {
		Console.ReadKey();
	}
}