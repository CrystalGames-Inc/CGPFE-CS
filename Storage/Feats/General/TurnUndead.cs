namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class TurnUndead : Characters.Feats.Feat
{
    public TurnUndead() : base("Turn Undead") {
        Prerequisites = [
			//TODO add the prerequisites
		];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}