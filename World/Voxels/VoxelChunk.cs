using UnityEngine;

namespace GLib.World.Voxels
{
    public class VoxelChunk<T>
    {
        public T[][][] data;

        public VoxelChunk(Vector3Int size)
        {
            data = new T[size.x][][];

            for (int i = 0; i < size.x; i++)
            {
                data[i] = new T[size.y][];
                for (int j = 0; j < size.y; j++)
                {
                    data[i][j] = new T[size.z];
                }
            }
        }
    }
}