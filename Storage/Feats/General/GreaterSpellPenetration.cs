namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class GreaterSpellPenetration : Characters.Feats.Feat
{
    public GreaterSpellPenetration() : base("Greater Spell Penetration")
    {
        Prerequisites = [
            new FeatPrerequisite("Spell Penetration")
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