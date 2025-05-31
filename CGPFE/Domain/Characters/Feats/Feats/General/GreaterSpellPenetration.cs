using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class GreaterSpellPenetration: Domain.Characters.Feats.Properties.Feat {
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