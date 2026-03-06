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
            int pInit = Dice.Roll(20);
            Console.WriteLine($"You rolled a {pInit}");
            int eInit = Dice.Roll(20);
            Console.WriteLine($"The enemy rolled a {eInit}");

            int pMod = 0;
            if(player.Attributes.Initiative == null)
                pMod = player.Attributes.Initiative.Value;

            int eMod = 0;
            if(other.Attributes.Initiative == null)
                eMod += other.Attributes.Initiative.Value;

            if (pMod != 0 || eMod != 0)Console.WriteLine($"After adding the initiative modifiers, you got a {pInit + pMod},\nand the enemy got {eInit + eMod}!");
            if (pInit + pMod >= eInit + eMod)
            {
                Console.WriteLine("You go first!");
                StartRound(Player, Enemy);
            }
            else
            {
                Console.WriteLine("You go second!");
                StartRound(Enemy, Player);
            }
        }

        public void StartRound(Entity attacker, Entity target)
        {
            do
            {
                attacker.CombatInfo.ActionCount = 2;
                attacker.CombatInfo.SwiftActionCount = 1;
                if (attacker.GetType().Equals(typeof(Player)))
                    StartPlayerRound();
                else
                    StartNPCRound();
            } while (attacker.CombatInfo.Health > 0 && target.CombatInfo.Health > 0);
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
            StartRound(Player, Enemy);
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