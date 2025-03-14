using CGPFE.Data.Models.Item.Equipment.Defense;
using CGPFE.Data.Models.Item.Equipment.Offense;
using Attribute = CGPFE.Data.Constants.Attribute;

namespace CGPFE.God.Creation.General;

public class CombatInfo {
	public int InitMod { get; set; } = 0;
	public int ArmorClass { get; set; } = 0;
	public int Fortitude { get; set; } = 0;
	public int Reflex { get; set; } = 0;
	public int Will { get; set; } = 0;
	public int BaseAttackBonus { get; set; }
	public Attribute CmbCalcBonus { get; set; } = Attribute.Strength;
	public int CombatManeuverBonus { get; set; } = 0;
	public int CombatManeuverDefense { get; set; } = 0;
	public Weapon[]? Weapons { get; set; } = new Weapon[5];
	public Armor[]? Armors { get; set; } = new Armor[5];
	public Shield[]? Shields { get; set; } = new Shield[5];
}