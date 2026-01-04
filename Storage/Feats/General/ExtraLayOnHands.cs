namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ExtraLayOnHands : Characters.Feats.Feat
{
    public ExtraLayOnHands() : base("Extra Lay On Hands")
    {
        Prerequisites = [

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