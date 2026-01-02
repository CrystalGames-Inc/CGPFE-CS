using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ArcaneArmorMastery : Domain.Characters.Feats.Properties.Feat {

	public ArcaneArmorMastery() : base("Arcane Armor Mastery", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Arcane Armor Training"),
			new FeatPrerequisite("Medium Armor Proficiency"),
			new ValuePrerequisite("Lvl", 7)
		];
	}
	
	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}