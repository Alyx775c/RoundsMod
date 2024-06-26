using HarmonyLib;

namespace RoundsMod.Patches
{
    [HarmonyPatch(typeof(GunAmmo))]
    public static class GunAmmoPatches
    {
        [HarmonyPrefix]
        [HarmonyPatch("ReloadTime")]
        public static bool PrefixReloadTime(ref float __result)
        {
            __result = -0.1f;
            return false;
        }
    }
}
