using UnityEngine;

namespace GLib.AI.FSM
{
    public interface IFSMState

    {
    void Update(FSM fsm, GameObject gameObject);
    }
}
