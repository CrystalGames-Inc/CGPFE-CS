using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class DeadlyStroke : Feat
{
    public DeadlyStroke() : base("Deadly Stroke", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Dazzling Display"),
            new FeatPrerequisite("Greater Weapon Focus"),
            new FeatPrerequisite("Shatter Defenses"),
            new FeatPrerequisite("Weapon Focus"),
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