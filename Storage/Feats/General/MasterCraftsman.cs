using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class MasterCraftsman : Feat
{
    public MasterCraftsman() : base("Master Craftsman") {
        Prerequisites = [
            new SkillRankPrerequisite("Craft", 5),
            new SkillRankPrerequisite("Profession", 5)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.Any(prereq => prereq.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}