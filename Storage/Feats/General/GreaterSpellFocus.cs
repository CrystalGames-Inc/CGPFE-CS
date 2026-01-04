namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class GreaterSpellFocus : Characters.Feats.Feat
{
    public GreaterSpellFocus() : base("Greater Spell Focus")
    {
        Prerequisites = [
            new FeatPrerequisite("Spell Focus")
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