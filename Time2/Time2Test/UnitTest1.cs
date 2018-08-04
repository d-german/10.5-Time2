using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Time2Test
{
    [TestClass]
    public class Time2Test
    {
        [TestMethod]
        public void DefaultConstructorTest()
        {
            var time2 = new Time2();
            Assert.AreEqual(0, time2.Hour);
            Assert.AreEqual(0, time2.Minute);
            Assert.AreEqual(0, time2.Second);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InvalidTimeTest()
        {
            // Assert - Expects exception
            var time2 = new Time2(hour: 27, minute: 74, second: 99);

        }

        [TestMethod]
        public void ToUniversalStringTest()
        {
            var time2 = new Time2(hour: 12, minute: 25, second: 42);
            var expected = "12:25:42";
            var actual = time2.ToUniversalString();

            Assert.AreEqual(expected, actual);
        }
    }
}
