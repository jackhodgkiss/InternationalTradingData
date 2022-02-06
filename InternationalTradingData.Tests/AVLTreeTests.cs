using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData.Tests
{
    [TestFixture]
    public class AVLTreeTests
    {
        private String URL = TestContext.CurrentContext.TestDirectory + "/countries.csv";

        private Country USA, Canada, UK, Russia, China;

        private AVLTree<String, Country> AVLCountry;

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

            AVLCountry = new AVLTree<string, Country>(USA.Name, USA);
            AVLCountry.Create(Canada.Name, Canada);
            AVLCountry.Create(UK.Name, UK);
            AVLCountry.Create(Russia.Name, Russia);
            AVLCountry.Create(China.Name, China);
        }

        /// <summary>
        /// Test explores the <code>AVLTree</code> and its ability to determine if a given node exists within
        /// it. It looks through the tree for a key that matches the supplied argument.
        /// </summary>
        /// <see cref="AVLTree{TKey, TValue}"/>
        [Test]
        public void AVLTreeContains()
        {
            Assert.IsTrue(AVLCountry.Contains(USA.Name));
            Assert.IsTrue(AVLCountry.Contains(China.Name));
            Assert.IsFalse(AVLCountry.Contains("Finland"));
        }

        /// <summary>
        /// Test explores the <code>AVLTree</code> and its ability to return the value it is storing within 
        /// the tree by looking for a node that matches the key.
        /// </summary>
        /// <see cref="AVLTree{TKey, TValue}"/>
        [Test]
        public void AVLTreeGet()
        {
            Assert.AreSame(USA, AVLCountry.Get(USA.Name));
            Assert.AreSame(default(Country), AVLCountry.Get("Finland"));
        }

        /// <summary>
        /// Test explores the <code>AVLTree</code> and its ability to edit the value of node within the tree.
        /// </summary>
        /// <see cref="AVLTree{TKey, TValue}"/>
        [Test]
        public void AVLTreeEdit()
        {
            Country UKFromFile = Country.Clone(AVLCountry.Get(UK.Name));
            Assert.AreEqual(UKFromFile.GDP, UK.GDP);
            UKFromFile.GDP *= 2;
            Assert.AreNotEqual(UKFromFile.GDP, UK.GDP);
            Assert.AreNotEqual(UKFromFile.GDP, AVLCountry.Get(UK.Name));
            AVLCountry.Edit(UKFromFile.Name, UKFromFile);
            Assert.AreNotEqual(AVLCountry.Get(UK.Name).GDP, UK.GDP);
            Assert.AreEqual(UKFromFile.GDP, AVLCountry.Get(UK.Name).GDP);
        }

        /// <summary>
        /// Test explores the <code>AVLTree</code> and its ability to delete the value of node within the tree.
        /// </summary>
        /// <see cref="AVLTree{TKey, TValue}"/>
        [Test]
        public void AVLTreeDelete()
        {
            Assert.IsTrue(AVLCountry.Contains("UK"));
            Assert.AreEqual(5, AVLCountry.GetNodeCount());
            AVLCountry.Delete("UK");
            Assert.IsFalse(AVLCountry.Contains("UK"));
            Assert.AreEqual(4, AVLCountry.GetNodeCount());
        }

        /// <summary>
        /// Test looks at if the <code>AVLTree</code> can generate a list of in order nodes.
        /// </summary>
        /// <see cref="AVLTree{TKey, TValue}"/>
        [Test]
        public void AVLTreeInOrder()
        {
            List<String> expected = new List<string>(new String[] { "Canada", "China", "Russia", "UK", "USA" });
            Assert.AreEqual(expected, AVLCountry.InOrder());
        }

        /// <summary>
        /// Test looks at if the <code>AVLTree</code> can generate a list of pre order nodes.
        /// </summary>
        /// <see cref="AVLTree{TKey, TValue}"/>
        [Test]
        public void AVLTreePreOrder()
        {
            List<String> expected = new List<string>(new String[] { "UK", "China", "Canada", "Russia", "USA" });
            Assert.AreEqual(expected, AVLCountry.PreOrder());
        }

        /// <summary>
        /// Test looks at if the <code>AVLTree</code> can generate a list of post order nodes.
        /// </summary>
        /// <see cref="AVLTree{TKey, TValue}"/>
        [Test]
        public void AVLTreePostOrder()
        {
            List<String> expected = new List<string>(new String[] { "Canada", "Russia", "China", "USA", "UK" });
            Assert.AreEqual(expected, AVLCountry.PostOrder());
        }

        /// <summary>
        /// Test looks at if the <code>AVLTree</code> can correctly report on the population of nodes within
        /// the tree.
        /// </summary>
        /// <see cref="AVLTree{TKey, TValue}"/>
        [Test]
        public void AVLTreeGetNodeCount()
        {
            Assert.AreEqual(5, AVLCountry.GetNodeCount());
        }

        /// <summary>
        /// Test looks at if the <code>AVLTree</code> can correctly report on the height the tree.
        /// </summary>
        /// <see cref="AVLTree{TKey, TValue}"/>
        [Test]
        public void AVLTreeGetHeight()
        {
            Assert.AreEqual(3, AVLCountry.GetHeight());
        }
    }
}
