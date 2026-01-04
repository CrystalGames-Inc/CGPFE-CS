namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ExtraRage : Characters.Feats.Feat
{
    public ExtraRage() : base("Extra Rage") {
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