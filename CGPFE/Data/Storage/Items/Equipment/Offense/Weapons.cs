using CGPFE.Data.Models.Item.Offense;
using CGPFE.Data.Models.Item.Offense.Properties;
using Type = CGPFE.Data.Models.Item.Offense.Properties.Type;

namespace CGPFE.Data.Storage.Items.Equipment.Offense;

public class Weapons {
	#region SimpleWeapons

	#region Unarmed Attacks

	public static Weapon Gauntlet = new Weapon("Gauntlet", 0, 1, 2, new Damage(2), new Damage(3), new Critical(2), 0, 1,
		[Type.Bludgeoning], null);

	public static Weapon UnarmedStrike = new Weapon("Unarmed Strike", 1, 1, 0, new Damage(2), new Damage(3),
		new Critical(2), 0, 0, [Type.Bludgeoning], [Special.Nonlethal]);

	#endregion

	#endregion
}