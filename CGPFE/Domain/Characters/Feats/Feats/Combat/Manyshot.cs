using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class Manyshot: Domain.Characters.Feats.Properties.Feat {
	public Manyshot() : base("Manyshot", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Dex", 17),
			new FeatPrerequisite("Point-Blank Shot"),
			new FeatPrerequisite("Rapid Shot"),
			new ValuePrerequisite("Bab", 6)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}