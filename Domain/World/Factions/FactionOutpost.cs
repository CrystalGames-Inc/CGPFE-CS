using Domain.World.Geography;
using Core.Enums;

namespace Domain.World.Factions;

public class FactionOutpost(string name, OutpostType type) : Location(name, null, null)
{
    public OutpostType OutpostType = type;
}
