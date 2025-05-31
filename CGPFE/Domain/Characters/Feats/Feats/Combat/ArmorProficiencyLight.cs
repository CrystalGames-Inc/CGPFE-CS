using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ArmorProficiencyLight() : Domain.Characters.Feats.Properties.Feat("Armor Proficiency, Light", FeatType.Combat) {
    public override bool CanAcquire() {
        return true;
    }

    public override void Benefits()
    {
        throw new NotImplementedException();
    }
}