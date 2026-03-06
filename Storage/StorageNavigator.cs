using CGPFE.Domain.Characters;
using CGPFE.Domain.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage;
public static class StorageNavigator
{
    public static T? GetMatchingItem<T> (string name, List<T> list) where T : Item
    {
        if (string.IsNullOrEmpty(name) || list == null) return null;
        return list.FirstOrDefault(i =>
            !string.IsNullOrEmpty(i?.ToString()) &&
            i.Name.ToString().Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}
