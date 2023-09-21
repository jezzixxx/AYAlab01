using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Rectangle_test()
        {
            Point A = new Point(0, 0);
            Point B = new Point(3, 0);
            Point C = new Point(0, 4);
            Point D = new Point(6, 4);
            Point E = new Point(3, 8);
            Figure test1 = new Figure(A, B, C);
            Assert.AreEqual(test1.LengthSide(A, B), 3);
            Assert.AreEqual(test1.LengthSide(A, C), 4);
            Assert.AreEqual(test1.LengthSide(B, C), 5);
            Assert.AreEqual(test1.PerimeterCalculator(), 12);
            Figure test2 = new Figure(A, B, D, C);
            Assert.AreEqual(test2.PerimeterCalculator(), 18);
            Assert.AreEqual(test2.LengthSide(C, D), 6);
            Figure test3 = new Figure(A, B, D, E, C);
            Assert.AreEqual(test3.PerimeterCalculator(), 22);
        }
    }
}
