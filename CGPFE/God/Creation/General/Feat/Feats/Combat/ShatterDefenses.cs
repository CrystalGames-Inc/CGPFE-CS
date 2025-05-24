using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class ShatterDefenses: Feat {
	public ShatterDefenses() : base("Shatter Defenses", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Weapon Focus"),
			new FeatPrerequisite("Dazzling Display"),
			new ValuePrerequisite("Bab", 6),
			//TODO Add specific weapon proficiency
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}