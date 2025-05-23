using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class ImprovedGreatFortitude: Feat {
	public ImprovedGreatFortitude() : base("Improved Great Fortitude") {
		Prerequisites = [
			new FeatPrerequisite("Great Fortitude")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}