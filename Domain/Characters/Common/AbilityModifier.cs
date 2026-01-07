using Core.Enums;

namespace Domain.Characters.Common
{
    public record AbilityModifier(
        int Value,
        ModifierSourceType Srouce
        );
}
