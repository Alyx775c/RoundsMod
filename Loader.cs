using UnityEngine;

namespace RoundsMod
{
    class Loader
    {
        public void Load()
        {
            GameObject mod = new GameObject();
            mod.AddComponent<MyMod>();
            GameObject.DontDestroyOnLoad(mod);
        }
    }
}
