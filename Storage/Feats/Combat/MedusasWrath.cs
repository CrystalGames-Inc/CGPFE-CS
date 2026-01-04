using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class MedusasWrath : Feat
{
    public MedusasWrath() : base("Medusa's Wrath", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Improved Unarmed Strike"),
            new FeatPrerequisite("Gorgon's Fist"),
            new FeatPrerequisite("Scorpion Style"),
            new ValuePrerequisite("Bab", 11)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}