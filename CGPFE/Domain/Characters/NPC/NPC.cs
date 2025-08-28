using CGPFE.Domain.Characters.Common;
using CGPFE.Domain.Characters.NPC.Properties;
using CGPFE.Domain.Characters.Player.Properties.Inventory;

namespace CGPFE.Domain.Characters.NPC;

public class NPC
{
    public Info Info;
    public Attributes Attributes;
    public CombatInfo? CombatInfo;
    public Inventory Inventory;

    public NPC(Info info, Attributes attributes) {
        Info = info;
        Attributes = attributes;
        CombatInfo = null;
    }
    
    public NPC(Info info, Attributes attributes, CombatInfo? combatInfo) {
        Info = info;
        Attributes = attributes;
        CombatInfo = combatInfo;
    }
}