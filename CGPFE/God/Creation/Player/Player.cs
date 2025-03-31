using System.Text.Json;
using CGPFE.Data.Constants;
using CGPFE.God.Creation.General;
using CGPFE.God.Creation.Player.Properties;
using Newtonsoft.Json;

namespace CGPFE.God.Creation.Player;

public class Player {
	public PlayerInfo PlayerInfo;
	public Attributes Attributes = new Attributes();
	public Attributes AttributeModifiers = new Attributes();
	public CombatInfo CombatInfo = new CombatInfo();
	public Wallet Wallet;
	
	private void RegisterCombatTable() {
		var fileName = "PlaceholderCT.json";
		switch (PlayerInfo.Class) {
			case Class.Alchemist:
				fileName = "AlchemistCT.json";
			break;
			case Class.Barbarian:
				fileName = "BarbarianCT.json";
			break;
			case Class.Bard:
				fileName = "BardCT.json";
			break;
			case Class.Cavalier:
				fileName = "CavalierCT.json";
			break;
			case Class.Cleric:
				fileName = "ClericCT.json";
			break;
			case Class.Druid:
				fileName = "DruidCT.json";
			break;
			case Class.Fighter:
				fileName = "FighterCT.json";
			break;
			case Class.Inquisitor:
				fileName = "InquisitorCT.json";
			break;
			case Class.Monk:
				fileName = "MonkCT.json";
			break;
			case Class.Oracle:
				fileName = "OracleCT.json";
			break;
			case Class.Paladin:
				fileName = "PaladinCT.json";
			break;
			case Class.Ranger:
				fileName = "RangerCT.json";
			break;
			case Class.Rogue:
				fileName = "RogueCT.json";
			break;
			case Class.Sorcerer:
				fileName = "SorcererCT.json";
			break;
			case Class.Summoner:
				fileName = "SummonerCT.json";
			break;
			case Class.Witch:
				fileName = "WitchCT.json";
			break;
			case Class.Wizard:
				fileName = "WizardCT.json";
			break;
		}
		var combatTable = JsonConvert.DeserializeObject<CombatTableRow[]?>(fileName);
		for (int i = 0; i < 20; i++) {
			Console.WriteLine($"Level: {combatTable?[i + 1]}");
			Console.WriteLine($"BAB: {combatTable?[i].BAB}");
			Console.WriteLine($"Fort: {combatTable?[i].Fort}");
			Console.WriteLine($"Ref: {combatTable?[i].Ref}");
			Console.WriteLine($"Will: {combatTable?[i].Will}");
			
		}
	}
	
}