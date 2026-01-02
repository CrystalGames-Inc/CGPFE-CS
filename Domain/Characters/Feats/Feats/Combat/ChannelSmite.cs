using CGPFE.Core.Enums;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ChannelSmite: Domain.Characters.Feats.Properties.Feat {
	public ChannelSmite() : base("Channel Smite", FeatType.Combat) {
		Prerequisites = [
			// TODO add the prerequisites
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}