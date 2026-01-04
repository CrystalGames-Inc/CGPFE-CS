namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ImprovedChannel : Characters.Feats.Feat
{
    public ImprovedChannel() : base("Improved Channel")
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