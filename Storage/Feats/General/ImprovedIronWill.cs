using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class ImprovedIronWill : Feat
{
    public ImprovedIronWill() : base("Improved Iron Will") {
        Prerequisites = [
            new FeatPrerequisite("Iron Will")
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}