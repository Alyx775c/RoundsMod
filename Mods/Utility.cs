using Photon.Pun;

namespace RoundsMod.Mods
{
    internal class Utility
    {
        public static void Disconnect ()
        {
            PhotonNetwork.Disconnect();
        }
    }
}
