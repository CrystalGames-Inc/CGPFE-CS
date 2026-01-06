using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Storage.Feats.Combat;

public class DoubleSlice : Feat
{
    public DoubleSlice() : base("Double Slice", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Dex", 15),
            new FeatPrerequisite("Two-WeaponFighting")
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}