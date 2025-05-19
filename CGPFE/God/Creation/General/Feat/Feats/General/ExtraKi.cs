using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class ExtraKi: Feat
{
    public ExtraKi() : base("Extra Ki") {
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