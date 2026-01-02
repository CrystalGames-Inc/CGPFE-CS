using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ImprovedGreatFortitude: Domain.Characters.Feats.Properties.Feat {
	public ImprovedGreatFortitude() : base("Improved Great Fortitude") {
		Prerequisites = [
			new FeatPrerequisite("Great Fortitude")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}