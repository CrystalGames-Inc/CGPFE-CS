using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class RapidReload : Characters.Feats.Feat
{
    public RapidReload() : base("Rapid Reload", FeatType.Combat)
    {
        Prerequisites = [
			//TODO add the shit
		];
    }

    public override bool CanAcquire()
    {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits()
    {
        throw new NotImplementedException();
    }
}