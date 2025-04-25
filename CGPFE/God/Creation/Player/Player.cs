using System.Text.Json;
using CGPFE.Data.Constants;
using CGPFE.God.Creation.General;
using CGPFE.God.Creation.Player.Properties;

namespace CGPFE.God.Creation.Player;

public class Player {
	public PlayerInfo PlayerInfo;
	public Attributes Attributes = new Attributes();
	public Attributes AttributeModifiers = new Attributes();
	public CombatInfo CombatInfo = new CombatInfo();
	public Wallet Wallet = new Wallet();
}