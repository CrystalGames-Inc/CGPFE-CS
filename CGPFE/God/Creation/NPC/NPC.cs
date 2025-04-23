using CGPFE.Data.Models.Item.Equipment.Offense;
using CGPFE.God.Creation.General;
using CGPFE.God.Creation.NPC.Properties;

namespace CGPFE.God.Creation.NPC;

public class NPC
{
    public Info Info;
    public Attributes Attributes;
    public CombatInfo? CombatInfo;
    //TODO Add inventory.

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