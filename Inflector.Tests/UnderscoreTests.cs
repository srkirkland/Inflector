using NUnit.Framework;

namespace Inflector.Tests
{
    [TestFixture]
    public class UnderscoreTests : InflectorTestBase
    {
        [Test]
        public void Underscore()
        {
            foreach (var pair in TestData)
            {
                Assert.AreEqual(Inflector.Underscore(pair.Key), pair.Value);
            }
        }

        public UnderscoreTests()
        {
            //Makes an underscored lowercase string
            TestData.Add("SomeTitle", "some_title");
            TestData.Add("someTitle", "some_title");
            TestData.Add("some title", "some_title");
            TestData.Add("some title that will be underscored", "some_title_that_will_be_underscored");
            TestData.Add("SomeTitleThatWillBeUnderscored", "some_title_that_will_be_underscored");
        }
    }
}