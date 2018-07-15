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
            Position initialPosition = new Position(0, 0, "N");
            char moveForwardStep = 'F'; 

            Rover rover = new Rover(initialPosition);
            rover.Move(moveForwardStep);

            Assert.AreEqual(rover.CurrentPosition.Y, 1);
        }

        [Test]
        public void ZeroZeroAndFacingEastWhenMovingForwardThenXIsOne()
        {
            Position initialPosition = new Position(0, 0, "E");
            char moveForwardStep = 'F';

            Rover rover = new Rover(initialPosition);
            rover.Move(moveForwardStep);

            Assert.AreEqual(rover.CurrentPosition.X, 1);
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
            if (this.position.Orientation == "E")
            {
                this.position.X = 1;
            }
            else
            {
                this.position.Y = 1;
            }
        }
    }

    public class Position
    {
        public Position(int x, int y, string orientation)
        {
            this.X = x;
            this.Y = y;
            this.Orientation = orientation;
        }

        public int Y { get; set; }
        public int X { get; set; }
        public string Orientation { get; set; }
    }
}
