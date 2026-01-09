using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;
using Core.Enums;

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
