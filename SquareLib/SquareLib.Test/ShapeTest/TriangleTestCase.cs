using NUnit.Framework;
using SquareLibr;
using System;

namespace SquareLib.Test.ShapeTest
{
    [TestFixture]
    class TriangleTestCase
    {
        [Test]
        public void Triangle_Valid_CorrectArea()
        {
            Assert.AreEqual(6d, new Triangle(5, 4, 3).Area);
        }

        [Test]
        public void Triangle_NotValid()
        {
            Assert.Throws(Is.TypeOf<ArgumentException>(), () => new Triangle(5, 0, 3));
        }

        [Test]
        public void Triangle_Valid_IsRight()
        {
            Assert.IsTrue(new Triangle(5, 4, 3).IsRight);
        }

        [Test]
        public void Triangle_NotValid_IsRight()
        {
            Assert.IsFalse(new Triangle(5, 4, 4).IsRight);
        }
    }
}
