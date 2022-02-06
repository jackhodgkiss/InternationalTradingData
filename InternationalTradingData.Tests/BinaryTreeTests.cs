using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData.Tests
{
    [TestFixture]
    public class BinaryTreeTests
    {
        private String URL = TestContext.CurrentContext.TestDirectory + "/countries.csv";

        private Country USA, Canada, UK, Russia, China;

        private BinaryTree<String, Country> BTCountry;

        [OneTimeSetUp]
        public void Init()
        {
            Country[] countries;
            countries = CountryParser.GetCountries(URL);

            USA = countries[0];
            Canada = countries[1];
            UK = countries[8];
            Russia = countries[12];
            China = countries[18];

            BTCountry = new BinaryTree<string, Country>(USA.Name, USA);
            BTCountry.Root.Left = new Node<string, Country>(Canada.Name, Canada);
            BTCountry.Root.Left.Right = new Node<string, Country>(UK.Name, UK);
            BTCountry.Root.Left.Right.Left = new Node<string, Country>(Russia.Name, Russia);
            BTCountry.Root.Left.Right.Left.Left = new Node<string, Country>(China.Name, China);
        }

        /// <summary>
        /// Test explores the <code>BinaryTree</code> and its ability to determine if a given node exists within
        /// it. It looks through the tree for a key that matches the supplied argument.
        /// </summary>
        /// <see cref="BinaryTree{TKey, TValue}"/>
        [Test]
        public void BinaryTreeContains()
        {
            Assert.IsTrue(BTCountry.Contains(USA.Name));
            Assert.IsTrue(BTCountry.Contains(China.Name));
            Assert.IsFalse(BTCountry.Contains("Finland"));            
        }

        /// <summary>
        /// Test explores the <code>BinaryTree</code> and its ability to return the value it is storing within 
        /// the tree by looking for a node that matches the key.
        /// </summary>
        /// <see cref="BinaryTree{TKey, TValue}"/>
        [Test]
        public void BinaryTreeGet()
        {
            Assert.AreSame(USA, BTCountry.Get(USA.Name));
            Assert.AreSame(default(Country), BTCountry.Get("Finland"));
        }

        /// <summary>
        /// Test looks at if the <code>BinaryTree</code> can generate a list of in order nodes.
        /// </summary>
        /// <see cref="BinaryTree{TKey, TValue}"/>
        [Test]
        public void BinaryTreeInOrder()
        {
            List<String> expected = new List<string>(new String[] {"Canada", "China", "Russia", "UK", "USA"});
            Assert.AreEqual(expected, BTCountry.InOrder());
        }

        /// <summary>
        /// Test looks at if the <code>BinaryTree</code> can generate a list of pre order nodes.
        /// </summary>
        /// <see cref="BinaryTree{TKey, TValue}"/>
        [Test]
        public void BinaryTreePreOrder()
        {
            List<String> expected = new List<string>(new String[] { "USA", "Canada", "UK", "Russia", "China"});
            Assert.AreEqual(expected, BTCountry.PreOrder());
        }

        /// <summary>
        /// Test looks at if the <code>BinaryTree</code> can generate a list of post order nodes.
        /// </summary>
        /// <see cref="BinaryTree{TKey, TValue}"/>
        [Test]
        public void BinaryTreePostOrder()
        {
            List<String> expected = new List<string>(new String[] { "China", "Russia", "UK", "Canada", "USA" });
            Assert.AreEqual(expected, BTCountry.PostOrder());
        }

        /// <summary>
        /// Test looks at if the <code>BinaryTree</code> can correctly report on the population of nodes within
        /// the tree.
        /// </summary>
        /// <see cref="BinaryTree{TKey, TValue}"/>
        [Test]
        public void BinaryTreeGetNodeCount()
        {
            Assert.AreEqual(5, BTCountry.GetNodeCount());
        }

        /// <summary>
        /// Test looks at if the <code>BinaryTree</code> can correctly report on the height the tree.
        /// </summary>
        /// <see cref="BinaryTree{TKey, TValue}"/>
        [Test]
        public void BinaryTreeGetHeight()
        {
            Assert.AreEqual(5, BTCountry.GetHeight());
        }
    }
}
