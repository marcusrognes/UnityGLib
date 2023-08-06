using UnityEngine;

namespace GLib.AI.GOAP
{
    public class WorldBehaviour : MonoBehaviour
    {
        public World world;

        private static WorldBehaviour self;

        void Start()
        {
            self = this;
        }

        public static WorldBehaviour GetWorldState()
        {
            return self;
        }
    }
}
