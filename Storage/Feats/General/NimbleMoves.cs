namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class NimbleMoves : Characters.Feats.Feat
{
    public NimbleMoves() : base("Nimble Moves") {
        Prerequisites = [
            new ValuePrerequisite("Dex", 13)
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}