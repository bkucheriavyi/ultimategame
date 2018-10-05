namespace core.Model
{
    public class Point
    {
        public Point() { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override int GetHashCode()
        {
            int hash = 76;
            hash = (hash * 12) + X.GetHashCode();
            hash = (hash * 12) + Y.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            return Equals(this, obj as Point);
        }

        public bool Equals(Point a, Point b){
            return a != null && b != null && a.X == b.X && a.Y == b.Y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}