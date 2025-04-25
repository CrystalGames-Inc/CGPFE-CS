using System.Text.Json;
using CGPFE.Data.Constants;
using CGPFE.God.Creation.General;
using CGPFE.God.Creation.Player.Properties;

namespace CGPFE.God.Creation.Player;

public class Player {
	public PlayerInfo PlayerInfo = new();
	public Attributes Attributes = new();
	public Attributes AttributeModifiers = new();
	public CombatInfo CombatInfo = new();
	public Wallet Wallet = new();
}