namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ExtraMercy : Characters.Feats.Feat
{
    public ExtraMercy() : base("Extra Mercy") {
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