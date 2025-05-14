using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feats.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feats.Feats.Combat;

public class ArcaneArmorMastery : Feat {

	public ArcaneArmorMastery() : base("Arcane Armor Mastery", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Arcane Armor Training"),
			new FeatPrerequisite("Medium Armor Proficiency"),
			new LevelPrerequisite(7)
		];
	}
	
	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}