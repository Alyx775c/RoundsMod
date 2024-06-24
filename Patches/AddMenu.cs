using HarmonyLib;
using RoundsMod.Menu;

namespace RoundsMod.Patches
{
    [HarmonyPatch(typeof(Map))]
    public static class AddMenuPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch("Start")]
        public static void Patch()
        {
            MainModMenuHandler handler = new MainModMenuHandler();

            handler.AddMenu();
        }
    }
}
