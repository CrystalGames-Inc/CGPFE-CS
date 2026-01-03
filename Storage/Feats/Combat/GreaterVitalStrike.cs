using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterVitalStrike: Characters.Feats.Feat {
	public GreaterVitalStrike() : base("Greater Vital Strike", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Improved Vital Strike"),
			new FeatPrerequisite("Vital Strike"),
			new ValuePrerequisite("Bab", 16)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}