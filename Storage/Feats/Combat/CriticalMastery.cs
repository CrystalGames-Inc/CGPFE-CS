using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class CriticalMastery: Characters.Feats.Feat {
	public CriticalMastery() : base("Critical Mastery", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Critical Focus"),
			new ValuePrerequisite("Lvl", 14),
			new ValuePrerequisite("Cls", 7, "==")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}