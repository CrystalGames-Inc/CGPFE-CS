using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class Unseat: Characters.Feats.Feat {
	public Unseat() : base("Unseat", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Str", 13),
			new SkillRankPrerequisite("Ride", 1),
			new FeatPrerequisite("Mounted Combat"),
			new FeatPrerequisite("Power Attack"),
			new FeatPrerequisite("Improved Bull Rush"),
			new ValuePrerequisite("Bab", 1)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}