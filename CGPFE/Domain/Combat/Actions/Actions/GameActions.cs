using CGPFE.Domain.Combat.Actions.Actions.FreeActions;
using CGPFE.Domain.Combat.Actions.Actions.FullRoundActions;
using CGPFE.Domain.Combat.Actions.Actions.ImmediateActions;
using CGPFE.Domain.Combat.Actions.Actions.MoveActions;
using CGPFE.Domain.Combat.Actions.Actions.NoActions;
using CGPFE.Domain.Combat.Actions.Actions.StandardActions;
using CGPFE.Domain.Combat.Actions.Actions.SwiftActions;
using CGPFE.Domain.Combat.Actions.Base;

namespace CGPFE.Domain.Combat.Actions.Actions;

public static class GameActions {
	private static List<CombatAction> FreeActions { get; } = [
		new CeaseSpellConcentration(),
		new DropItem(),
		new DropToFloor(),
		new PrepareSpellComponents(),
		new Speak()
	];

	private static List<CombatAction> FullRoundActions { get; } = [
		new Charge(),
		new DeliverCoupDeGrace(),
		new EscapeNet(),
		new ExtinguishFlames(),
		new FullAttack(),
		new LightTorch(),
		new LoadHeavyRepeatingCrossbow(),
		new LockUnlockGauntletWeapon(),
		new PrepareSplashPotion(),
		new Run(),
		new Use1RoundSkill(),
		new UseTouchSpell(),
		new Withdraw()
	];

	private static List<CombatAction> ImmediateActions { get; } = [
		new CastFeatherFall()
	];

	private static List<CombatAction> MoveActions { get; } = [
		new ControlFrightenedMount(),
		new DirectActiveSpell(),
		new DrawWeapon(),
		new LoadLightHandCrossbow(),
		new MountDismountSteed(),
		new Move(),
		new MoveHeavyObject(),
		new OpenCloseDoor(),
		new PickUpItem(),
		new ReadyDropShield(),
		new RetrieveStoredItem(),
		new SheatheWeapon(),
		new StandUpFromProne()
	];

	private static List<CombatAction> NoActions { get; } = [
		new Delay(),
		new FiveFootStep()
	];
	
	private static List<CombatAction> StandardActions { get; } = [
		new ActivateMagicItem(),
		new AidAnother(),
		new AttackMelee(),
		new AttackRanged(),
		new AttackUnarmed(),
		new CastSpell(),
		new ChannelEnergy(),
		new ConcentrateMaintainActiveSpell(),
		new DismissSpell(),
		new DrawHiddenWeapon(),
		new EscapeGrapple(),
		new Feint(),
		new LightTorchWithTinderwig(),
		new LowerSpellResistance(),
		new ReadScroll(),
		new ReadScroll(),
		new StabilizeDyingFriend(),
		new TotalDefense(),
		new Use1ActionSkill(),
		new UseExtraordinaryAbility(),
		new UsePotionOil(),
		new UseSpellLikeAbility(),
		new UseSupernaturalAbility()
	];

	private static List<CombatAction> SwiftActions { get; } = [
		new CastQuickenedSpell()
	];
}