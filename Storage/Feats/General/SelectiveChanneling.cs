using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;

namespace Storage.Feats.General;

public class SelectiveChanneling : Feat
{
    public SelectiveChanneling() : base("Selective Channeling") {
        Prerequisites = [
            new ValuePrerequisite("Cha", 13),
			//TODO add class feature prerequisite
		];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
