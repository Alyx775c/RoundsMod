using BepInEx;
using HarmonyLib;

namespace RoundsMod
{
    [BepInPlugin(pluginGUID, pluginName, pluginVersion)]
    public class MyMod : BaseUnityPlugin
    {
        public const string pluginGUID = "com.dragon.roundshacks";
        public const string pluginName = "Rounds Hacks";
        public const string pluginVersion = "0.1";

        public void Awake()
        {
            Harmony harmony = new(pluginGUID);

            harmony.PatchAll();

            Logger.LogInfo("Patches applied.");
        }
    }
}
