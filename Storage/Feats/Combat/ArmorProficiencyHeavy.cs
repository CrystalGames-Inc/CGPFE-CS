using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ArmorProficiencyHeavy : Feat
{
    public ArmorProficiencyHeavy() : base("Armor Proficiency, Heavy", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Armor Proficiency, Light")
        ];
    }

    public override bool CanAcquire(Player.Player player)
    {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player)
    {
        throw new NotImplementedException();
    }
}