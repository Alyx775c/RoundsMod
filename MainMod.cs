using BepInEx;
using HarmonyLib;
using UnityEngine;

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
            var harmony = new Harmony(pluginGUID);

            harmony.PatchAll();

            Logger.LogInfo("Patches applied.");
        }

        void OnEnable()
        {
            GameObject burstObject = GameObject.Find("Burst(Clone)");
            if (burstObject != null)
            {
                Gun gunComponent = burstObject.GetComponent<Gun>();
                if (gunComponent != null)
                {}
                else
                {
                    Logger.LogInfo("Couldn't find Gun from Burst(Clone), trying again");
                }
            }
        }

    }
}
