namespace CGPFE.Core.Utilities;

public static class PromptHelper {

	public static string TextPrompt(string message) {
		Console.WriteLine(message, "\n");
		var ans = Console.ReadLine();
		if (!string.IsNullOrEmpty(ans)) return ans;
		Console.WriteLine("Can't enter empty value");
		TextPrompt(message);
		return ans;
	}

	public static bool YesNoPrompt(string message, bool @default) {
		Console.Write($"{message} [Y/N]");
		Console.Write(@default ? "(Default: Y)" : "(Default: N)");
		Console.WriteLine();
		var result = Console.ReadLine().ToUpper();
		return result is "Y" or "YES";
	}

	public static int NumberPrompt(string message) {
		Console.Write(message, "\n");
		return int.Parse(Console.ReadLine());
	}

	public static int RangePrompt(string message, int min, int max) {
		while (true) {
			Console.WriteLine(message, $"({min} - {max})");
			var ans = int.Parse(Console.ReadLine());
			if (ans >= min && ans <= max) return ans;
			Console.WriteLine($"Invalid answer. Please choose within the range ({min} - {max})\n");
		}
	}

	public static T ListPrompt<T>(string message, List<T> choices) {
		while (true) {
			Console.WriteLine(message, "\n");
			for(int i = 0; i < choices.Count; i++)
				Console.WriteLine($"{i + 1}. {choices[i]}");

			Console.WriteLine("Please enter the index of your choice: ");
			var input = Console.ReadLine();
			
			if(int.TryParse(input, out int index) && index >= 1 && index <= choices.Count)
				return choices[index - 1];

			Console.WriteLine("Invalid choice. Please try again.\n");
		}
	}

	public static T EnumPrompt<T>(string message) where T : Enum {
		return ListPrompt(message, Enum.GetValues(typeof(T)).Cast<T>().ToList());
	}
}