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

        public void Update()
        {
            CharacterStatModifiers playerStatModifiers = GameObject.Find("Player(Clone)").GetComponent<CharacterStatModifiers>();

            if (Input.GetKeyDown(KeyCode.P))
            {
                playerStatModifiers.jump = 1;
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                playerStatModifiers.jump = 2;
            }

            Gravity gravity = GameObject.Find("Player(Clone)").GetComponent<Gravity>();

            if (Input.GetKeyDown(KeyCode.L))
            {
                gravity.enabled = false;
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                gravity.enabled = true;
            }

            Gun gun = GameObject.Find("WeaponBase(Clone)").GetComponent<Gun>();

            if (Input.GetKeyDown(KeyCode.Q))
            {
                gun.attackSpeed = 0f;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                gun.attackSpeed = 0.3f;
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                gun.damage = 50f;
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                gun.damage = 5f;
            }

            if (Input.GetKeyDown(KeyCode.Insert))
            {
                gun.attackSpeed = 0.2f;
                gun.bursts = 5;
                gun.damage = 2;
                gun.gravity = 0;
                gun.spread = 0;
            }

            Gun sprayGun = GameObject.Find("SPRAY(Clone)").GetComponent<Gun>();

            sprayGun.attackSpeed = 0.0055f;
            // spray with barrage 
            sprayGun.numberOfProjectiles = 10;
            sprayGun.spread = 0.015f;

        }

    }

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
