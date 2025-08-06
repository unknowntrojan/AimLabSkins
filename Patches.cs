using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using AimLab.Utility;
using AimLabUtilities;
using AimLab.Models.Economy;

namespace AimLabUnlocker
{
    [HarmonyPatch(typeof(IdentityService), "IsUserSubscribed")]
    internal static class SubPatch
    {
        static bool Prefix(ref bool __result)
        {
            __result = true;
            return false;
        }
    }

    [HarmonyPatch(typeof(CosmeticSettingsUtility), "HasSkin")]
    internal static class HSPatch
    {
        static bool Prefix(ref SkinOwnedResult __result)
        {
            __result = SkinOwnedResult.Owned;
            return false;
        }
    }

    [HarmonyPatch(typeof(CosmeticSettingsUtility), "IsOwnedItem", new Type[] {typeof(string)})]
    internal static class IOI0Patch
    {
        static bool Prefix(ref SkinOwnedResult __result)
        {
            __result = SkinOwnedResult.Owned;
            return false;
        }
    }

    [HarmonyPatch(typeof(CosmeticSettingsUtility), "IsOwnedItem", new Type[] { typeof(CatalogItem), typeof(bool) })]
    internal static class IOI1Patch
    {
        static bool Prefix(ref SkinOwnedResult __result)
        {
            __result = SkinOwnedResult.Owned;
            return false;
        }
    }

    [HarmonyPatch(typeof(CosmeticSettingsUtility), "IsOwnedSkin")]
    internal static class IOSPatch
    {
        static bool Prefix(ref SkinOwnedResult __result)
        {
            __result = SkinOwnedResult.Owned;
            return false;
        }
    }

    [HarmonyPatch(typeof(CosmeticSettingsUtility), "OwnsArmSkin")]
    internal static class OASPatch
    {
        static bool Prefix(ref SkinOwnedResult __result)
        {
            __result = SkinOwnedResult.Owned;
            return false;
        }
    }

    [HarmonyPatch(typeof(CosmeticSettingsUtility), "OwnsWeaponSkin")]
    internal static class OWSPatch
    {
        static bool Prefix(ref SkinOwnedResult __result)
        {
            __result = SkinOwnedResult.Owned;
            return false;
        }
    }
}
