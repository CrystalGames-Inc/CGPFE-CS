using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class DoubleSlice: Domain.Characters.Feats.Properties.Feat {
	public DoubleSlice() : base("Double Slice", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Dex", 15),
			new FeatPrerequisite("Two-WeaponFighting")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}