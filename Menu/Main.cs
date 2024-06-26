using UnityEngine;

namespace RoundsMod.Menu
{
    public class MainModMenuHandler
    {
        public void AddMenu(AssetBundle uiAssetBundle)
        {
            GameObject Menu = uiAssetBundle.LoadAsset<GameObject>("ui");
            Object.Instantiate(Menu);
        }
    }
}
