using CGPFE.Core.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPFE.Domain.Characters.Common
{
    public record AbilityModifier(
        int Value,
        ModifierSourceType Srouce
        );
}
