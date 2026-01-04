namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class SpellMastery : Characters.Feats.Feat
{
    public SpellMastery() : base("Spell Mastery")
    {
        Prerequisites = [
            new ValuePrerequisite("Cls", 17, "=="),
            new ValuePrerequisite("Lvl", 1)
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