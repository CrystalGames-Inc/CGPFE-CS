namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ExtraKi : Characters.Feats.Feat
{
    public ExtraKi() : base("Extra Ki") {
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