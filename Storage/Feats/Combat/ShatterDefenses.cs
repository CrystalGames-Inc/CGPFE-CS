using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class ShatterDefenses : Feat
{
    public ShatterDefenses() : base("Shatter Defenses", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Weapon Focus"),
            new FeatPrerequisite("Dazzling Display"),
            new ValuePrerequisite("Bab", 6),
			//TODO Add specific weapon proficiency
		];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}