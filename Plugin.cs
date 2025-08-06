using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using System;
using System.Runtime.InteropServices;

namespace AimLabUnlocker;

[BepInPlugin("de.unknowntrojan.aimlabunlocker", "AimLab Unlocker", "1.0.0")]
public class Plugin : BasePlugin
{
    internal static new ManualLogSource Log;


    [DllImport("user32.dll")]
    public static extern int MessageBoxA(IntPtr hWnd, String text, String caption, uint type);

    public override void Load()
    {
        // Plugin startup logic
        Log = base.Log;

        Harmony harmony = new(MyPluginInfo.PLUGIN_GUID);

        try
        {
            harmony.PatchAll();
            Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        }
        catch (Exception e)
        {
            Log.LogError(e.ToString());
            MessageBoxA(IntPtr.Zero, "Unable to patch the game:\n" + e.ToString(), "AimLabSkins", 0);
        }
    }
}
