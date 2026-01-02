using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ExtraMercy: Domain.Characters.Feats.Properties.Feat
{
    public ExtraMercy() : base("Extra Mercy") {
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