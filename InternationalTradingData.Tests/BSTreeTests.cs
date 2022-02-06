using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData.Tests
{
    [TestFixture]
    public class BSTreeTests
    {
        private String URL = TestContext.CurrentContext.TestDirectory + "/countries.csv";

        private Country USA, Canada, UK, Russia, China;

        private BSTree<String, Country> BSTCountry;

        [SetUp]
        public void Init()
        {
            Country[] countries;
            countries = CountryParser.GetCountries(URL);

            USA = countries[0];
            Canada = countries[1];
            UK = countries[8];
            Russia = countries[12];
            China = countries[18];

            BSTCountry = new BSTree<string, Country>(USA.Name, USA);
            BSTCountry.Create(Canada.Name, Canada);
            BSTCountry.Create(UK.Name, UK);
            BSTCountry.Create(Russia.Name, Russia);
            BSTCountry.Create(China.Name, China);
        }

        /// <summary>
        /// Test explores the <code>BSTree</code> and its ability to determine if a given node exists within
        /// it. It looks through the tree for a key that matches the supplied argument.
        /// </summary>
        /// <see cref="BSTree{TKey, TValue}"/>
        [Test]
        public void BSTreeContains()
        {
            Assert.IsTrue(BSTCountry.Contains(USA.Name));
            Assert.IsTrue(BSTCountry.Contains(China.Name));
            Assert.IsFalse(BSTCountry.Contains("Finland"));
        }

        /// <summary>
        /// Test explores the <code>BSTree</code> and its ability to return the value it is storing within 
        /// the tree by looking for a node that matches the key.
        /// </summary>
        /// <see cref="BSTree{TKey, TValue}"/>
        [Test]
        public void BSTreeGet()
        {
            Assert.AreSame(USA, BSTCountry.Get(USA.Name));
            Assert.AreSame(default(Country), BSTCountry.Get("Finland"));
        }

        /// <summary>
        /// Test explores the <code>BSTree</code> and its ability to edit the value of node within the tree.
        /// </summary>
        /// <see cref="BSTree{TKey, TValue}"/>
        [Test]
        public void BSTreeEdit()
        {
            Country UKFromFile = Country.Clone(BSTCountry.Get(UK.Name));
            Assert.AreEqual(UKFromFile.GDP, UK.GDP);
            UKFromFile.GDP *= 2;
            Assert.AreNotEqual(UKFromFile.GDP, UK.GDP);
            Assert.AreNotEqual(UKFromFile.GDP, BSTCountry.Get(UK.Name));
            BSTCountry.Edit(UKFromFile.Name, UKFromFile);
            Assert.AreNotEqual(BSTCountry.Get(UK.Name).GDP, UK.GDP);
            Assert.AreEqual(UKFromFile.GDP, BSTCountry.Get(UK.Name).GDP);
        }

        /// <summary>
        /// Test explores the <code>BSTree</code> and its ability to delete the value of node within the tree.
        /// </summary>
        /// <see cref="BSTree{TKey, TValue}"/>
        [Test]
        public void BSTreeDelete()
        {
            Assert.IsTrue(BSTCountry.Contains("UK"));
            Assert.AreEqual(5, BSTCountry.GetNodeCount());
            BSTCountry.Delete("UK");
            Assert.IsFalse(BSTCountry.Contains("UK"));
            Assert.AreEqual(4, BSTCountry.GetNodeCount());
        }

        /// <summary>
        /// Test looks at if the <code>BSTree</code> can generate a list of in order nodes.
        /// </summary>
        /// <see cref="BSTree{TKey, TValue}"/>
        [Test]
        public void BSTreeInOrder()
        {
            List<String> expected = new List<string>(new String[] { "Canada", "China", "Russia", "UK", "USA" });
            Assert.AreEqual(expected, BSTCountry.InOrder());
        }

        /// <summary>
        /// Test looks at if the <code>BSTree</code> can generate a list of pre order nodes.
        /// </summary>
        /// <see cref="BSTree{TKey, TValue}"/>
        [Test]
        public void BSTreePreOrder()
        {
            List<String> expected = new List<string>(new String[] { "USA", "Canada", "UK", "Russia", "China" });
            Assert.AreEqual(expected, BSTCountry.PreOrder());
        }

        /// <summary>
        /// Test looks at if the <code>BSTree</code> can generate a list of post order nodes.
        /// </summary>
        /// <see cref="BSTree{TKey, TValue}"/>
        [Test]
        public void BSTreePostOrder()
        {
            List<String> expected = new List<string>(new String[] { "China", "Russia", "UK", "Canada", "USA" });
            Assert.AreEqual(expected, BSTCountry.PostOrder());
        }

        /// <summary>
        /// Test looks at if the <code>BSTree</code> can correctly report on the population of nodes within
        /// the tree.
        /// </summary>
        /// <see cref="BSTree{TKey, TValue}"/>
        [Test]
        public void BSTreeGetNodeCount()
        {
            Assert.AreEqual(5, BSTCountry.GetNodeCount());
        }

        /// <summary>
        /// Test looks at if the <code>BSTree</code> can correctly report on the height the tree.
        /// </summary>
        /// <see cref="BSTree{TKey, TValue}"/>
        [Test]
        public void BSTreeGetHeight()
        {
            Assert.AreEqual(5, BSTCountry.GetHeight());
        }
    }
}
