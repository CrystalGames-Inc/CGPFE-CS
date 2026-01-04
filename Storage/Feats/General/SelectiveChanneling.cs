namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class SelectiveChanneling : Characters.Feats.Feat
{
    public SelectiveChanneling() : base("Selective Channeling")
    {
        Prerequisites = [
            new ValuePrerequisite("Cha", 13),
			//TODO add class feature prerequisite
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