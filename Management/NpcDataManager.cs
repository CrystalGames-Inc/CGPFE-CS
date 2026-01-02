using CGPFE.Core.Enums;
using CGPFE.Core.Utilities;
using CGPFE.Domain.Characters.Common;
using CGPFE.Domain.Characters.NPC;
using CGPFE.Domain.Characters.NPC.Properties;
using Attribute = CGPFE.Core.Enums.Attribute;

namespace CGPFE.Management;

public class NpcDataManager {
	private NPC Npc = new NPC();
	
	private static NpcDataManager _instance = null;
	private static readonly object Padlock = new object();

	private List<NPC> NPCs = [];
	
	public static NpcDataManager Instance {
		get {
			lock (Padlock) {
				_instance ??= new NpcDataManager();
			}
			return _instance;
		}
	}

	public void RegisterNPC() {
		Npc.Info.Name = PromptHelper.TextPrompt("Please choose the NPC's name: ");
		
		Npc.Info.Gender = PromptHelper.EnumPrompt<Gender>("Please choose the NPC's gender: ");

		Npc.Info.Type = PromptHelper.EnumPrompt<NpcType>("Please choose the NPC's type: ");
		Npc.Info.Heroic = PromptHelper.YesNoPrompt("Would you like the NPC to be Heroic?", false);
		
		RegisterAbilityScores();
	}

	private void RegisterAbilityScores() {
		List<int> abilityScores = [8, 10, 12, 13, 14, 15];

		if (PromptHelper.YesNoPrompt("Would you like to use Preset ability scores?", true)) {
			switch (Npc.Info.Type) {
				case NpcType.Arcane:
					Npc.Attributes.Strength = new AbilityScore(8);
					Npc.Attributes.Dexterity = new AbilityScore(Npc.Info.Heroic ? 12 : 14);
					Npc.Attributes.Constitution = new AbilityScore(Npc.Info.Heroic ? 10 : 12);
					Npc.Attributes.Intelligence = new AbilityScore(Npc.Info.Heroic ? 13 : 15);
					Npc.Attributes.Wisdom = new AbilityScore(Npc.Info.Heroic ? 9 : 10);
					Npc.Attributes.Constitution = new AbilityScore(Npc.Info.Heroic ? 11 : 13);
					break;
				case NpcType.Divine:
					Npc.Attributes.Strength = new AbilityScore(Npc.Info.Heroic ? 10 : 12);
					Npc.Attributes.Dexterity = new AbilityScore (8);
					Npc.Attributes.Constitution = new AbilityScore(Npc.Info.Heroic ? 12 : 14);
					Npc.Attributes.Intelligence = new AbilityScore(Npc.Info.Heroic ? 9 : 10);
					Npc.Attributes.Wisdom = new AbilityScore(Npc.Info.Heroic ? 13 : 15);
					Npc.Attributes.Constitution = new AbilityScore(Npc.Info.Heroic ? 11 : 13);
					break;
				case NpcType.Melee:
					Npc.Attributes.Strength = new AbilityScore(Npc.Info.Heroic ? 13 : 15);
					Npc.Attributes.Dexterity = new AbilityScore(Npc.Info.Heroic ? 11 : 13);
					Npc.Attributes.Constitution = new AbilityScore(Npc.Info.Heroic ? 12 : 14);
					Npc.Attributes.Intelligence = new AbilityScore(Npc.Info.Heroic ? 9 : 10);
					Npc.Attributes.Wisdom = new AbilityScore(Npc.Info.Heroic ? 10 : 12);
					Npc.Attributes.Constitution = new AbilityScore(8);
					break;
				case NpcType.Ranged:
					Npc.Attributes.Strength = new AbilityScore(Npc.Info.Heroic ? 11 : 13);
					Npc.Attributes.Dexterity = new AbilityScore(Npc.Info.Heroic ? 13 : 15);
					Npc.Attributes.Constitution = new AbilityScore(Npc.Info.Heroic ? 12 : 14);
					Npc.Attributes.Intelligence = new AbilityScore(Npc.Info.Heroic ? 10 : 12);
					Npc.Attributes.Wisdom =		new AbilityScore(Npc.Info.Heroic ? 9 : 10);
					Npc.Attributes.Constitution = new AbilityScore(8);
					break;
				case NpcType.Skill:
					Npc.Attributes.Strength = new AbilityScore(Npc.Info.Heroic ? 10 : 12);
					Npc.Attributes.Dexterity = new AbilityScore(Npc.Info.Heroic ? 12 : 14);
					Npc.Attributes.Constitution = new AbilityScore(Npc.Info.Heroic ? 11 : 13);
					Npc.Attributes.Intelligence = new AbilityScore(Npc.Info.Heroic ? 13 : 15);
					Npc.Attributes.Wisdom = new AbilityScore(8);
					Npc.Attributes.Constitution = new AbilityScore(Npc.Info.Heroic ? 9 : 10);
					break;
			}
			
			return;
		}
		
		Attribute[] attributeOrder = [
			Attribute.Strength,
			Attribute.Dexterity,
			Attribute.Constitution,
			Attribute.Intelligence,
			Attribute.Wisdom,
			Attribute.Charisma
		];

		foreach (var attribute in attributeOrder)
		{
			Console.WriteLine("Available scores:");
			for (int i = 0; i < abilityScores.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {abilityScores[i]}");
			}

			int index;
			while (true)
			{
				Console.Write($"\nSelect the index (1-{abilityScores.Count}) of the score to assign to {attribute}: ");
				if (int.TryParse(Console.ReadLine(), out index) &&
				    index >= 1 &&
				    index <= abilityScores.Count)
				{
					break;
				}
				Console.WriteLine("Invalid index. Please try again.");
			}

			int chosenScore = abilityScores[index - 1];
			abilityScores.RemoveAt(index - 1);

			// Assign the chosen score to the correct property
			switch (attribute)
			{
				case Attribute.Strength:
					Npc.Attributes.Strength = new AbilityScore(chosenScore);
				break;
				case Attribute.Dexterity:
					Npc.Attributes.Dexterity = new AbilityScore(chosenScore);
				break;
				case Attribute.Constitution:
					Npc.Attributes.Constitution = new AbilityScore(chosenScore);
				break;
				case Attribute.Intelligence:
					Npc.Attributes.Intelligence = new AbilityScore(chosenScore);
				break;
				case Attribute.Wisdom:
					Npc.Attributes.Wisdom = new AbilityScore(chosenScore);
				break;
				case Attribute.Charisma:
					Npc.Attributes.Charisma = new AbilityScore(chosenScore);
				break;
			}

			Console.WriteLine($"Assigned {chosenScore} to {attribute}");
		}
		
	}
}