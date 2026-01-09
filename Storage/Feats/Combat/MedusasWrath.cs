using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

namespace Storage.Feats.Combat;

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

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
