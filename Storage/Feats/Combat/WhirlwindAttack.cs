using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class WhirlwindAttack: Characters.Feats.Feat {
	public WhirlwindAttack() : base("Whirlwind Attack", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Dex", 13),
			new ValuePrerequisite("Int", 13),
			new FeatPrerequisite("Combat Expertise"),
			new FeatPrerequisite("Dodge"),
			new FeatPrerequisite("Mobility"),
			new FeatPrerequisite("Spring Attack"),
			new ValuePrerequisite("Bab", 4)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}