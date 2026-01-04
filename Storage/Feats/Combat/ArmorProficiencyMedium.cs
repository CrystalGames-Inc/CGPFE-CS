using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ArmorProficiencyMedium : Characters.Feats.Feat
{
    public ArmorProficiencyMedium() : base("Armor Proficiency, Medium", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Armor Proficiency, Light")
        ];
    }

    public override bool CanAcquire()
    {
        throw new NotImplementedException();
    }

    public override void ApplyBenefits()
    {
        throw new NotImplementedException();
    }
}