namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ImprovedCounterspell(): Characters.Feats.Feat("Improved Counterspell") {
	public override bool CanAcquire() {
		return true;
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}