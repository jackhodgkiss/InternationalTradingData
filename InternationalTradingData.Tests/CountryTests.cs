using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData.Tests
{
    [TestFixture]
    public class CountryTests
    {        
        private String URL = TestContext.CurrentContext.TestDirectory + "/countries.csv";

        private Country UK, USA;

        [OneTimeSetUp]
        public void Init()
        {
            Country[] countries;
            countries = CountryParser.GetCountries(URL);
            USA = countries[0];
            UK = countries[9];
        }

        /// <summary>
        /// This test aims to establish if the <code>Country</code> class is capable of 
        /// correctly implementing the IComparable interface. This interface would be 
        /// correctly implemented if a country is compared against another country with 
        /// the result be an agreeded result.
        /// Given two countries A and B; if A is smaller lexically then -1 should be returned if 
        /// not 1 should be returned and in the event that A and B are equal then 0 is returned.
        /// </summary>
        /// <see cref="Country"/>
        [Test]
        public void CountryCompareTo()
        {
            Assert.AreEqual(-1, UK.CompareTo(USA));
            Assert.AreEqual(0, UK.CompareTo(UK));
            Assert.AreEqual(1, USA.CompareTo(UK));
        }
    }
}
