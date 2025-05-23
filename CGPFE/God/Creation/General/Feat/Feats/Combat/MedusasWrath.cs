using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class MedusasWrath: Feat {
	public MedusasWrath() : base("Medusa's Wrath", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Improved Unarmed Strike"),
			new FeatPrerequisite("Gorgon's Fist"),
			new FeatPrerequisite("Scorpion Style"),
			new ValuePrerequisite("Bab", 11)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}