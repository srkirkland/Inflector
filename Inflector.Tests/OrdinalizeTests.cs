using NUnit.Framework;

namespace Inflector.Tests
{
    [TestFixture]
    public class OrdinalizeTests : InflectorTestBase
    {
        [Test]
        public void Ordinalize()
        {
            foreach (var pair in TestData)
            {
                Assert.AreEqual(Inflector.Ordinalize(pair.Key), pair.Value);
            }
        }

        public OrdinalizeTests()
        {
            TestData.Add("0", "0th");
            TestData.Add("1", "1st");
            TestData.Add("2", "2nd");
            TestData.Add("3", "3rd");
            TestData.Add("4", "4th");
            TestData.Add("5", "5th");
            TestData.Add("6", "6th");
            TestData.Add("7", "7th");
            TestData.Add("8", "8th");
            TestData.Add("9", "9th");
            TestData.Add("10", "10th");
            TestData.Add("11", "11th");
            TestData.Add("12", "12th");
            TestData.Add("13", "13th");
            TestData.Add("14", "14th");
            TestData.Add("20", "20th");
            TestData.Add("21", "21st");
            TestData.Add("22", "22nd");
            TestData.Add("23", "23rd");
            TestData.Add("24", "24th");
            TestData.Add("100", "100th");
            TestData.Add("101", "101st");
            TestData.Add("102", "102nd");
            TestData.Add("103", "103rd");
            TestData.Add("104", "104th");
            TestData.Add("110", "110th");
            TestData.Add("1000", "1000th");
            TestData.Add("1001", "1001st");

        }
    }
}