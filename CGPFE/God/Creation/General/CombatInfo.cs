using CGPFE.Data.Models.Item.Equipment.Defense;
using CGPFE.Data.Models.Item.Equipment.Offense;
using Attribute = CGPFE.Data.Constants.Attribute;

namespace CGPFE.God.Creation.General;

public class CombatInfo {
	private CombatTableRow[] CombatTable { get; set; } = new CombatTableRow[20];
	public int InitMod { get; set; } = 0;
	public int ArmorClass { get; set; } = 0;
	public int Fortitude { get; set; } = 0;
	public int Reflex { get; set; } = 0;
	public int Will { get; set; } = 0;
	public int BaseAttackBonus { get; set; } = 0;
	public Attribute CmbCalcBonus { get; set; } = Attribute.Strength;
	public int CombatManeuverBonus { get; set; } = 0;
	public int CombatManeuverDefense { get; set; } = 0;
	public List<string>? Weapons { get; set; } = [];
	public List<string>? Armors { get; set; } = [];
	public List<string>? Shields { get; set; } = [];
}