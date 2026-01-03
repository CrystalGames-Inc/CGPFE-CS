using CGPFE.Storage.CombatActions.FreeActions;
using CGPFE.Storage.CombatActions.FullRoundActions;
using CGPFE.Storage.CombatActions.ImmediateActions;
using CGPFE.Storage.CombatActions.MoveActions;
using CGPFE.Storage.CombatActions.NoActions;
using CGPFE.Storage.CombatActions.StandardActions;
using CGPFE.Storage.CombatActions.SwiftActions;
using Domain.Combat.Action;

namespace CGPFE.Storage.CombatActions.Actions;

public static class GameActions {
	public static List<CombatAction> FreeActions { get; } = [
		new CeaseSpellConcentration(),
		new DropItem(),
		new DropToFloor(),
		new PrepareSpellComponents(),
		new Speak()
	];

	public static List<CombatAction> FullRoundActions { get; } = [
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

	public static List<CombatAction> ImmediateActions { get; } = [
		new CastFeatherFall()
	];

	public static List<CombatAction> MoveActions { get; } = [
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

	public static List<CombatAction> NoActions { get; } = [
		new Delay(),
		new FiveFootStep()
	];
	
	public static List<CombatAction> StandardActions { get; } = [
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

	public static List<CombatAction> SwiftActions { get; } = [
		new CastQuickenedSpell()
	];
}