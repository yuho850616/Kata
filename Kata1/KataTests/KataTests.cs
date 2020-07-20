using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture()]
    public class KataTests
    {
        [Test()]
        public void AverageStringTest1()
        {
            StringAverage sa = new StringAverage();
            var input = "zero nine five two";
            var actual = sa.AverageString(input);
            var expected = "four";
            Assert.AreEqual(expected, actual);

        }

        [Test()]
        public void AverageStringTest2()
        {
            StringAverage sa = new StringAverage();
            var input = "four six two three";
            var actual = sa.AverageString(input);
            var expected = "three";
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void AverageStringTest3()
        {
            StringAverage sa = new StringAverage();
            var input = "one two three four five";
            var actual = sa.AverageString(input);
            var expected = "three";
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void AverageStringTest4()
        {
            StringAverage sa = new StringAverage();
            var input = "five four";
            var actual = sa.AverageString(input);
            var expected = "four";
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void AverageStringTest5()
        {
            StringAverage sa = new StringAverage();
            var input = "zero zero zero zero zero";
            var actual = sa.AverageString(input);
            var expected = "zero";
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void AverageStringTest6()
        {
            StringAverage sa = new StringAverage();
            var input = "one one eight one";
            var actual = sa.AverageString(input);
            var expected = "two";
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void AverageStringTest7()
        {
            StringAverage sa = new StringAverage();
            var input = "";
            var actual = sa.AverageString(input);
            var expected = "n/a";
            Assert.AreEqual(expected, actual);
        }

    }
}