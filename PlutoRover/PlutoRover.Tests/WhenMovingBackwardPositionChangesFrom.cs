﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
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
    }
}