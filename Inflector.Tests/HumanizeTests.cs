using NUnit.Framework;

namespace Inflector.Tests
{
    [TestFixture]
    public class HumanizeTests : InflectorTestBase
    {
        [Test]
        public void Humanize()
        {
            foreach (var pair in TestData)
            {
                Assert.AreEqual(pair.Key.Humanize(), pair.Value);
            }
        }

        public HumanizeTests()
        {
            //Capitalizes the first word, lowercases the rest and turns underscores into spaces
            TestData.Add("some_title", "Some title");
            TestData.Add("some-title", "Some-title");
            TestData.Add("Some_title", "Some title");
            TestData.Add("someTitle", "Sometitle");
            TestData.Add("someTitle_Another", "Sometitle another");
        }
    }
}