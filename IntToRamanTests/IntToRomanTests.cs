using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntToRaman;

namespace IntToRamanTests
{
    [TestClass]
    public class IntToRomanTests
    {
        IntToRoman intToRoman = new IntToRoman();

        [TestMethod]
        public void TestMethod1()
        {
            string actual = intToRoman.roman_numbers(3749); //"MMMDCCXLIX"
            Assert.AreEqual("MMMDCCXLIX", actual, "Error :(");
        }

        [TestMethod]
        public void TestMethod2()
        {
            string actual = intToRoman.roman_numbers(58); //"LVIII"
            Assert.AreEqual("LVIII", actual, "Error :(");
        }

        [TestMethod]
        public void TestMethod3()
        {
            string actual = intToRoman.roman_numbers(1994); //"MCMXCIV"
            Assert.AreEqual("MCMXCIV", actual, "Error :(");
        }
    }
}
