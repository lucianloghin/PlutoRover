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

        [Test]
        public void ZeroZeroAndFacingNorthWhenMovingForwardThenYIsOne()
        {
            Position initialPosition = new Position(0, 0, Orientation.North);
            
            Rover rover = new Rover(initialPosition);
            rover.Move(MoveDirection.Forward);

            Assert.AreEqual(1, rover.CurrentPosition.Y);
        }

        [Test]
        public void ZeroZeroAndFacingEastWhenMovingForwardThenXIsOne()
        {
            Position initialPosition = new Position(0, 0, Orientation.East);

            Rover rover = new Rover(initialPosition);
            rover.Move(MoveDirection.Forward);

            Assert.AreEqual(1, rover.CurrentPosition.X);
        }

        [Test]
        public void ZeroZeroAndFacingEastWhenTurningRightThenOrientationIsSouth()
        {
            Position initialPosition = new Position(0, 0, Orientation.East);

            Rover rover = new Rover(initialPosition);
            rover.Turn(TurnDirection.Righ);

            Assert.AreEqual(Orientation.South, rover.CurrentPosition.Orientation);
        }

        [Test]
        public void ZeroZeroAndFacingEastWhenTurningLeftThenOrientationIsNorth()
        {
            Position initialPosition = new Position(0, 0, Orientation.East);
            
            Rover rover = new Rover(initialPosition);
            rover.Turn(TurnDirection.Left);

            Assert.AreEqual(Orientation.North, rover.CurrentPosition.Orientation);
        }

        // current tests: 
        // 0, 0, N => command is move F => 0, 1, N
        // 0, 0, E => command is move F => 1, 0, E => don't have assertion that orientation is the same
        // 0, 0, E => command is turn R => 0, 0, S => don't have assertion that position didn't change
        // 0, 0, E => command is turn L => 0, 0, N => same as above
        // tests to write for completion:
        // more to go
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

    public static class Orientation
    {
        public const char North = 'N';
        public const char East = 'E';
        public const char South = 'S';
    }

    public static class TurnDirection
    {
        public const char Left = 'L';
        public const char Righ = 'R';
    }

    public static class MoveDirection
    {
        public const char Forward = 'F';
        public const char Backward = 'B';
    }
}
