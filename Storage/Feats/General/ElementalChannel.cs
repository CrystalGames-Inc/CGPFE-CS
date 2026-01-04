namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ElementalChannel : Characters.Feats.Feat
{
    public ElementalChannel() : base("Elemental Channel")
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