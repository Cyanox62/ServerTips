using Smod2;
using Smod2.Attributes;

namespace ServerTips
{
	[PluginDetails(
	author = "Cyanox",
	name = "ServerTips",
	description = "Displays custom text within a time range in each players console.",
	id = "cyan.server.tips",
	version = "0.1",
	SmodMajor = 3,
	SmodMinor = 0,
	SmodRevision = 0
	)]
	public class ServerTips : Plugin
	{
		public static bool roundStarted = false;

		public override void OnEnable() {}

		public override void OnDisable() {}

		public override void Register()
		{
			this.AddEventHandlers(new EventHandler(this));
			this.AddConfig(new Smod2.Config.ConfigSetting("servertips", "", Smod2.Config.SettingType.STRING, true, ""));
		}
	}
}
