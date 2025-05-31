using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class Dodge: Domain.Characters.Feats.Properties.Feat {
	public Dodge() : base("Dodge", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Dex", 13)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.CombatInfo.ArmorClass += 1;
	}
}