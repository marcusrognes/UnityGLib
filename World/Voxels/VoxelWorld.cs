namespace GLib.World.Voxels
{
    public class VoxelWorld<T>
    {
        public float voxelSize = 1f;
        public int chunkSize = 256;
        public int chunkHeight = 512;

        public InfiniteGrid2D<VoxelChunk<T>> grid = new InfiniteGrid2D<VoxelChunk<T>>();
        
        
        
        
    }
}