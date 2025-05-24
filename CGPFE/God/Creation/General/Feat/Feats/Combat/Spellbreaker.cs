using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class Spellbreaker: Feat {
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