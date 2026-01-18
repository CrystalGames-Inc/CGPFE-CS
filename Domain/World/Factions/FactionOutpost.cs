using CGPFE.Domain.World.Geography;
using CGPFE.Core.Enums;

namespace CGPFE.Domain.World.Factions;

public class FactionOutpost(string name, OutpostType type) : Location(name, null, null)
{
    public OutpostType OutpostType = type;
}
