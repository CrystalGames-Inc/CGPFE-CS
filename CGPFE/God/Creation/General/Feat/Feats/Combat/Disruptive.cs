using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class Disruptive: Feat {
	public Disruptive() : base("Disruptive", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Cls", 7, "=="),
			new ValuePrerequisite("Lvl", 6)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}