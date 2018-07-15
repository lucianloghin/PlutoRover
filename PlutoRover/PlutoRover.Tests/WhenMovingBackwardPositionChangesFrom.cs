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
    }
}
