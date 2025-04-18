﻿using System.Text.Json;
using CGPFE.Data.Game.StoryModifiers;
using CGPFE.World;

namespace CGPFE.Data.Game;

public class GameData(string campaignName, int gameFantasty, int gameSpeed, int abilityScoreType) {

	public string CampaignName { get; set; } = campaignName;

	public int GameFantasty { get; set; } = gameFantasty;

	public int GameSpeed { get; set; } = gameSpeed;

	public int AbilityScoreType { get; set; } = abilityScoreType;

	public GameWorld? GameWorld;

	public void DisplayGameData() {
		Console.WriteLine($"Campaign Name: {CampaignName}");
		switch (GameFantasty) {
			case 0:
				Console.WriteLine($"Game Fantasty: {Fantasty.Low}");
				break;
			case 1:
				Console.WriteLine($"Game Fantasty: {Fantasty.Standard}");
				break;
			case 2:
				Console.WriteLine($"Game Fantasty: {Fantasty.High}");
				break;
			case 3:
				Console.WriteLine($"Game Fantasty: {Fantasty.Epic}");
				break;
		}

		switch (GameSpeed) {
			case 0:
				Console.WriteLine($"Game Speed: {StoryModifiers.GameSpeed.Slow}");
				break;
			case 1:
				Console.WriteLine($"Game Speed: {StoryModifiers.GameSpeed.Medium}");
				break;
			case 2:
				Console.WriteLine($"Game Speed: {StoryModifiers.GameSpeed.Fast}");
				break;
		}

		switch (AbilityScoreType) {
			case 0:
				Console.WriteLine($"Initial Point Distribution: {StoryModifiers.AbilityScoreType.Standard}");
				break;
			case 1:
				Console.WriteLine($"Initial Point Distribution: {StoryModifiers.AbilityScoreType.Classic}");
				break;
			case 2:
				Console.WriteLine($"Initial Point Distribution: {StoryModifiers.AbilityScoreType.Heroic}");
				break;
			case 3:
				Console.WriteLine($"Initial Point Distribution: {StoryModifiers.AbilityScoreType.Purchase}");
				break;
		}
	}

	public static GameData RegisterGameData() {
		Console.WriteLine("Please choose the campaign's name: ");
		var campaignName = Console.ReadLine();

		Console.WriteLine("Please choose a game fantasty:\nLow - 1\nStandard - 2\nHigh - 3\nEpic - 4");
		var gameFantasty = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()) - 1;
		
		Console.WriteLine("Please choose the game speed:\nSlow - 1\nMedium - 2\nFast - 3");
		var gameSpeed = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

		Console.WriteLine("Please choose the method of initial point distribution:\nStandard - 1\nClassic - 2\nHeroic - 3\nPurchase - 4");
		var abilityScoreType = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
		
		return new GameData(campaignName, gameFantasty, gameSpeed, abilityScoreType);
	}
}