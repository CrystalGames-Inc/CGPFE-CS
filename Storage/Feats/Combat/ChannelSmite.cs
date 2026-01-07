using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class ChannelSmite : Feat
{
    public ChannelSmite() : base("Channel Smite", FeatType.Combat) {
        Prerequisites = [
			// TODO add the prerequisites
		];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}