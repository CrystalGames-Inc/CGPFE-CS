using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.ItemCreation;

public class CraftRod: Feat {
	public CraftRod() : base("Craft Rod", FeatType.ItemCreation) {
		Prerequisites = [
			new ValuePrerequisite("Lvl", 9)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}