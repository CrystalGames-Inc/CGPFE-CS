using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class ExtraLayOnHands: Feat
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