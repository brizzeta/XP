using App;

namespace Test
{
    [TestClass]
    public class RomanNumberTests
    {
        [TestMethod]
        public void Parse_EmptyString_ReturnsZero()
        {
            RomanNumber rn = RomanNumber.Parse("");
            Assert.IsNotNull(rn);
            Assert.AreEqual(0, rn.Value, "Zero test");
        }

        [TestMethod]
        public void Parse_ValidSingleRomanNumeral_ReturnsCorrectValue()
        {
            RomanNumber rn = RomanNumber.Parse("V");
            Assert.AreEqual(5, rn.Value, "Value should be 5");
        }

        [TestMethod]
        public void Parse_ValidComplexRomanNumeral_ReturnsCorrectValue()
        {
            RomanNumber rn = RomanNumber.Parse("IX");
            Assert.AreEqual(9, rn.Value, "Value should be 9");
        }

        [TestMethod]
        public void Parse_InvalidRomanNumeral_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => RomanNumber.Parse("A"));
        }
    }
}
