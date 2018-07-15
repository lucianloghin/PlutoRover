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
        public void ZeroZeroAndFacingNorthWhenMovingForwardThenOrientationDoesNotChange()
        {
            Position initialPosition = new Position(0, 0, Orientation.North);

            Rover rover = new Rover(initialPosition);
            rover.Move(MoveDirection.Forward);

            Assert.AreEqual(initialPosition.Orientation, rover.CurrentPosition.Orientation);
        }

        [Test]
        public void ZeroZeroAndFacingEastWhenMovingForwardThenOrientationDoesNotChange()
        {
            Position initialPosition = new Position(0, 0, Orientation.East);

            Rover rover = new Rover(initialPosition);
            rover.Move(MoveDirection.Forward);

            Assert.AreEqual(initialPosition.Orientation, rover.CurrentPosition.Orientation);
        }

        // current tests: 
        // 0, 0, N => command is move F => 0, 1, N
        // 0, 0, E => command is move F => 1, 0, E
        // 0, 0, E => command is turn R => 0, 0, S
        // 0, 0, E => command is turn L => 0, 0, N
        // tests to write for completion:
        // more to go
    }
}
