using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Storage.Feats.Combat;

public class ArcaneArmorMastery : Feat
{

    public ArcaneArmorMastery() : base("Arcane Armor Mastery", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Arcane Armor Training"),
            new FeatPrerequisite("Medium Armor Proficiency"),
            new ValuePrerequisite("Lvl", 7)
        ];
    }
    
    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}