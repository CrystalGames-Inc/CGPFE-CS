namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Run(): Characters.Feats.Feat("Run") {
	public override bool CanAcquire() {
		return true;
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}