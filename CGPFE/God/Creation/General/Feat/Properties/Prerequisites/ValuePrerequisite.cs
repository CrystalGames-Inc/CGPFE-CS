using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Properties.Prerequisites;

public class ValuePrerequisite : IPrerequisite {
	private string Key { get; }
	private int Value { get; }

	private string Operator { get; } = ">=";

	public ValuePrerequisite(string key, int value) {
		Key = key;
		Value = value;
	}

	public ValuePrerequisite(string key, int value, string @operator) {
		Key = key;
		Value = value;
		Operator = @operator;
	}
	
	public bool IsSatisfiedBy(Player.Player player) {
		var pValue = player.GetValueForKey(Key);

		return Operator switch {
			"==" => pValue == Value,
			">=" => pValue >= Value,
			"<=" => pValue <= Value,
			">" => pValue > Value,
			"<" => pValue < Value,
			_ => throw new InvalidOperationException($"Invalid operator: {Operator} ")
		};
	}
}