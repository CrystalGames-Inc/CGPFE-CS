using CGPFE.Domain.Characters.Common;
using CGPFE.Domain.Characters.NPC.Properties;

namespace CGPFE.Domain.Characters.NPC;

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