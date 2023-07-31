using System.Collections.Generic;
using UnityEngine;

namespace GLib.World.Voxels
{
    public class InfiniteGrid2D<T>
    {
        public Dictionary<string, T> data = new Dictionary<string, T>();

        public T Get(Vector2Int position)
        {
            return data[position.ToString()];
        }

        public void Set(Vector2Int position, T d)
        {
            data.Add(position.ToString(), d);
        }
    }
}