using Photon.Pun;
using RoundsMenu.Classes;
using UnityEngine;
using System;

namespace RoundsMenu.Mods
{
    class OP
    {
        public static void FastFire(ButtonInfo buttonInfo)
        {
            Gun gun;
            gun = GameObject.Find("WeaponHandler(Clone)").GetComponent<Gun>();

            if (buttonInfo.enabled)
            {
                gun.reloadTime = .05f;
            }
            else
            {
                gun.reloadTime = .2f;
            }
        }
    }
}
