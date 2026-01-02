using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterFeint: Domain.Characters.Feats.Properties.Feat {
	public GreaterFeint() : base("Greater Feint", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Combat Expertise"),
			new FeatPrerequisite("Improved Feint"),
			new ValuePrerequisite("Bab", 6),
			new ValuePrerequisite("Int", 13)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}