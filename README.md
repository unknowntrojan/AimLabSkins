# AimLab Unlocker

**Disclaimer:** Use this at your own risk. This is literally just a BepinEx plugin I slammed together in 5 minutes because I refuse to pay for content that's already on my hard drive.

Unlocks AimLab Plus Subscription and unlocks all skins.
Go to the skin shop and click on any you like, you can just press equip.

Don't pay for skins, kids

## Installation

Grab the release from Releases. I will not be recompiling this very often, so if it doesn't work, try compiling it yourself.

## Compiling

1. Install BepinEx for your system from [BepInBuilds](https://builds.bepinex.dev/projects/bepinex_be). Follow the installation instructions. Make sure you select IL2CPP, not Mono. Copy the files into your game folder so that there's a folder "BepInEx" next to "AimLab_tb.exe".
1. Launch the game at least once.
1. Edit **"BepInEx/config/BepinEx.cfg"** to disable the console window for log output. This is really only for developers and clutters up your desktop. Find the entry **"Enabled"** under **"Logging.Console"** and set it to **false**.
1. Open the project, fix the dependency paths if necessary, and build it. (The paths in the .csproj are absolute to where my game is. Set it to wherever your game is)
1. Copy the resulting binary (**"AimLabUnlocker.dll"**) into the BepinEx **plugins** folder (this folder will be created after you first launch the game post-install).
1. The game will now blindly assume that you own every skin.
