using Domain.Characters;
using Core.Utilities;

namespace Management
{
    public class CombatManager
    {
        private static CombatManager? _instance = null;
        private static readonly object Padlock = new object();
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

        public void StartCombat(Entity other)
        {
            bool playerFirst = false;
            Console.WriteLine("Combat started!");
            if (Dice.Roll(20) + PlayerDataManager.Instance.Player.CombatInfo.InitMod >= Dice.Roll(20) + other.CombatInfo.InitMod)
            {
                Console.WriteLine("You go first!");
                playerFirst = true;
            }
            else
                Console.WriteLine("You go second!");
        }
    }
}
