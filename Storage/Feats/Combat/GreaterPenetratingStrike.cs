using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterPenetratingStrike: Characters.Feats.Feat {
	public GreaterPenetratingStrike() : base("Greater Penetrating Strike", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Penetrating Strike"),
			new FeatPrerequisite("Weapon Focus"),
			new ValuePrerequisite("Cls", 7, "=="),
			new ValuePrerequisite("Lvl", 16)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}