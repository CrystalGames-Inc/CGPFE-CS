using CGPFE.Core.Enums;
using CGPFE.Core.Utilities;
using CGPFE.Domain.World;
using CGPFE.Domain.World.Geography;

namespace CGPFE.Management;

public class WorldManager
{
    public GameWorld World = new("Placeholder");

    private static WorldManager _instance = null;
    private static readonly object Padlock = new object();

    public static WorldManager Instance
    {
        get
        {
            lock (Padlock)
            {
                _instance ??= new WorldManager();
            }
            return _instance;
        }
    }

    public void RegisterWorld()
    {
        World.WorldName = PromptHelper.TextPrompt("Please choose a name for the world: ");
        GameDataManager.Instance.GameData.WorldName = World.WorldName;

        if (PromptHelper.YesNoPrompt("Would you also like to start creating regions? ", true))
            RegisterNewRegion();

        Console.WriteLine("World Successfully Created!");
    }

    public void RegisterNewRegion()
    {
        var name = PromptHelper.TextPrompt("Please enter a name for the region: ");

        var terrain = PromptHelper.EnumPrompt<Terrain>("Please enter a terrain type: ");

        var climate = PromptHelper.EnumPrompt<Climate>("Please enter a climate type: ");

        var r = new Region(name, terrain, climate);

        if (GameDataManager.Instance.GameData.StartingRegion == null)
        {
            GameDataManager.Instance.GameData.StartingRegion = PromptHelper.YesNoPrompt("Would you like to set this region as the starting region?", true) ? name : null;
            FileManager.SaveToFile(FileManager.GetPathForGameProperty("Settings"), GameDataManager.Instance.GameData);
        }

        World.AddRegion(r);

        if (PromptHelper.YesNoPrompt("Would you like to create another region? ", true))
            RegisterNewRegion();


    }
}