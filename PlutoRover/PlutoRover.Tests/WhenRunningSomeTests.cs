﻿using System;
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
    public class WhenMovingForwardPositionChangesFrom
    {
        // Pluto is a grid
        // rover will have an initial position

        [Test]
        public void ZeroZeroAndFacingNorthThenYIsOne()
        {
            Position initialPosition = new Position(0, 0, Orientation.North);

            Rover rover = new Rover(initialPosition);
            rover.Move(MoveDirection.Forward);

            Assert.AreEqual(1, rover.CurrentPosition.Y);
        }

        [Test]
        public void ZeroZeroAndFacingEastThenXIsOne()
        {
            Position initialPosition = new Position(0, 0, Orientation.East);

            Rover rover = new Rover(initialPosition);
            rover.Move(MoveDirection.Forward);

            Assert.AreEqual(1, rover.CurrentPosition.X);
        }
    }
}
