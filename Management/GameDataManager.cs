using CGPFE.Core.Enums;
using CGPFE.Core.Utilities;
using CGPFE.Domain.Game;

namespace CGPFE.Management;

public class GameDataManager
{

    public GameData GameData = new GameData("Placeholder", Fantasty.Standard, GameSpeed.Medium, AbilityScoreType.Standard);

    private static GameDataManager _instance = null;
    private static readonly object Padlock = new object();

    public static GameDataManager Instance
    {
        get
        {
            lock (Padlock)
            {
                _instance ??= new GameDataManager();
            }
            return _instance;
        }
    }

    public GameData RegisterGameData()
    {
        GameData.CampaignName = PromptHelper.TextPrompt("Please enter the name of the campaign: ");
        FileManager.UpdatePaths(GameData.CampaignName);

        GameData.GameFantasty = PromptHelper.EnumPrompt<Fantasty>("Please enter a fantasty: ");

        GameData.GameSpeed = PromptHelper.EnumPrompt<GameSpeed>("Please enter the speed: ");

        GameData.AbilityScoreType = PromptHelper.EnumPrompt<AbilityScoreType>("Please choose the method of initial point distribution: ");

        return GameData;
    }

    public void AskNewCharacter()
    {
        switch (PromptHelper.YesNoPrompt("Would you also like to create a new player?", false))
        {
            case true:
                PlayerDataManager.Instance.RegisterPlayer();
                break;
            default:
                Console.WriteLine();
                break;
        }
    }

    public void AskNewWorld()
    {
        switch (PromptHelper.YesNoPrompt("Would you also like to create the game world?", false))
        {
            case true:
                WorldManager.Instance.RegisterWorld();
                break;
            default:
                Console.WriteLine();
                break;
        }
    }
}