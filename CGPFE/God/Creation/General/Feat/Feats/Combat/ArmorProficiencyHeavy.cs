using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feats.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feats.Feats.Combat;

public class ArmorProficiencyHeavy: Feat
{
    public ArmorProficiencyHeavy() : base("Armor Proficiency, Heavy", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Armor Proficiency, Light")
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void Benefits() {
        throw new NotImplementedException();
    }
}