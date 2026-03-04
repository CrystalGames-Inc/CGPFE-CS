using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Characters.Inventory;
public class EquippedInventory
{
    public string Weapon { get; set; } = string.Empty;
    public string Armor { get; set; } = string.Empty;
    public string Shield { get; set; } = string.Empty;
}
