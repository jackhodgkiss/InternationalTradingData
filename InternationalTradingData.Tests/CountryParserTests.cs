using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData.Tests
{
    [TestFixture]
    public class CountryParserTests
    {
        private String URL = TestContext.CurrentContext.TestDirectory + "/countries.csv";

        private Country[] countries;

        [OneTimeSetUp]
        public void Init()
        {
            countries = CountryParser.GetCountries(URL);
        }

        /// <summary>
        /// This test aims to establish if the <code>CountryParser</code> is capable of 
        /// constructing each of the countries within the supplied data file. It tests to see if it
        /// has detected the correct number of countries and that have been placed into the array 
        /// correctly.
        /// </summary>
        /// <see cref="CountryParser"/>
        [Test]
        public void ParserLength()
        {
            Assert.AreEqual(27, countries.Length);
        }
    }
}
