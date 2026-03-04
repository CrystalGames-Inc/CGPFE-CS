using CGPFE.Domain.Characters;
using CGPFE.Domain.Characters.Common;
using CGPFE.Domain.Characters.NPC.Properties;
using Domain.Characters.Inventory;

namespace CGPFE.Domain.Characters.NPC;

public class NPC : Entity
{
    public NPCInfo Info;
    public new Attributes Attributes;
    public new CombatInfo? CombatInfo;
    public Inventory? Inventory;

    public NPC() {

    }
}
