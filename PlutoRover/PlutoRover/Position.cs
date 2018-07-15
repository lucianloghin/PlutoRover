namespace PlutoRover
{
    public class Position
    {
        public Position(int x, int y, char orientation)
        {
            this.X = x;
            this.Y = y;
            this.Orientation = orientation;
        }

        public int Y { get; set; }
        public int X { get; set; }
        public char Orientation { get; set; }
    }
}