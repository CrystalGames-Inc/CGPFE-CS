using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class WeaponSpecialization: Domain.Characters.Feats.Properties.Feat {
	public WeaponSpecialization() : base("Weapon Specialization", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Weapon Focus"),
			new ValuePrerequisite("Cls", 7),
			new ValuePrerequisite("Lvl", 4)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}