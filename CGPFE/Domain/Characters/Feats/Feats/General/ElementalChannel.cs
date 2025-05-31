using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ElementalChannel: Domain.Characters.Feats.Properties.Feat {
    public ElementalChannel() : base("Elemental Channel") {
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