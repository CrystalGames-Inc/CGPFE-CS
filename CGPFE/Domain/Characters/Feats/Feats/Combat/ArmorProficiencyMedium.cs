using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ArmorProficiencyMedium: Domain.Characters.Feats.Properties.Feat {
    public ArmorProficiencyMedium() : base("Armor Proficiency, Medium", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Armor Proficiency, Light")
        ];
    }

    public override bool CanAcquire()
    {
        throw new NotImplementedException();
    }

    public override void Benefits()
    {
        throw new NotImplementedException();
    }
}