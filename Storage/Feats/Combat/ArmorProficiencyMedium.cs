using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

namespace Storage.Feats.Combat;

public class ArmorProficiencyMedium : Feat
{
    public ArmorProficiencyMedium() : base("Armor Proficiency, Medium", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Armor Proficiency, Light")
        ];
    }

    public override bool CanAcquire(Player player) {
        throw new NotImplementedException();
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
