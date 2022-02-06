using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData.Tests
{
    [TestFixture]
    public class CountryBSTreeTests
    {
        private String URL = TestContext.CurrentContext.TestDirectory + "/countries.csv";

        private CountryBSTree BSTCountry;

        [OneTimeSetUp]
        public void Init()
        {
            Country[] countries;
            countries = CountryParser.GetCountries(URL);

            BSTCountry = new CountryBSTree();
            countries.ToList().ForEach(c => BSTCountry.Create(c));
        }

        /// <summary>
        /// Test explores the <code>CountryBSTree</code> and its ability to find partial matches 
        /// to the names of countries.
        /// </summary>
        /// <see cref="CountryBSTree"/>
        [Test]
        public void CountryBSTreeGetPartials()
        {
            List<String> expected = new List<string>(new String[] { "Canada", "Chile", "China" });
            Assert.AreEqual(expected, BSTCountry.GetPartials("C"));
        }

        /// <summary>
        /// Test explores the <code>CountryBSTree</code> to if it capable of findind all trade 
        /// partners with a given country.
        /// </summary>
        /// <see cref="CountryBSTree"/>
        [Test]
        public void CountryBSTreeGetTradeWith()
        {
            List<String> expected = new List<string>(new String[] { "USA" });
            Assert.AreEqual(expected, BSTCountry.GetTradeWith("Canada"));
        }

        /// <summary>
        /// Test explores the <code>CountryBSTree</code> and its ability to determine the biggest 
        /// trade potential amongst all of the countries within the tree.
        /// </summary>
        /// <see cref="CountryBSTree"/>
        [Test]
        public void CountryBSTreeGetBiggestTradePotential()
        {
            Assert.AreEqual("Singapore", BSTCountry.GetBiggestTradePotential());
        }
    }
}
