using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class ImprovedShieldBash: Feat {
	public ImprovedShieldBash() : base("Improved Shield Bash", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Shield Proficiency")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}