using System;
using Smod2;
using Smod2.API;
using System.Collections.Generic;
using System.Threading;

namespace ServerTips
{
	class TipHandler
	{
		public TipHandler(Plugin plugin, string config)
		{
			Random rand = new Random();
			Dictionary<int, string> timerDict = new Dictionary<int, string>();

			foreach (string timer in config.Split(','))
			{
				string[] str = timer.Split(':');
				if (str.Length > 0)
					timerDict.Add(rand.Next(Int32.Parse(str[2]), Int32.Parse(str[3])), str[0] + ":" + str[1]);
			}

			while (ServerTips.roundStarted)
			{
				foreach (KeyValuePair<int, string> entry in timerDict)
				{
					if (plugin.pluginManager.Server.Round.Duration == entry.Key)
					{
						foreach (Player player in plugin.pluginManager.Server.GetPlayers())
						{
							string[] msg = entry.Value.Split(':');
							player.SendConsoleMessage(msg[1], msg[0]);
						}
					}
				}
				Thread.Sleep(1000);
			}
		}
	}
}
