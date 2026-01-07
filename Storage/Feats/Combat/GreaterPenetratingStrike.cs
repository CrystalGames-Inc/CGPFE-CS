using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class GreaterPenetratingStrike : Feat
{
    public GreaterPenetratingStrike() : base("Greater Penetrating Strike", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Penetrating Strike"),
            new FeatPrerequisite("Weapon Focus"),
            new ValuePrerequisite("Cls", 7, "=="),
            new ValuePrerequisite("Lvl", 16)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}