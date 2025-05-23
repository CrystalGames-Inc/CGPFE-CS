using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class NaturalSpell : Feat {
	public NaturalSpell() : base("Natural Spell") {
		Prerequisites = [
			new ValuePrerequisite("Wis", 13),
			//TODO Add class feature prerequisite
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}