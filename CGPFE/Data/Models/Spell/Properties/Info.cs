﻿namespace CGPFE.Data.Models.Spell.Properties;

public abstract class Info(string name, string school, string description) {
	public string Name = name;
	public string School = school;
	public string Description = description;
}