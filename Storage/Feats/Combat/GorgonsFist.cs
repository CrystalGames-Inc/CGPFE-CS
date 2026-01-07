using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class GorgonsFist : Feat
{
    public GorgonsFist() : base("Gorgon's Fist", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Improved Unarmed Strike"),
            new FeatPrerequisite("Scorpion Style"),
            new ValuePrerequisite("Bab", 6)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}