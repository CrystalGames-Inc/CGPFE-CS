using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;
using Attribute = CGPFE.Core.Enums.Attribute;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class AcrobaticSteps: Domain.Characters.Feats.Properties.Feat {
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