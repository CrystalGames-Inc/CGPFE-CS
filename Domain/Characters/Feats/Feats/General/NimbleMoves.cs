using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class NimbleMoves: Domain.Characters.Feats.Properties.Feat {
	public NimbleMoves() : base("Nimble Moves") {
		Prerequisites = [
			new ValuePrerequisite("Dex", 13)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}