using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class SpellMastery: Feat {
	public SpellMastery() : base("Spell Mastery") {
		Prerequisites = [
			new ValuePrerequisite("Cls", 17, "=="),
			new ValuePrerequisite("Lvl", 1)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}