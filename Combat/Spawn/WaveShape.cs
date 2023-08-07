using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GLib.Combat.Spawn
{
    public abstract class WaveShape : ScriptableObject
    {
        public abstract List<GameObject> Spawn(Transform target, List<GameObject> toSpawn);

        public GameObject GetToSpawnFormListAndIndex(List<GameObject> toSpawn, int currentSpawnIndex)
        {
            if (toSpawn.Count == 0) return null;

            return toSpawn[(currentSpawnIndex + toSpawn.Count) % toSpawn.Count + 1];
        }
        
        
        public GameObject GetRandomToSpawnFromList(List<GameObject> toSpawn)
        {
            if (toSpawn.Count == 0) return null;

            return toSpawn[Random.Range(0, toSpawn.Count)];
        }
    }
}