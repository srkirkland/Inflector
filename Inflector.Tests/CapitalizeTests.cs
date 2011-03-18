using NUnit.Framework;

namespace Inflector.Tests
{
    [TestFixture]
    public class CapitalizeTests : InflectorTestBase
    {
        [Test]
        public void Capitalize()
        {
            foreach (var pair in TestData)
            {
                Assert.AreEqual(pair.Key.Capitalize(), pair.Value);
            }
        }

        public CapitalizeTests()
        {
            //Capitalizes the first char and lowers the rest of the string
            TestData.Add("some title", "Some title");
            TestData.Add("some Title", "Some title");
            TestData.Add("SOMETITLE", "Sometitle");
            TestData.Add("someTitle", "Sometitle");
            TestData.Add("some title goes here", "Some title goes here");
            TestData.Add("some TITLE", "Some title");
        }
    }
}