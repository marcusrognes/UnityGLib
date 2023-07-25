using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


namespace GLib.AI.Navigation
{
    [RequireComponent(typeof(NavMeshAgent), typeof(Animator))]
    public class RootMotionNavMeshAgent : MonoBehaviour
    {
        public bool animatorUpdateRotation;
        private Animator animator;
        private NavMeshAgent agent;

        void Awake()
        {
            animator = GetComponent<Animator>();
            agent = GetComponent<NavMeshAgent>();
            agent.updatePosition = false;
            agent.updateRotation = !animatorUpdateRotation;
        }

        void OnAnimatorMove()
        {
            Vector3 rootPosition = animator.rootPosition;
            rootPosition.y = agent.nextPosition.y;
            transform.position = rootPosition;
            agent.nextPosition = rootPosition;

            if (animatorUpdateRotation)
            {
                transform.rotation = animator.rootRotation;
            }
        }
    }
}