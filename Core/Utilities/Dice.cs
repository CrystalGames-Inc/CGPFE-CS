namespace CGPFE.Core.Utilities;

public static class Dice
{
    private static readonly Random Random = new Random();

    //Single-Die roll.
    public static int Roll(int faces)
    {
        return Random.Next(1, faces + 1);
    }

    //Multiple dice roll.
    public static int Roll(int faces, int amount)
    {
        int sum = 0;
        for (int i = 0; i < amount; i++)
        {
            sum += Roll(faces);
        }
        return sum;
    }

    //Die roll with modifier.
    public static int Roll(int faces, int amount, int modifier)
    {
        int sum = 0;
        for (int i = 0; i < amount; i++)
        {
            sum += Roll(faces);
        }
        return sum + modifier;
    }
}
