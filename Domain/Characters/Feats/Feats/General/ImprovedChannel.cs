using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ImprovedChannel: Domain.Characters.Feats.Properties.Feat {
	public ImprovedChannel() : base("Improved Channel") {
		Prerequisites = [
			
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}