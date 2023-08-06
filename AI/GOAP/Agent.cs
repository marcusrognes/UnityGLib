using UnityEngine;

namespace GLib.AI.GOAP
{
    public class Agent : MonoBehaviour
    {
        private FSM.FSM stateMachine;
        
        private FSM.FSM.FSMState idleState;
        private FSM.FSM.FSMState moveToState;
        private FSM.FSM.FSMState performActionState;

        private World world;

        void Start()
        {
            stateMachine = new FSM.FSM();
            world = WorldBehaviour.GetWorldState().world;
            SetupIdleState();
            SetupMoveToState();
            SetupPerformActionState();
        }

        // Update is called once per frame
        void Update()
        {
            stateMachine.Update(gameObject);
        }

        private void SetupIdleState()
        {
            idleState = (fsm, gO) => { Debug.Log("Starting idle plan"); };
        }

        private void SetupMoveToState()
        {
            moveToState = (fsm, gO) => { Debug.Log("Starting Move To plan"); };
        }

        private void SetupPerformActionState()
        {
            performActionState = (fsm, gO) => { Debug.Log("Starting Perform Action plan"); };
        }
    }
}