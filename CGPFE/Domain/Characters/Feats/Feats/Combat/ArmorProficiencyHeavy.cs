using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ArmorProficiencyHeavy: Domain.Characters.Feats.Properties.Feat
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