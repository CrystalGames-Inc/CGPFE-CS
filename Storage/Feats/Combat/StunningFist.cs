using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Storage.Feats.Combat;

public class StunningFist : Feat
{
    public StunningFist() : base("Stunning Fist", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Dex", 13),
            new ValuePrerequisite("Wis", 13),
            new FeatPrerequisite("Improved Unarmed Strike"),
            new ValuePrerequisite("Bab", 8)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}