# ServerTips

A plugin that will print automated messages within a random time range to each players console.

# Installation

**[Smod2](https://github.com/Grover-c13/Smod2) must be installed for this to work.**

Place the "ServerTips.dll" file in your sm_plugins folder.

# Features

Put this config line anywhere in your gameplay_config.txt file with the proper formatting. Click [here](https://github.com/Cyanox62/ServerTips/wiki/Valid-Colors) for all available colors.

| Config        | Value Type | Default | Description |
| :-------------: | :---------: | :---------: |:------ |
| servertips | List | | Sets the messages to be printed to each users console. They are in the format `[color]:[message][min_time]:[max_time]` and are seperated by commas. The times are calculated in seconds and represent the amount of time into the round. Example config: `yellow:Join our discord server!:10:30,gray:Hope you enjoy the server!:50:100`
