using CGPFE.Core.Enums;
using CGPFE.Domain.World.Geography;

namespace CGPFE.Domain.Characters.Player.Properties;

public class PlayerInfo
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public Alignment Alignment { get; set; }
    public int Age { get; set; }
    public Race Race { get; set; }
    public Size Size { get; set; }
    public Class Class { get; set; }
    public int Level { get; set; }
    public int Xp { get; set; }
    public int MaxHealth { get; set; }
    public int Health { get; set; }
    public Region? CurrentRegion { get; set; }
    public Location? CurrentLocation { get; set; }

    public int GetSizeMod()
    {
        return Size switch
        {
            Size.Fine => 8,
            Size.Diminutive => 6,
            Size.Tiny => 4,
            Size.Small => 2,
            Size.Medium => 0,
            Size.Large => -2,
            Size.Huge => -4,
            Size.Gargantuan => -6,
            Size.Colossal => -8,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}