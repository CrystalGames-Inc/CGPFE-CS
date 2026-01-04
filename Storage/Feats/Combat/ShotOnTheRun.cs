using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ShotOnTheRun : Feat
{
    public ShotOnTheRun() : base("Shot On The Run", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Dex", 13),
            new FeatPrerequisite("Dodge"),
            new FeatPrerequisite("Mobility"),
            new FeatPrerequisite("Point-Blank Shot"),
            new ValuePrerequisite("Bab", 4)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}