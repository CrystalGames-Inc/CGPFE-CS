using CGPFE.Domain.Characters.Common;

namespace CGPFE.Domain.Characters.Common
{
    public readonly record struct AbilityScore(int Value, List<AbilityModifier>? AbilityModifier = null)
    {
        public static AbilityScore operator +(AbilityScore a, int value) => new(a.Value + value);
        public static AbilityScore operator -(AbilityScore a, int value) => new(a.Value - value);
        public int Modifier {
            get
            {
                if (AbilityModifier == null)
                    return (Value - 10) / 2;
                return ((Value - 10) / 2) + AbilityModifier.Sum(m => m.Value);
            }
        }
    }
}
