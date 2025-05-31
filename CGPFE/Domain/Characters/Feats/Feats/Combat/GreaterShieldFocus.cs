using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterShieldFocus: Domain.Characters.Feats.Properties.Feat {
	public GreaterShieldFocus() : base("Greater Shield Focus", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Shield Focus"),
			new FeatPrerequisite("Shield Proficiency"),
			new ValuePrerequisite("Cls", 7, "=="),
			new ValuePrerequisite("Lvl", 8)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}