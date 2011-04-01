using System;
using System.Collections;
using System.Collections.Generic;
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
                Assert.AreEqual(pair.Key.Ordinalize(), pair.Value);
            }
        }

        [TestCase(0, "0th")]
        [TestCase(1, "1st")]
        [TestCase(2, "2nd")]
        [TestCase(3, "3rd")]
        [TestCase(4, "4th")]
        [TestCase(5, "5th")]
        [TestCase(6, "6th")]
        [TestCase(7, "7th")]
        [TestCase(8, "8th")]
        [TestCase(9, "9th")]
        [TestCase(10, "10th")]
        [TestCase(11, "11th")]
        [TestCase(12, "12th")]
        [TestCase(13, "13th")]
        [TestCase(14, "14th")]
        [TestCase(20, "20th")]
        [TestCase(21, "21st")]
        [TestCase(22, "22nd")]
        [TestCase(23, "23rd")]
        [TestCase(24, "24th")]
        [TestCase(100, "100th")]
        [TestCase(101, "101st")]
        [TestCase(102, "102nd")]
        [TestCase(103, "103rd")]
        [TestCase(104, "104th")]
        [TestCase(110, "110th")]
        [TestCase(1000, "1000th")]
        [TestCase(1001, "1001st")]
        public void OrdanizeNumbersTest(int number, string ordanized)
        {
            Assert.AreEqual(number.Ordinalize(), ordanized);
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