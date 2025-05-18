using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class DeadlyStroke: Feat {
	public DeadlyStroke() : base("Deadly Stroke", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Dazzling Display"),
			new FeatPrerequisite("Greater Weapon Focus"),
			new FeatPrerequisite("Shatter Defenses"),
			new FeatPrerequisite("Weapon Focus"),
			new ValuePrerequisite("Bab", 11)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}