﻿namespace CGPFE.Data.Models.Item.Offense.Properties;

public class Critical(int multiplier, int minDie) {
	public int Multiplier = multiplier;
	public int MinDie = minDie;

	public Critical(int multiplier) : this(multiplier, 20) {
	}
}