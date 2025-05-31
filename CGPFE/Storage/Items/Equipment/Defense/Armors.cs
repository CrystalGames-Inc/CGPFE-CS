using CGPFE.Core.Enums;
using CGPFE.Domain.Items.Equipment.Defense;

namespace CGPFE.Storage.Items.Equipment.Defense;

public class Armors {
	#region Light Armor

	public static readonly Armor PaddedArmor = new Armor(
		"Padded Armor",
		0,
		5,
		Weight.Light,
		1,
		8,
		0,
		5,
		[30, 20],
		10);

	public static readonly Armor LeatherArmor = new Armor(
		"Leather Armor",
		1,
		10,
		Weight.Light,
		2,
		6,
		0,
		10,
		[30, 20],
		15);

	public static readonly Armor StuddedLeatherArmor = new Armor(
		"Studded Leather Armor",
		2,
		25,
		Weight.Light,
		3,
		5,
		-1,
		15,
		[30, 20],
		20);

	public static readonly Armor ChainShirt = new Armor(
		"Chain Shirt",
		3,
		100,
		Weight.Light,
		4,
		4,
		-2,
		20,
		[30,20],
		25);

	public static List<Armor> LightArmors = [
		PaddedArmor,
		LeatherArmor,
		StuddedLeatherArmor,
		ChainShirt
	];

	#endregion
	
	#region Medium Armor
	
	public static readonly Armor HideArmor = new Armor(
		"Hide Armor",
		4,
		15,
		Weight.Medium,
		4,
		4,
		-3,
		20,
		[20,15],
		25);

	public static readonly Armor ScaleMail = new Armor(
		"Scale Mail",
		5,
		15,
		Weight.Medium,
		5,
		3,
		-4,
		25,
		[20,15],
		30);

	public static readonly Armor Chainmail = new Armor(
		"Chainmail",
		6,
		150,
		Weight.Medium,
		6,
		2,
		-5,
		30,
		[20,15],
		40);

	public static readonly Armor Breastplate = new Armor(
		"Breastplate",
		7,
		200,
		Weight.Medium,
		6,
		3,
		-4,
		25,
		[20, 15],
		30);

	public static List<Armor> MediumArmors = [
		HideArmor,
		ScaleMail,
		Chainmail,
		Breastplate
	];

	#endregion
	
	#region Heavy Armor

	public static readonly Armor SplintMail = new Armor(
		"Splint Mail",
		8,
		200,
		Weight.Heavy,
		7,
		0,
		-7,
		40,
		[20,15],
		45);

	public static readonly Armor BandedMail = new Armor(
		"Banded Mail",
		9,
		250,
		Weight.Heavy,
		7,
		1,
		-6,
		35,
		[20, 15],
		35);

	public static readonly Armor HalfPlate = new Armor(
		"Half-Plate",
		10,
		600,
		Weight.Heavy,
		8,
		0,
		-7,
		40,
		[20, 15],
		50);

	public static readonly Armor FullPlate = new Armor(
		"Full Plate",
		11,
		1500,
		Weight.Heavy,
		9,
		1,
		-6,
		35,
		[20, 15],
		50);

	public static List<Armor> HeavyArmors = [
	SplintMail,
	BandedMail,
	HalfPlate,
	FullPlate
	];

	#endregion

	public static List<Armor> armors = LightArmors.Concat(MediumArmors).Concat(HeavyArmors).ToList();
}