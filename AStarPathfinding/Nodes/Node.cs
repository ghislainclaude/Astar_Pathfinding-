namespace AStarPathfinding.Nodes
{
    public class Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsObstacle { get; set; }
        public int G { get; set; } // Cost from start node to this node
        public int H { get; set; } // Estimated cost from this node to the end node (heuristic)
        public int F => G + H; // Total cost (F = G + H)
        public Node(int x, int y)
        {
            X = x;
            Y = y;
            IsObstacle = false;
        }
    }
}
