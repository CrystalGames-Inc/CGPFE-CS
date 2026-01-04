namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Leadership : Characters.Feats.Feat
{
    public Leadership() : base("Leadership")
    {
        Prerequisites = [
            new ValuePrerequisite("Lvl", 7)
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