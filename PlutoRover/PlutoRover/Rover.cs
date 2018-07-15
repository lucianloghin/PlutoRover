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
                this.MoveX();
            }
            else if (this.YShouldChange())
            {
                this.MoveYBackward();
            }
            else
            {
                if (step == MoveDirection.Backward)
                {
                    this.MoveYBackward();
                }
                else
                {
                    this.MoveYForward();
                }
            }
        }

        private void MoveX()
        {
            if (this.CurrentPosition.Orientation == Orientation.East)
            {
                this.position.X += 1;
            }
            else
            {
                this.position.X -= 1;
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

        // TODO : find better names
        private bool YShouldChange()
        {
            return this.position.Orientation == Orientation.South;
        }

        private bool XShouldChange()
        {
            return this.position.Orientation == Orientation.East ||
                   this.position.Orientation == Orientation.West;
        }

        private void MoveYForward()
        {
            this.position.Y += 1;
        }

        private void MoveYBackward()
        {
            this.position.Y -= 1;
        }
    }
}