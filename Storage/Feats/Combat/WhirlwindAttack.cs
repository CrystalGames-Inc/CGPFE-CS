using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class WhirlwindAttack : Feat
{
    public WhirlwindAttack() : base("Whirlwind Attack", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Dex", 13),
            new ValuePrerequisite("Int", 13),
            new FeatPrerequisite("Combat Expertise"),
            new FeatPrerequisite("Dodge"),
            new FeatPrerequisite("Mobility"),
            new FeatPrerequisite("Spring Attack"),
            new ValuePrerequisite("Bab", 4)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}