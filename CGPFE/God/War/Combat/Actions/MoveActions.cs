using CGPFE.God.War.Combat.Action.ActionTypes;

namespace CGPFE.God.War.Combat.Actions;

public class ControlFrightenedMount() : MoveAction("Control a frightened mount", true) {
	
}

public class DirectActiveSpell() : MoveAction("Direct active spell", false) {
	
}

public class DrawWeapon() : MoveAction("Draw a weapon", false) {
	
}

public class LoadLightHandCrossbow() : MoveAction("Load a hand crossbow or light crossbow", true) {
	
}

public class Move() : MoveAction("Move", true) {
	
}

public class OpenCloseDoor() : MoveAction("Open or close a door", false) {
	
}

public class MountDismountSteed() : MoveAction("Mount or dismount a steed", false) {
	
}

public class MoveHeavyObject() : MoveAction("Move a heavy object", true) {
	
}

public class PickUpItem() : MoveAction("Pick up an item", true) {
	
}

public class SheatheWeapon() : MoveAction("Sheathe a weapon", true) {
	
}

public class StandUpFromProne() : MoveAction("Stand up from Prone", true) {
	
}

public class ReadyDropShield() : MoveAction("Ready or drop a shield", false) {
	
}

public class RetrieveStoredItem() : MoveAction("Retrieve a stored item", true) {
	
}