using CGPFE.Domain.World.Geography;
using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Player.Properties;

public class PlayerInfo
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public Alignment Alignment { get; set; }
    public int Age { get; set; }
    public Race Race { get; set; }
    public Class Class { get; set; }
    public int Level { get; set; }
    public int Xp { get; set; }
    public Region? CurrentRegion { get; set; }
    public Location? CurrentLocation { get; set; }
}
