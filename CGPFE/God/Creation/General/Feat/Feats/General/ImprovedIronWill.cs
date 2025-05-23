using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class ImprovedIronWill: Feat {
	public ImprovedIronWill() : base("Improved Iron Will") {
		Prerequisites = [
			new FeatPrerequisite("Iron Will")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}