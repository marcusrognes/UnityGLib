using ParrelSync;
using Unity.Netcode;
using UnityEngine;

namespace GLib.Network
{
    [RequireComponent(typeof(NetworkManager))]
    public class ParrelSyncHelper : MonoBehaviour
    {
        void Start()
        {
            var networkManager = GetComponent<NetworkManager>();
            if (ClonesManager.IsClone())
            {
                networkManager.StartClient();
            }
            else
            {
                networkManager.StartHost();
            }
        }
    }
}