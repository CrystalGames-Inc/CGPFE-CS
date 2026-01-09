using CGPFE.Domain.Characters.Common;

namespace CGPFE.Domain.Characters.Common
{
    public readonly record struct AbilityScore(int value, List<AbilityModifier>? AbilityModifier = null)
    {
        public static AbilityScore operator +(AbilityScore a, int value) => new(a.value + value);
        public static AbilityScore operator -(AbilityScore a, int value) => new(a.value - value);
        public int Modifier() {
            if (AbilityModifier == null)
                return (value - 10) / 2;
            return ((value - 10) / 2) + AbilityModifier.Sum(m => m.Value);
        }
    }
}
