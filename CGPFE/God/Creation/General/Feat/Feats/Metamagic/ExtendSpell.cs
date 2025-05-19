using CGPFE.Data.Constants;

namespace CGPFE.God.Creation.General.Feat.Feats.Metamagic;

public class ExtendSpell(): Feat("Extend Spell", FeatType.Metamagic)
{
    public override bool CanAcquire() {
        return true;
    }

    public override void Benefits() {
        throw new NotImplementedException();
    }
}