using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ImprovedCritical: Characters.Feats.Feat {
	public ImprovedCritical() : base("Improved Critical", FeatType.Combat) {
		Prerequisites = [
			
			new ValuePrerequisite("Bab", 8)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}