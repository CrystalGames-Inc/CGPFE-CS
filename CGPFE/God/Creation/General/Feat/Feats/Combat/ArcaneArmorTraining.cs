using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class ArcaneArmorTraining : Feat {

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