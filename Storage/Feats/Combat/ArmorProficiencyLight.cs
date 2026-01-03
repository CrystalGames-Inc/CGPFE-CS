using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ArmorProficiencyLight() : Characters.Feats.Feat("Armor Proficiency, Light", FeatType.Combat) {
    public override bool CanAcquire() {
        return true;
    }

    public override void ApplyBenefits()
    {
        throw new NotImplementedException();
    }
}