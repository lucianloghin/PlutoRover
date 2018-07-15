using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace PlutoRover.Tests
{
    [TestFixture]
    public class WhenTurningRoverFrom
    {
        [Test]
        public void FacingEastWhenTurningRightThenOrientationIsSouth()
        {
            Position initialPosition = new Position(0, 0, Orientation.East);

            Rover rover = new Rover(initialPosition);
            rover.Turn(TurnDirection.Righ);

            Assert.AreEqual(Orientation.South, rover.CurrentPosition.Orientation);
        }

        [Test]
        public void FacingEastWhenTurningLeftThenOrientationIsNorth()
        {
            Position initialPosition = new Position(0, 0, Orientation.East);

            Rover rover = new Rover(initialPosition);
            rover.Turn(TurnDirection.Left);

            Assert.AreEqual(Orientation.North, rover.CurrentPosition.Orientation);
        }
    }
}
