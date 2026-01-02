using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ExtraKi: Domain.Characters.Feats.Properties.Feat
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