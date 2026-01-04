using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class MedusasWrath : Characters.Feats.Feat
{
    public MedusasWrath() : base("Medusa's Wrath", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Improved Unarmed Strike"),
            new FeatPrerequisite("Gorgon's Fist"),
            new FeatPrerequisite("Scorpion Style"),
            new ValuePrerequisite("Bab", 11)
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