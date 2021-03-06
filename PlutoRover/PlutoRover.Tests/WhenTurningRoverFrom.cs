﻿using NUnit.Framework;

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

        [Test]
        public void FacingEastWhenTurningLeftThenPositionDoesNotChange()
        {
            Position initialPosition = new Position(0, 0, Orientation.East);

            Rover rover = new Rover(initialPosition);
            rover.Turn(TurnDirection.Left);

            Assert.AreEqual(initialPosition.X, rover.CurrentPosition.X);
            Assert.AreEqual(initialPosition.Y, rover.CurrentPosition.Y);
        }

        [Test]
        public void FacingEastWhenTurningRightThenPositionDoesNotChange()
        {
            Position initialPosition = new Position(0, 0, Orientation.East);

            Rover rover = new Rover(initialPosition);
            rover.Turn(TurnDirection.Righ);

            Assert.AreEqual(initialPosition.X, rover.CurrentPosition.X);
            Assert.AreEqual(initialPosition.Y, rover.CurrentPosition.Y);
        }
    }
}
