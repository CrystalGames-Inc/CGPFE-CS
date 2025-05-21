using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class GreaterSpellPenetration: Feat {
	public GreaterSpellPenetration() : base("Greater Spell Penetration") {
		Prerequisites = [
			new FeatPrerequisite("Spell Penetration")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}