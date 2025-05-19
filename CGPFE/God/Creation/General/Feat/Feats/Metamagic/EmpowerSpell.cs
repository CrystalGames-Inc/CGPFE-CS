using CGPFE.Data.Constants;

namespace CGPFE.God.Creation.General.Feat.Feats.Metamagic;

public class EmpowerSpell() : Feat("Empower Spell", FeatType.Metamagic) 
{
    public override bool CanAcquire() {
        return true;
    }

    public override void Benefits() {
        throw new NotImplementedException();
    }
}