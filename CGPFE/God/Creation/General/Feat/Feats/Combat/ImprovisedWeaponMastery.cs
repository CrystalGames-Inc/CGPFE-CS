using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class ImprovisedWeaponMastery: Feat {
	public ImprovisedWeaponMastery() : base("Improvised Weapon Mastery", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Catch Off-Guard"),
			new FeatPrerequisite("Throw Anything"),
			new ValuePrerequisite("Bab", 8)
		];
	}

	public override bool CanAcquire() {
		return (Prerequisites[0].IsSatisfiedBy(PlayerDataManager.Instance.Player) || Prerequisites[1].IsSatisfiedBy(PlayerDataManager.Instance.Player)) && Prerequisites.Last().IsSatisfiedBy(PlayerDataManager.Instance.Player);
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}