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
            else if (this.position.Orientation == Orientation.South)
            {
                this.position.Y -= 1;
            }
            else
            {
                if (step == MoveDirection.Backward)
                {
                    this.MoveBackward();
                }
                else
                {
                    this.MoveForward();
                }
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

        private void MoveForward()
        {
            this.position.Y += 1;
        }

        private void MoveBackward()
        {
            this.position.Y -= 1;
        }
    }
}