using BepInEx;
using HarmonyLib;
using RoundsMenu.Classes;
using RoundsMenu.Menu;
using RoundsMenu.Mods;
using System.IO;
using UnityEngine;

namespace RoundsMenu
{
    [BepInPlugin(pluginGUID, pluginName, pluginVersion)]
    public class MyMod : BaseUnityPlugin
    {
        public const string pluginGUID = "com.dragon.roundshacks";
        public const string pluginName = "Rounds Hacks";
        public const string pluginVersion = "0.1";

        private AssetBundle uiBundle;

        public void Awake()
        {
            Harmony harmony = new(pluginGUID);

            harmony.PatchAll();

            uiBundle = AssetBundle.LoadFromFile(Path.Combine(Paths.PluginPath, "RoundsMod/Assets/UI.bundle"));
        }

        public void Start()
        {
            MainModMenuHandler mMMHandler = new();

            mMMHandler.AddMenu(uiBundle);
        }
    }
}
