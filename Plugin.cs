using BepInEx;
using UnityEngine;
using TMPro;

namespace Superburst
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        void Update()
        {
            Gun component = GameObject.Find("Burst(Clone)").GetComponent<Gun>();
            component.bursts = 12;
            component.spread = 0.05f;
            component.damage = 0.9f;
            TextMeshProUGUI component2 = GameObject.Find("Burst(Clone)/CardBase(Clone)/Canvas/Front/Text_Name").GetComponent<TextMeshProUGUI>();
            if (component2.text == "BURST")
            {
                component2.text = "SUPER BURST";
            }
            Object.Destroy(GameObject.Find("Burst(Clone)/CardBase(Clone)/Canvas/Front/Grid/StatObject(Clone)"), 0f);
            TextMeshProUGUI component3 = GameObject.Find("Burst(Clone)/CardBase(Clone)/Canvas/Front/Grid/EffectText").GetComponent<TextMeshProUGUI>();
            if (component3.text == "Multiple bullets are fired in a sequence")
            {
                component3.text = "burst go phphphphphphphphphphphph";
            }
        }
    }
}
