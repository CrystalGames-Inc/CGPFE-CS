using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class SpellMastery: Domain.Characters.Feats.Properties.Feat {
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