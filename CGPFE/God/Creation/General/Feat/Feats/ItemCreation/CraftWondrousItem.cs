using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.ItemCreation;

public class CraftWondrousItem: Feat {
	public CraftWondrousItem() : base("Craft Wondrous Item", FeatType.ItemCreation) {
		Prerequisites = [
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