using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ArmorProficiencyMedium : Feat
{
    public ArmorProficiencyMedium() : base("Armor Proficiency, Medium", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Armor Proficiency, Light")
        ];
    }

    public override bool CanAcquire(Player.Player player)
    {
        throw new NotImplementedException();
    }

    public override void ApplyBenefits(ref Player.Player player)
    {
        throw new NotImplementedException();
    }
}