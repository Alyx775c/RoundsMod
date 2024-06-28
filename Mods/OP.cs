using Photon.Pun;
using RoundsMenu.Classes;
using UnityEngine;

namespace RoundsMenu.Mods
{
    class OP
    {
        public static void FastFire(ButtonInfo buttonInfo)
        {
            Gun gun = GameObject.Find("Player(Clone)").GetComponent<Gun>();

            if (!buttonInfo.enabled)
            {
                gun.reloadTime = .1f;
            } else
            {
                gun.reloadTime = .3f;
            }

            buttonInfo.enabled = !buttonInfo.enabled;
        }
    }
}
