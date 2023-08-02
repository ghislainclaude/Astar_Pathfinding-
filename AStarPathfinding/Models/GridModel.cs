using AStarPathfinding.Nodes;

namespace AStarPathfinding.Models
{
    public class GridModel
    {
        public Node[,] Nodes { get; }
        public int Width { get; }
        public int Height { get; }
        public Node StartNode { get; set; }
        public Node EndNode { get; set; }
        public GridModel(int width, int height)
        {
            Width = width;
            Height = height;
            Nodes = new Node[Width, Height];

            InitializeNodes();
        }
        private void InitializeNodes()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Nodes[x, y] = new Node(x, y);
                }
            }
        }
    }

}
