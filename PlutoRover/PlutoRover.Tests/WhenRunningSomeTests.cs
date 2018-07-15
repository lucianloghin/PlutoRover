using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter.Xml;
using NUnit.Framework;

namespace PlutoRover.Tests
{
    [TestFixture]
    public class WhenRunningSomeTests
    {
        // Pluto is a grid
        // rover will have an initial position
        // F - forward
        // B - backwards
        // L - turn left
        // R - turn right

        [Test]
        public void DoSomeStuff()
        {
            int initialX = 0;
            int initialY = 0;
            string orientation = "N";
            char step = 'F'; 

            Rover rover = new Rover(initialX, initialY, orientation);
            rover.Move(step);

            Assert.AreEqual(rover.Y, 1);
        }
    }

    public class Rover
    {
        private int x;
        private int y;
        private string orientation;

        public Rover(int x, int y, string orientation)
        {
            this.x = x;
            this.y = y;
            this.orientation = orientation;
        }

        public int Y { get; set; }

        public void Move(char step)
        {
            this.Y = 1;
        }
    }
}
