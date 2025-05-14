using CGPFE.God.Creation.General.Feats;
using CGPFE.God.Creation.General.Feats.Prerequisites;
using CGPFE.Management;
using Attribute = CGPFE.Data.Constants.Attribute;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class AcrobaticSteps: Creation.General.Feats.Feat {
	public AcrobaticSteps() : base("Acrobatic Steps") {
		Prerequisites = [
			new AbilityPrerequisite() {
				Ability = Attribute.Dexterity,
				Value = 15
			},
			new FeatPrerequisite() {
				Name = "Nimble Moves",
			}
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		// TODO add benefits
	}
}