using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterBullRush: Characters.Feats.Feat {
	public GreaterBullRush() : base("Greater Bull Rush", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Improved Bull Rush"),
			new FeatPrerequisite("Power Attack"),
			new ValuePrerequisite("Bab", 6),
			new ValuePrerequisite("Str", 13)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}