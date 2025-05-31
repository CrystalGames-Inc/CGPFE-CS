using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ExtraRage: Domain.Characters.Feats.Properties.Feat
{
    public ExtraRage() : base("Extra Rage") {
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