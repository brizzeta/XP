using App;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ParseTest()
        {
            RomanNumber rn = RomanNumber.Parse("");
            Assert.IsNotNull(rn);
            Assert.AreEqual(0, rn.value, "Zero test");

        }
    }
}