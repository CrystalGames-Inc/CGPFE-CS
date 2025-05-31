using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterWeaponSpecialization: Domain.Characters.Feats.Properties.Feat {
	public GreaterWeaponSpecialization() : base("Greater Weapon Specialization", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Greater Weapon Focus"),
			new FeatPrerequisite("Weapon Specialization"),
			new ValuePrerequisite("Cls", 7, "=="),
			new ValuePrerequisite("Lvl", 12)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}