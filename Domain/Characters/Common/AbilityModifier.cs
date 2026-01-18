using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Common
{
    public record AbilityModifier(
        int Value,
        ModifierSourceType Srouce
        );
}
