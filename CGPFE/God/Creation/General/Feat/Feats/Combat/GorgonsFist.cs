using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class GorgonsFist: Feat {
	public GorgonsFist() : base("Gorgon's Fist", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Improved Unarmed Strike"),
			new FeatPrerequisite("Scorpion Style"),
			new ValuePrerequisite("Bab", 6)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}