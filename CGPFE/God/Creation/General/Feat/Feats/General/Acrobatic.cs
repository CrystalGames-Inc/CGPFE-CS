using CGPFE.God.Creation.General.Feats;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class Acrobatic: Creation.General.Feats.Feat {
	public Acrobatic() : base("Acrobatic") {
		Prerequisites = new List<IPrerequisite>();
	}

	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.GetMatchingSkill("Acrobatics").Bonus.MiscMod += 2;
		PlayerDataManager.Instance.Player.GetMatchingSkill("Fly").Bonus.MiscMod += 2;
	}
}