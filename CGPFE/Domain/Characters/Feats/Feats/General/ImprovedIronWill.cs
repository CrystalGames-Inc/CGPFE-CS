using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ImprovedIronWill: Domain.Characters.Feats.Properties.Feat {
	public ImprovedIronWill() : base("Improved Iron Will") {
		Prerequisites = [
			new FeatPrerequisite("Iron Will")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}