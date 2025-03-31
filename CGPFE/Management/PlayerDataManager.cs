using CGPFE.Data.Constants;
using CGPFE.Data.Game;
using CGPFE.God.Creation.Player;

namespace CGPFE.Management;

public class PlayerDataManager {
	public readonly Player Player = new Player();

	private static PlayerDataManager instance = null;
	private static readonly object padlock = new object();

	public static PlayerDataManager Instance {
		get {
			lock (padlock) {
				instance ??= new PlayerDataManager();
			}
			return instance;
		}
	}
	
	#region Player Registration

	public void RegisterPlayer() {
		RegisterPlayerName();
		RegisterPlayerGender();
		
		RegisterPlayerRace();
	}

	private void RegisterPlayerName() {
		Console.WriteLine("Please choose your character's name: ");
		string name = Console.ReadLine();
		if (string.IsNullOrEmpty(name)) {
			Console.WriteLine("Cannot enter an empty name");
			RegisterPlayerName();
		}
		Player.PlayerInfo.Name = name;
	}

	private void RegisterPlayerGender() {
		while (true) {
			Console.WriteLine("Please choose your character's gender:\nMale\nFemale");
			string gender = Console.ReadLine();
			switch (gender.ToUpper()) {
				case "MALE":
					Player.PlayerInfo.Gender = Gender.Male;
				break;
				case "FEMALE":
					Player.PlayerInfo.Gender = Gender.Female;
				break;
				default:
					Console.WriteLine("Invalid gender selected");
					continue;
			}

			break;
		}
	}

	private void RegisterPlayerRace() {
		while (true) {
			Console.WriteLine("Please choose your character's race:\nDwarf\nElf\nGnome\nHalfElf\nHalfOrc\nHalfling\nHuman");
			string race = Console.ReadLine();
			switch (race.ToUpper()) {
				case "DWARF":
					Player.PlayerInfo.Race = Race.Dwarf;
				break;
				case "ELF":
					Player.PlayerInfo.Race = Race.Elf;
				break;
				case "GNOME":
					Player.PlayerInfo.Race = Race.Gnome;
				break;
				case "HALFELF":
					Player.PlayerInfo.Race = Race.HalfElf;
				break;
				case "HALFORC":
					Player.PlayerInfo.Race = Race.HalfOrc;
				break;
				case "HALFLING":
					Player.PlayerInfo.Race = Race.Halfling;
				break;
				case "HUMAN":
					Player.PlayerInfo.Race = Race.Human;
				break;
				default:
					Console.WriteLine("Invalid race selected");
					continue;
			}

			break;
		}
	}

	#endregion
	
	#region Ability Points

	private void RegisterAbilityPoints() {
		
	}
	
	#endregion
}