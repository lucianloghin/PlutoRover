using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace PlutoRover.Tests
{
    [TestFixture]
    public class WhenMovingRoverOrientationDoesNotChange
    {
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
    }
}
