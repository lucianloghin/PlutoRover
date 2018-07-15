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

        // current tests: 
        // 0, 0, N => command is move F => 0, 1, N
        // 0, 0, E => command is move F => 1, 0, E => don't have assertion that orientation is the same
        // 0, 0, E => command is turn R => 0, 0, S => don't have assertion that position didn't change
        // 0, 0, E => command is turn L => 0, 0, N => same as above
        // tests to write for completion:
        // more to go
    }
}
