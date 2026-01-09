using Domain.Characters.Common;
using Domain.Characters.NPC.Properties;
using Domain.Characters.Player.Properties.Inventory;

namespace Domain.Characters.NPC;

public class NPC : Entity
{
    public Info Info;
    public new Attributes Attributes;
    public new CombatInfo? CombatInfo;
    public Inventory Inventory;

    public NPC() {

    }

    public NPC(Info info, Attributes attributes, CombatInfo? combatInfo = null) {
        Info = info;
        Attributes = attributes;
        if (combatInfo != null)
            CombatInfo = combatInfo;
    }
}
