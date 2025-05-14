using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feats.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feats.Feats.Combat;

public class ArcaneArmorTraining : Feat {

	public ArcaneArmorTraining() : base("Arcane Armor Training", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Light Armor Proficiency"),
			new LevelPrerequisite(3)
		];
	}
	
	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}