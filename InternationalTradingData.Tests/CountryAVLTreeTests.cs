using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData.Tests
{
    [TestFixture]
    public class CountryAVLTreeTests
    {
        private String URL = TestContext.CurrentContext.TestDirectory + "/countries.csv";

        private CountryAVLTree AVLTCountry;

        [OneTimeSetUp]
        public void Init()
        {
            Country[] countries;
            countries = CountryParser.GetCountries(URL);

            AVLTCountry = new CountryAVLTree();
            countries.ToList().ForEach(c => AVLTCountry.Create(c));
        }

        /// <summary>
        /// Test explores the <code>CountryAVLTree</code> and its ability to find partial matches 
        /// to the names of countries.
        /// </summary>
        /// <see cref="CountryAVLTree"/>
        [Test]
        public void CountryAVLTreeGetPartials()
        {
            List<String> expected = new List<string>(new String[] { "Canada", "Chile", "China" });
            Assert.AreEqual(expected, AVLTCountry.GetPartials("C"));
        }

        /// <summary>
        /// Test explores the <code>CountryAVLTree</code> to if it capable of findind all trade 
        /// partners with a given country.
        /// </summary>
        /// <see cref="CountryAVLTree"/>
        [Test]
        public void CountryAVLTreeGetTradeWith()
        {
            List<String> expected = new List<string>(new String[] { "USA" });
            Assert.AreEqual(expected, AVLTCountry.GetTradeWith("Canada"));
        }

        /// <summary>
        /// Test explores the <code>CountryAVLTree</code> and its ability to determine the biggest 
        /// trade potential amongst all of the countries within the tree.
        /// </summary>
        /// <see cref="CountryAVLTree"/>
        [Test]
        public void CountryAVLTreeGetBiggestTradePotential()
        {
            Assert.AreEqual("Singapore", AVLTCountry.GetBiggestTradePotential());
        }
    }
}
