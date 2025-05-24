using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class SpringAttack: Feat {
	public SpringAttack() : base("Spring Attack", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Dex", 13),
			new FeatPrerequisite("Dodge"),
			new FeatPrerequisite("Mobility"),
			new ValuePrerequisite("Bab", 4)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}