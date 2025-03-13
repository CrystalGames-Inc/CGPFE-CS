using CGPFE.God.War.Combat.Action.ActionTypes;

namespace CGPFE.God.War.Combat.Actions;

public class AttackMelee() : StandardAction("Attack (melee)", false) {
	
}

public class AttackRanged() : StandardAction("Attack (ranged)", true) {
	
}

public class AttackUnarmed() : StandardAction("Attack (unarmed)", true) {
	
}

public class ActivateMagicItem() : StandardAction("Activate a magic item", false) {
	
}

public class AidAnother() : StandardAction("Aid another", true) {
	
}

public class CastSpell() : StandardAction("Cast a spell", true) {
	
}

public class ChannelEnergy() : StandardAction("Channel energy", false) {
	
}

public class ConcentrateMaintainActiveSpell() : StandardAction("Concentrate to maintain an active spell", false) {
	
}

public class DismissSpell() : StandardAction("Dismiss a spell", false) {
	
}

public class DrawHiddenWeapon() : StandardAction("Draw a hidden weapon", false) {
	
}

public class UsePotionOil() : StandardAction("Use a potion or apply an oil", true) {
	
}

public class EscapeGrapple() : StandardAction("Escape a grapple", false) {
	
}

public class Feint() : StandardAction("Feint", false) {
	
}

public class LightTorchWithTinderwig() : StandardAction("Light a torch with a tinderwig", true) {
	
}

public class LowerSpellResistance() : StandardAction("Lower Spell Resistance", false) {
	
}

public class ReadScroll() : StandardAction("Read a scroll", true) {
	
}

public class Ready() : StandardAction("Ready", false) {
	
}

public class StabilizeDyingFriend() : StandardAction("Stabilize a dying friend", true) {
	
}

public class TotalDefense() : StandardAction("Total defense", false) {
	
}

public class UseExtraordinaryAbility() : StandardAction("Use extraordinary ability", false) {
	
}

public class Use1ActionSkill() : StandardAction("Use skill that takes 1 action", true) {
	
}

public class UseSpellLikeAbility() : StandardAction("Use a spell-like ability", true) {
	
}

public class UseSupernaturalAbility() : StandardAction("Use supernatural ability", false) {
	
}