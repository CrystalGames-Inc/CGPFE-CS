namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ExtraPerformance : Characters.Feats.Feat
{
    public ExtraPerformance() : base("Extra Performance") {
        Prerequisites = [

        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}