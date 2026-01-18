namespace CGPFE.Core.Utilities;

public static class PromptHelper
{

    public static string TextPrompt(string message)
    {
        Console.WriteLine(message, "\n");
        string? ans;
        do
        {
            ans = Console.ReadLine();
            if (string.IsNullOrEmpty(ans)) Console.WriteLine("Can't enter empty value");
        } while (string.IsNullOrEmpty(ans));
        return ans;
    }

    public static bool YesNoPrompt(string message, bool @default)
    {
        Console.Write($"{message} [Y/N]");
        Console.Write(@default ? "(Default: Y)" : "(Default: N)");
        Console.WriteLine();
        var result = Console.ReadLine().ToUpper();
        return result is "Y" or "YES";
    }

    public static int NumberPrompt(string message)
    {
        Console.Write(message, "\n");
        var ans = int.Parse(Console.ReadLine());
        return ans;
    }

    public static int RangePrompt(string message, int min, int max)
    {
        Console.WriteLine($"{message}\nRange: ({min} - {max})");
        var ans = min;
        do
        {
            Console.WriteLine(message, $"\nRange: ({min} - {max})");
            ans = int.Parse(Console.ReadLine());
            if (ans < min || ans > max)
                Console.WriteLine($"Invalid answer. Please choose within the range ({min} - {max})\n");
        } while (ans < min || ans > max);

        return ans;
    }

    public static T ListPrompt<T>(string message, List<T> choices)
    {
        while (true)
        {
            Console.WriteLine(message, "\n");
            for (int i = 0; i < choices.Count; i++)
                Console.WriteLine($"{i + 1}. {choices[i]}");

            Console.WriteLine("Please enter the index of your choice: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int index) && index >= 1 && index <= choices.Count)
                return choices[index - 1];

            Console.WriteLine("Invalid choice. Please try again.\n");
        }
    }

    public static T EnumPrompt<T>(string message) where T : Enum
    {
        return ListPrompt(message, Enum.GetValues(typeof(T)).Cast<T>().ToList());
    }
}
