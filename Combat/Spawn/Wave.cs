using System.Collections.Generic;
using UnityEngine;

namespace GLib.Combat.Spawn
{
    [CreateAssetMenu(fileName = "Wave", menuName = "GLIB/Combat/Spawn/Wave")]
    public class Wave : ScriptableObject
    {
        public int repeats = 1;
        public float waveMaxDuration = 20f;
        public float waveMinDuration = 5f;
        public List<Wave> waves = new List<Wave>();
        [SerializeField]
        public WaveShape shape;
        public List<GameObject> enemyPrefabs = new List<GameObject>();
        private int currentSubWaveIndex = 0;

        public void OnWaveStart()
        {
        }

        public void OnWaveUpdate()
        {
        }

        public void OnWaveEnd()
        {
        }
    }
}