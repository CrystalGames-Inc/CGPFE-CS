using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class SelectiveChanneling: Feat {
	public SelectiveChanneling() : base("Selective Channeling") {
		Prerequisites = [
			new ValuePrerequisite("Cha", 13),
			//TODO add class feature prerequisite
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}