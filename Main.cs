using BepInEx;
using BepInEx.Unity.IL2CPP;
using UnityEngine;
using HarmonyLib;
using System;
using System.Runtime.InteropServices;
using BepInEx.Logging;

namespace AimLabSkins
{
    [BepInPlugin("de.unknowntrojan.aimlab", "aimlab", "1.0.0")]
    public class Main : BasePlugin
    {
        public static ManualLogSource LogXD { get; set; }

        [DllImport("user32.dll")]
        public static extern int MessageBoxA(IntPtr hWnd, String text, String caption, uint type);

        public override void Load()
        {
            LogXD = this.Log;
            Harmony harmony = new Harmony("de.unknowntrojan.aimlab");

            try
            {
                harmony.PatchAll();
            } catch (Exception e)
            {
                Main.LogXD.LogError(e.ToString());
                MessageBoxA(IntPtr.Zero, "Unable to patch the game:\n" + e.ToString(), "AimLabSkins", 0);
            }
        }
    }
}
