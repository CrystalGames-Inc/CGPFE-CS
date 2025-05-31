using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ExtraLayOnHands: Domain.Characters.Feats.Properties.Feat
{
    public ExtraLayOnHands() : base("Extra Lay On Hands") {
        Prerequisites = [
            
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void Benefits() {
        throw new NotImplementedException();
    }
}