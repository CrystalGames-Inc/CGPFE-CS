using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class Disruptive: Domain.Characters.Feats.Properties.Feat {
	public Disruptive() : base("Disruptive", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Cls", 7, "=="),
			new ValuePrerequisite("Lvl", 6)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}