using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class Spellbreaker: Domain.Characters.Feats.Properties.Feat {
	public Spellbreaker() : base("Spellbreaker", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Disruptive"),
			new ValuePrerequisite("Cls", 7),
			new ValuePrerequisite("Lvl", 10)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}