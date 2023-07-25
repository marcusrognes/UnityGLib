using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;

public class NetworkEventsBehaviour : NetworkBehaviour
{
    public UnityEvent onStartClient;
    public UnityEvent onStartServer;
    public UnityEvent onStartOwnerClient;
    void Start()
    {
        if(IsClient) onStartClient?.Invoke();
        if(IsClient && IsOwner) onStartOwnerClient?.Invoke();
        if(IsServer) onStartServer?.Invoke();
    }
}
