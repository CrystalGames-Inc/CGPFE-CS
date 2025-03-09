namespace CGPFE.Mechanics;

public class Dice {
	private readonly Random _random = new Random();

	//Single-Die roll.
	public int Roll(int faces) {
		return _random.Next(1, faces + 1);
	}

	//Multiple dice roll.
	public int Roll(int faces, int amount) {
		int sum = 0;
		for (int i = 0; i < amount; i++) {
			sum += Roll(faces);
		}
		return sum;
	}

	//Die roll with modifier.
	public int Roll(int faces, int amount, int modifier) {
		int sum = 0;
		for (int i = 0; i < amount; i++) {
			sum += Roll(faces);
		}
		return sum + modifier;
	}
}