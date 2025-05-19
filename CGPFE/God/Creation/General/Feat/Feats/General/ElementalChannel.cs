using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class ElementalChannel: Feat {
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