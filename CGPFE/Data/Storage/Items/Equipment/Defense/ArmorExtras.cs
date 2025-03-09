using CGPFE.Data.Models.Item.Defense;

namespace CGPFE.Data.Storage.Items.Equipment.Defense;

public class ArmorExtras {
	public static ArmorExtra ArmorSpikes = new ArmorExtra(
		"Armor Spikes",
		0,
		50,
		null,
		null,
		10);

	public static ArmorExtra LockedGauntlet = new ArmorExtra(
		"Locked Gauntlet",
		1,
		8,
		null,
		100,
		5);

	public static ArmorExtra ShieldSpikes = new ArmorExtra(
		"Shield Spikes",
		2,
		10,
		null,
		null,
		5);
}