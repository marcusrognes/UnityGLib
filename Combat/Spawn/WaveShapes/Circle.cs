using System.Collections.Generic;
using UnityEngine;

namespace GLib.Combat.Spawn.WaveShapes
{
    [CreateAssetMenu(fileName = "new Circle Shape", menuName = "GLIB/Combat/Spawn/Cirlce Shape")]
    public class Circle : WaveShape
    {
        public float distance = 100f;
        public int spawnCount = 10;
        public bool randomSelection = false;
        
        public override List<GameObject> Spawn(Transform target, List<GameObject> toSpawn)
        {
            var spawned =  new List<GameObject>();
            
            var x0 = target.position.x;
            var y0 = target.position.y;
            
            for(var i = 0; i < spawnCount; i++) {
                var x = x0 + distance * Mathf.Cos(2 * Mathf.PI * i / spawnCount);
                var y = y0 + distance * Mathf.Sin(2 * Mathf.PI * i / spawnCount);

                if (randomSelection)
                    spawned.Add(GetRandomToSpawnFromList(toSpawn));
                else
                    spawned.Add(GetToSpawnFormListAndIndex(toSpawn, i));
            }
            

            return spawned;
        }
    }
}