using System;
using System.Collections.Generic;
using UnityEngine;

namespace GLib.Combat.Spawn
{
    public class WaveSpawnerBehaviour : MonoBehaviour
    {
        private List<GameObject> aliveEnemies = new List<GameObject>();
        public List<Wave> waves = new List<Wave>();
        private int currentWaveIndex = 0;

        private Wave currentWave;

        // Start is called before the first frame update
        void Start()
        {
            currentWave = waves[currentWaveIndex];
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}