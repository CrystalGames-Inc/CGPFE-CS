namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ImprovedFamiliar : Characters.Feats.Feat
{
    public ImprovedFamiliar() : base("Improved Familiar")
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