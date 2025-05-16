using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;
using Attribute = CGPFE.Data.Constants.Attribute;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class AcrobaticSteps: Feat {
	public AcrobaticSteps() : base("Acrobatic Steps") {
		Prerequisites = [
			new ValuePrerequisite("Dex", 15),
			new FeatPrerequisite("Nimble Moves")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		// TODO add benefits
	}
}