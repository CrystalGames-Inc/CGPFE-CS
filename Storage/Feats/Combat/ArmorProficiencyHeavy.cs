using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ArmorProficiencyHeavy : Characters.Feats.Feat
{
    public ArmorProficiencyHeavy() : base("Armor Proficiency, Heavy", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Armor Proficiency, Light")
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