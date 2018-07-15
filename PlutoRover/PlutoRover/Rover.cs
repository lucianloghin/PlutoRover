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
            if (this.XShouldChange())
            {
                this.MoveX(step);
            }
            else
            {
                this.MoveY(step);
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

        private bool XShouldChange()
        {
            return this.position.Orientation == Orientation.East ||
                   this.position.Orientation == Orientation.West;
        }

        private void MoveY(char direction)
        {
            // extract condition logic
            if (direction == MoveDirection.Forward &&
                this.CurrentPosition.Orientation == Orientation.North ||
                direction == MoveDirection.Backward &&
                this.CurrentPosition.Orientation == Orientation.South)
            {
                this.position.Y += 1;
            }
            else
            {
                this.position.Y -= 1;
            }
        }

        private void MoveX(char direction)
        {
            if (direction == MoveDirection.Forward &&
                this.CurrentPosition.Orientation == Orientation.East)
            {
                this.position.X += 1;
            }
            else
            {
                this.position.X -= 1;
            }
        }
    }
}