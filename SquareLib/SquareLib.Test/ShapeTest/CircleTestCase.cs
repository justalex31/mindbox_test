using NUnit.Framework;
using SquareLibr;
using System;

namespace SquareLib.Test.ShapeTest
{
    [TestFixture]
    class CircleTestCase
    {
        [Test]
        public void Сircle_ValidRadius_CorrectArea()
        {
            Assert.AreEqual(78.5d, new Circle(5).Area, 0.1);
        }

        [Test]
        public void Circle_NotValidRadius()
        {
            Assert.Throws(Is.TypeOf<ArgumentException>(), () => new Circle(-4));
        }
    }
}
