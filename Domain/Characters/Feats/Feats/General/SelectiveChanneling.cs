using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class SelectiveChanneling: Domain.Characters.Feats.Properties.Feat {
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