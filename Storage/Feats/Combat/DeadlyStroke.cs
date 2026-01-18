using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

namespace Storage.Feats.Combat;

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

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
