using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter.Xml;
using NUnit.Framework;

namespace PlutoRover.Tests
{
    // File name intentionally wasn't changed
    [TestFixture]
    public class WhenMovingRoverFromPosition
    {
        // Pluto is a grid
        // rover will have an initial position
        // L - turn left
        // R - turn right

        [Test]
        public void ZeroZeroAndFacingNorthWhenMovingForwardThenYIsOne()
        {
            Position initialPosition = new Position(0, 0, 'N');
            char moveForwardStep = 'F'; 

            Rover rover = new Rover(initialPosition);
            rover.Move(moveForwardStep);

            Assert.AreEqual(1, rover.CurrentPosition.Y);
        }

        [Test]
        public void ZeroZeroAndFacingEastWhenMovingForwardThenXIsOne()
        {
            Position initialPosition = new Position(0, 0, 'E');
            char moveForwardStep = 'F';

            Rover rover = new Rover(initialPosition);
            rover.Move(moveForwardStep);

            Assert.AreEqual(1, rover.CurrentPosition.X);
        }

        [Test]
        public void ZeroZeroAndFacingEastWhenTurningRightThenOrientationIsSouth()
        {
            Position initialPosition = new Position(0, 0, 'E');
            char turnDirection = 'R';

            Rover rover = new Rover(initialPosition);
            rover.Turn(turnDirection);

            Assert.AreEqual('S', rover.CurrentPosition.Orientation);
        }

        [Test]
        public void ZeroZeroAndFacingEastWhenTurningLeftThenOrientationIsNorth()
        {
            Position initialPosition = new Position(0, 0, 'E');
            char turnDirection = 'L';

            Rover rover = new Rover(initialPosition);
            rover.Turn(turnDirection);

            Assert.AreEqual('N', rover.CurrentPosition.Orientation);
        }
    }

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
            if (this.position.Orientation == 'E')
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
            if (turnDirection == 'L')
            {
                this.position.Orientation = 'N';
            }
            else
            {
                this.position.Orientation = 'S';
            }
        }
    }

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
