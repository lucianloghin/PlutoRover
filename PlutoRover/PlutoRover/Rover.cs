namespace PlutoRover
{
    public class Rover
    {
        private readonly Position position;

        public Rover(Position position)
        {
            this.position = position;
        }

        public Position CurrentPosition
        {
            get { return this.position; }
        }

        public void Move(char step)
        {
            if (this.position.Orientation == Orientation.East)
            {
                this.position.X = 1;
            }
            else
            {
                this.position.Y = 1;
            }
        }

        // not sure if we would have two different methods, will see how this evolves
        public void Turn(char turnDirection)
        {
            if (turnDirection == TurnDirection.Left)
            {
                this.position.Orientation = Orientation.North;
            }
            else
            {
                this.position.Orientation = Orientation.South;
            }
        }
    }
}