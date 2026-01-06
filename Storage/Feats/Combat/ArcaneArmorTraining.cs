using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Storage.Feats.Combat;

public class ArcaneArmorTraining : Feat {

    public ArcaneArmorTraining() : base("Arcane Armor Training", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Light Armor Proficiency"),
            new ValuePrerequisite("Lvl", 3)
        ];
    }
    
    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}