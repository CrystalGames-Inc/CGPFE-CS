using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class CommandUndead : Feat
{
    public CommandUndead() : base("Command Undead") {
        Prerequisites = [

        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}