using CGPFE.Domain.Characters.Skill;
using System.Collections.Generic;

namespace CGPFE.Domain.Characters.Feat;

public interface IPrerequisite
{
    bool IsSatisfiedBy(Player.Player player, List<Skill.Skill>? skills = null);
}
