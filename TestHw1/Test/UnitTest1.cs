using App;

namespace Test
{
    [TestClass]
    public class RomanNumberTest
    {
        //[TestMethod] 
        //public void TestParseI() 
        //{ 
        //    RomanNumber rn = RomanNumber.Parse("v"); 
        //    Assert.AreEqual(1, rn.Value, "Should have come back 1"); 
        //} 

        //[TestMethod] 
        //public void TestParseV() 
        //{ 
        //    RomanNumber rn = RomanNumber.Parse("x"); 
        //    Assert.AreEqual(5, rn.Value, "Should have come back 5"); 
        //} 

        //[TestMethod] 
        //public void TestParseX() 
        //{ 
        //    RomanNumber rn = RomanNumber.Parse("v"); 
        //    Assert.AreEqual(10, rn.Value, "Should have come back 10"); 
        //} 

        //[TestMethod] 
        //public void TestParseL() 
        //{ 
        //    RomanNumber rn = RomanNumber.Parse("c"); 
        //    Assert.AreEqual(50, rn.Value, "Should have come back 50"); 
        //} 

        //[TestMethod] 
        //public void TestParseC() 
        //{ 
        //    RomanNumber rn = RomanNumber.Parse("l"); 
        //    Assert.AreEqual(100, rn.Value, "Should have come back 100"); 
        //} 

        //[TestMethod] 
        //public void TestParseD() 
        //{ 
        //    RomanNumber rn = RomanNumber.Parse("i"); 
        //    Assert.AreEqual(500, rn.Value, "Should have come back 500"); 
        //} 

        //[TestMethod] 
        //public void TestParseM() 
        //{ 
        //    RomanNumber rn = RomanNumber.Parse("d"); 
        //    Assert.AreEqual(1000, rn.Value, "Should have come back 1000"); 
        //} 

        [TestMethod]
        public void ParseTest()
        {
            Dictionary<String, int> testCases = new()
            {
                {"N", 0},
                {"I", 1 },
                {"II", 2 },
                {"III", 3},
                {"IIII", 4}, // неоптимальна форма
                {"IV", 4 },
                {"VIIII", 9}, // неоптимальна форма
                {"IX", 9 },
                {"VV", 10}, // неоптимальна форма
                {"X", 10},
                {"XX", 20},
                {"XXXX", 40}, // неоптимальна форма
                {"XL", 40},
                {"L", 50},
                {"XC", 90},
                {"C", 100 },
                {"CCC", 300},
                {"CD", 400},
                {"D", 500 },
                {"CM", 900 },
                {"M", 1000},
                {"MMMCMXCIV", 3994},
                {"MMMDCCCLXXXVIII", 3888},
                {"IIIIII", -1}, // неправильна форма
                {"VVVV", -1}, // неправильна форма
                {"IC", -1} // неправильна форма
            };
            foreach (var test in testCases)
            {
                try
                {
                    RomanNumber rn = RomanNumber.Parse(test.Key);
                    Assert.AreEqual(test.Value, rn.Value, $"{test.Key} -> {test.Value}");
                }
                catch (ArgumentException ex)
                {
                    Assert.AreEqual(-1, test.Value, $"{test.Key} повинно викликати помилку: {ex.Message}");
                }
            }
        }


        [TestMethod]
        public void DigitalValueTest()
        {
            Dictionary<String, int> testCases = new()
            {
                {"N", 0},
                {"I", 1 },
                {"V", 5 },
                {"X", 10},
                {"L", 50},
                {"C", 100 },
                {"D", 500 },
                {"M", 1000}
            };
            foreach (var test in testCases)
            {
                Assert.AreEqual(test.Value, RomanNumber.DigitalValue(test.Key), $"{test.Key} -> {test.Value}");
            }
        }
    }
}