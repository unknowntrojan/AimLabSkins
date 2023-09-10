using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using AimLab;
using AimLabUtilities;
using System.Reflection;
using System.Linq;

namespace AimLabSkins
{
    public static class Patches
    {
        [HarmonyPatch]
        internal static class SkinPatch
        {
            static IEnumerable<MethodBase> TargetMethods()
            {
                return AccessTools.GetTypesFromAssembly(Assembly.Load(Assembly.GetAssembly(typeof(Main)).GetReferencedAssemblies().Where(asm => asm.Name.Contains("Assembly-CSharp")).First()))
                    .Where(type => type.Name.Contains("CosmeticSettingsUtility"))
                    .SelectMany(type => type.GetMethods())
                    .Where(meth => meth.ReturnType == typeof(SkinOwnedResult)).Select(x => { Main.LogXD.LogMessage("Patching skin ownership check from " + x.Name);  return x;  }).Cast<MethodBase>();
            }

            public static bool Prefix(ref SkinOwnedResult __result)
            {
                __result = SkinOwnedResult.Owned;
                return false;
            }
        }
    }
}
