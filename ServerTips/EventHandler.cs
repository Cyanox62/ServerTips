using Smod2;
using Smod2.EventHandlers;
using Smod2.Events;
using System.Threading;

namespace ServerTips
{
	class EventHandler : IEventHandlerRoundStart, IEventHandlerRoundEnd
	{
		private Plugin plugin;

		public EventHandler(Plugin plugin)
		{
			this.plugin = plugin;
		}

		public void OnRoundStart(RoundStartEvent ev)
		{
			ServerTips.roundStarted = true;
			Thread TipHandler = new Thread(new ThreadStart(() => new TipHandler(plugin, plugin.GetConfigString("servertips"))));
			TipHandler.Start();
		}

		public void OnRoundEnd(RoundEndEvent ev)
		{
			ServerTips.roundStarted = false;
		}
	}
}
