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
            // don't have enough scenarios to refactor this, functionality is incomplete
            // most probably this should be rewritten after having more unit tests
            if (this.XShouldChange())
            {
                this.MoveXForward();
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

        private void MoveXForward()
        {
            this.position.X += 1;
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
            return this.position.Orientation == Orientation.East;
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