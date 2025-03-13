using CGPFE.God.War.Combat.Action.ActionTypes;

namespace CGPFE.God.War.Combat.Actions;

public class Charge() : FullRoundAction("Charge", false) {
	
}

public class DeliverCoupDeGrace() : FullRoundAction("Deliver Coup De Grace", true) {
	
}

public class EscapeNet() : FullRoundAction("Escape from net", true) {
	
}

public class ExtinguishFlames() : FullRoundAction("Extinguish Flames", false) {
	
}

public class FullAttack() : FullRoundAction("Full attack", false) {
	
}

public class LightTorch() : FullRoundAction("Light a torch", true) {
	
}

public class LoadHeavyRepeatingCrossbow() : FullRoundAction("Load a heavy or repeating crossbow", true) {
	
}

public class LockUnlockGauntletWeapon() : FullRoundAction("Lock or unlock weapon in locked gauntlet", true) {
	
}

public class PrepareSplashPotion() : FullRoundAction("Prepare to throw splash potion", true) {
	
}

public class Run() : FullRoundAction("Run", true) {
	
}

public class Use1RoundSkill() : FullRoundAction("Use skill that takes 1 round", true) {
	
}

public class UseTouchSpell() : FullRoundAction("Use a touch spell on up to 6 friends", true) {
	
}

public class Withdraw() : FullRoundAction("Withdraw", false) {
	
}