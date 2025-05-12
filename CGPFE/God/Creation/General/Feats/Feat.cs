using CGPFE.Data.Constants;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feats;

public interface Feat
{
    public string Name();
    public FeatType Type();
    public bool CanAcquire();
}