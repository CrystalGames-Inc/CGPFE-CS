using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GorgonsFist: Domain.Characters.Feats.Properties.Feat {
	public GorgonsFist() : base("Gorgon's Fist", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Improved Unarmed Strike"),
			new FeatPrerequisite("Scorpion Style"),
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