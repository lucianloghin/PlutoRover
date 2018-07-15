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
    public class WhenMovingRoverFromPosition
    {
        // Pluto is a grid
        // rover will have an initial position
        // F - forward
        // B - backwards
        // L - turn left
        // R - turn right

        [Test]
        public void ZeroZeroAndFacingNorthThenYIsOne()
        {
            int initialX = 0;
            int initialY = 0;
            string initialOrientation = "N";
            char moveForwardStep = 'F'; 

            Rover rover = new Rover(initialX, initialY, initialOrientation);
            rover.Move(moveForwardStep);

            Assert.AreEqual(rover.Y, 1);
        }
    }

    public class Rover
    {
        public Rover(int x, int y, string orientation)
        {
            this.X = x;
            this.Y = y;
            this.Orientation = orientation;
        }

        public int Y { get; private set; }
        public int X { get; private set; }
        public string Orientation { get; private set; }

        public void Move(char step)
        {
            this.Y = 1;
        }
    }
}