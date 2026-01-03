using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterGrapple: Characters.Feats.Feat {
	public GreaterGrapple() : base("Greater Grapple", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Improved Grapple"),
			new FeatPrerequisite("Improved Unarmed Strike"),
			new ValuePrerequisite("Bab", 6),
			new ValuePrerequisite("Dex", 13)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}