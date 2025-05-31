using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ImprovisedWeaponMastery: Domain.Characters.Feats.Properties.Feat {
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