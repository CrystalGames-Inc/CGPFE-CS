using CGPFE.Domain.Characters;
using CGPFE.Core.Utilities;
using CGPFE.Domain.Characters.Player;
using CGPFE.Domain.Items.Equipment.Offense;
using CGPFE.Storage.Items.Equipment.Offense;
using Storage.CombatActions.StandardActions;

namespace CGPFE.Management
{
    public class CombatManager
    {
        private static CombatManager? _instance = null;
        private static readonly object Padlock = new object();

        private Player Player;
        private Entity Enemy;

        public static CombatManager Instance
        {
            get
            {
                lock (Padlock)
                {
                    _instance ??= new CombatManager();
                }
                return _instance;
            }
        }

        public void StartCombat(Entity player, Entity other)
        {
            Player = (Player)player;
            Enemy = other;
            Console.WriteLine("Combat started!");
            if (Dice.Roll(20) + player.Attributes.Initiative.Value >= Dice.Roll(20) + Enemy.Attributes.Initiative.Value)
            {
                Console.WriteLine("You go first!");
                StartRound(Player);
            }
            else
            {
                Console.WriteLine("You go second!");
                StartRound(Enemy);
            }
        }

        public void StartRound(Entity entity)
        {
            entity.CombatInfo.ActionCount = 2;
            entity.CombatInfo.SwiftActionCount = 1;
            if (entity.GetType().Equals(typeof(Player)))
                StartPlayerRound();
            else
                StartNPCRound();
        }

        private void StartPlayerRound()
        {
            Console.WriteLine("It's your turn!");
            string actionType = PromptHelper.ListPrompt<string>("Choose an action type: ", ["Free", "Full Round", "Immediate", "Move", "None", "Standard", "Swift"]).ToLower();
            switch (actionType)
            {
                case "free":
                    throw new NotImplementedException("Free actions are not implemented yet!");
                case "full round":
                    throw new NotImplementedException("Full round actions are not implemented yet!");
                case "immediate":
                    throw new NotImplementedException("Immediate actions are not implemented yet!");
                case "move":
                    throw new NotImplementedException("Move actions are not implemented yet!");
                case "none":
                    throw new NotImplementedException("None actions are not implemented yet!");
                case "standard":
                    PlayerStandardAction();
                    break;
                case "swift":
                    throw new NotImplementedException("Swift actions are not implemented yet!");
            }
        }

        private void PlayerStandardAction()
        {
            string attackName = PromptHelper.ListPrompt<string>("Please choose the attack: ", Storage.CombatActions.CombatActions.StandardActions.Select(a => a.Name).ToList()).ToLower();
            switch (attackName)
            {
                case "attack (melee)":
                    AttackMeleeWeapon(Player, Enemy);
                    break;
                default:
                    throw new NotImplementedException("Every other action is not implemented yet!");
            }
        }

        private void StartNPCRound()
        {
            Console.WriteLine("It's the NPC's turn!");
            //For now he won't attack ;)
            StartRound(Player);
        }

        private void AttackMeleeWeapon(Entity attacker, Entity target)
        {
            new AttackMelee();
        }

        private int GetAttackBonus(Entity attacker, Weapon weapon)
        {
            int sizeMod = attacker.Attributes.SizeMod;
            int attrMod = weapon.GetType().Equals(typeof(RangedWeapon)) ? attacker.Attributes.Dexterity.Modifier : attacker.Attributes.Strength.Modifier;

            return sizeMod + attrMod;
        }
    }
}