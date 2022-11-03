using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using AimLabUtilities;

namespace AimLabSkins
{
    public static class Patches
    {
        [HarmonyPatch(typeof(CosmeticSettingsUtility), "IsOwnedSkin")]
        internal static class SkinPatch
        {
            public static bool Prefix(ref SkinOwnedResult __result)
            {
                __result = SkinOwnedResult.Owned;
                return false;
            }
        }

        [HarmonyPatch(typeof(CosmeticSettingsUtility), "OwnsArmSkin")]
        internal static class ArmPatch
        {
            public static bool Prefix(ref SkinOwnedResult __result)
            {
                __result = SkinOwnedResult.Owned;
                return false;
            }
        }

        [HarmonyPatch(typeof(CosmeticSettingsUtility), "OwnsWeaponSkin")]
        internal static class WeaponPatch
        {
            public static bool Prefix(ref SkinOwnedResult __result)
            {
                __result = SkinOwnedResult.Owned;
                return false;
            }
        }

        [HarmonyPatch(typeof(CosmeticSettingsUtility), "IsEquipableSkin")]
        internal static class EquipPatch
        {
            public static bool Prefix(ref bool __result)
            {
                __result = true;
                return false;
            }
        }
    }
}
