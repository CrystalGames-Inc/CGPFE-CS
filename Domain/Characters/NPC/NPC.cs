using CGPFE.Domain.Characters.Common;
using CGPFE.Domain.Characters.NPC.Properties;
using CGPFE.Domain.Characters.Player.Properties.Inventory;

namespace CGPFE.Domain.Characters.NPC;

public class NPC : Entity
{
    public Info Info;
    public new Attributes Attributes;
    public new CombatInfo? CombatInfo;
    public Inventory Inventory;

    public NPC()
    {

    }

    public NPC(Info info, Attributes attributes, CombatInfo? combatInfo = null)
    {
        Info = info;
        Attributes = attributes;
        if (combatInfo != null)
            CombatInfo = combatInfo;
    }
}