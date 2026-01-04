namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class CommandUndead : Characters.Feats.Feat
{
    public CommandUndead() : base("Command Undead") {
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