using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ArcaneArmorTraining : Characters.Feats.Feat
{

    public ArcaneArmorTraining() : base("Arcane Armor Training", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Light Armor Proficiency"),
            new ValuePrerequisite("Lvl", 3)
        ];
    }

    public override bool CanAcquire()
    {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits()
    {
        throw new NotImplementedException();
    }
}