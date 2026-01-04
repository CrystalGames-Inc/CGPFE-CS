using CGPFE.Core.Enums;
using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ChannelSmite : Feat
{
    public ChannelSmite() : base("Channel Smite", FeatType.Combat) {
        Prerequisites = [
			// TODO add the prerequisites
		];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}