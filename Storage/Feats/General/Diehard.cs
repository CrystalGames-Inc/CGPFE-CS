namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Diehard : Characters.Feats.Feat
{
    public Diehard() : base("Diehard") {
        Prerequisites = [
            new FeatPrerequisite("Endurance")
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}