using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ArcaneArmorTraining : Domain.Characters.Feats.Properties.Feat {

	public ArcaneArmorTraining() : base("Arcane Armor Training", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Light Armor Proficiency"),
			new ValuePrerequisite("Lvl", 3)
		];
	}
	
	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}