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

        // still could use some better naming on below methods
        private bool XShouldChange()
        {
            return this.position.Orientation == Orientation.East ||
                   this.position.Orientation == Orientation.West;
        }

        private void MoveX(char direction)
        {
            if (this.XShouldAdvance(direction))
            {
                this.position.X += 1;
            }
            else
            {
                this.position.X -= 1;
            }
        }

        private void MoveY(char direction)
        {
            if (this.YShouldAdvance(direction))
            {
                this.position.Y += 1;
            }
            else
            {
                this.position.Y -= 1;
            }
        }
        
        private bool XShouldAdvance(char direction)
        {
            return direction == MoveDirection.Forward &&
                   this.CurrentPosition.Orientation == Orientation.East ||
                   direction == MoveDirection.Backward &&
                   this.CurrentPosition.Orientation == Orientation.West;
        }

        private bool YShouldAdvance(char direction)
        {
            return direction == MoveDirection.Forward &&
                   this.CurrentPosition.Orientation == Orientation.North ||
                   direction == MoveDirection.Backward &&
                   this.CurrentPosition.Orientation == Orientation.South;
        }
    }
}