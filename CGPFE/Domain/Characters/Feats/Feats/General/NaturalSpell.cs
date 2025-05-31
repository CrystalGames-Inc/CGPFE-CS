using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class NaturalSpell : Domain.Characters.Feats.Properties.Feat {
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