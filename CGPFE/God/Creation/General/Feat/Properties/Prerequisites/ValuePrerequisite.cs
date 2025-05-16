using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Properties.Prerequisites;

public class ValuePrerequisite(string key, int value) : IPrerequisite {
	private string Key { get; } = key;
	private int Value { get; } = value;
	public bool IsSatisfiedBy(Player.Player player) {
		var pValue = player.GetValueForKey(Key);

		return pValue >= Value;
	}
}