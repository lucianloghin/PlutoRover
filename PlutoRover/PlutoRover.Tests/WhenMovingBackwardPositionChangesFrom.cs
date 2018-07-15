using NUnit.Framework;

namespace PlutoRover.Tests
{
    [TestFixture]
    public class WhenMovingBackwardPositionChangesFrom
    {
        [Test]
        public void FiveFiveAndFacingNorthThenYIsFour()
        {
            Position initialPosition = new Position(5, 5, Orientation.North);

            Rover rover = new Rover(initialPosition);
            rover.Move(MoveDirection.Backward);

            Assert.AreEqual(4, rover.CurrentPosition.Y);
        }

        [Test]
        public void FiveFiveAndFacingEastThenXIsOne()
        {
            Position initialPosition = new Position(5, 5, Orientation.East);

            Rover rover = new Rover(initialPosition);
            rover.Move(MoveDirection.Backward);

            Assert.AreEqual(4, rover.CurrentPosition.X);
        }

        [Test]
        public void ZeroZeroAndFacingSouthThenYIsOne()
        {
            Position initialPosition = new Position(0, 0, Orientation.South);

            Rover rover = new Rover(initialPosition);
            rover.Move(MoveDirection.Backward);

            Assert.AreEqual(1, rover.CurrentPosition.Y);
        }

        [Test]
        public void OneOneAndFacingWestThenXIsZero()
        {
            Position initialPosition = new Position(1, 1, Orientation.West);

            Rover rover = new Rover(initialPosition);
            rover.Move(MoveDirection.Backward);

            Assert.AreEqual(2, rover.CurrentPosition.X);
        }
    }
}
