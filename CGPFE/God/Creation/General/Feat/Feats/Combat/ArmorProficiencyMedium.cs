using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class ArmorProficiencyMedium: Feat {
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