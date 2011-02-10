using NUnit.Framework;

namespace Inflector.Tests
{
    [TestFixture]
    public class PascalizeAndCamelizeTests : InflectorTestBase
    {
        [Test]
        public void Pascalize()
        {
            foreach (var pair in TestData)
            {
                Assert.AreEqual(Inflector.Pascalize(pair.Key), pair.Value);
            }
        }

        /// <summary>
        /// Same as pascalize, except first char is lowercase
        /// </summary>
        [Test]
        public void Camelize()
        {
            foreach (var pair in TestData)
            {
                var lowercaseFirstChar = pair.Value.Substring(0, 1).ToLower() + pair.Value.Substring(1);
                Assert.AreEqual(Inflector.Camelize(pair.Key), lowercaseFirstChar);
            }
        }

        public PascalizeAndCamelizeTests()
        {
            TestData.Add("customer", "Customer");
            TestData.Add("CUSTOMER", "CUSTOMER");
            TestData.Add("CUStomer", "CUStomer");
            TestData.Add("customer_name", "CustomerName");
            TestData.Add("customer_first_name", "CustomerFirstName");
            TestData.Add("customer_first_name_goes_here", "CustomerFirstNameGoesHere");
            TestData.Add("customer name", "Customer name");
        }
    }
}