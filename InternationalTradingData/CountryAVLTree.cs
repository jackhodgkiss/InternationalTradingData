using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData
{
    /// <summary>
    /// CountryAVLTree is an impementation of a generic AVLTree that explicitly uses Country as the
    /// node's value. As a result this class can provide improved functionality specific to the 
    /// Country class such as working with trading statistics that each Country instance contains. 
    /// The class also attempts to clean up each of the node manipulation functions by asking for 
    /// Name rather than Key. This helps reinforce the purpose of this class.
    /// </summary>
    public class CountryAVLTree : AVLTree<String, Country>
    {
        /// <summary>
        /// Construct a new CountryAVLTree with null Root.
        /// </summary>
        public CountryAVLTree() : base() { }

        /// <summary>
        /// Construct a new CountryAVLTree with Root contaning the provided Country.
        /// </summary>
        /// <param name="Country">Country object to be made Root.</param>
        public CountryAVLTree(Country Country) : base(Country.Name, Country) { }

        /// <summary>
        /// Add a new Country to the tree.
        /// </summary>
        /// <param name="Country">Country to be added to tree.</param>
        public void Create(Country Country)
        {
            base.Create(Country.Name, Country);
        }

        /// <summary>
        /// Fetch the Country with the specified name.
        /// </summary>
        /// <param name="Name">Name of country to be returned.</param>
        /// <returns>Country with the name provided.</returns>
        public override Country Get(String Name)
        {
            return Country.Clone(base.Get(Name));
        }

        /// <summary>
        /// Edit a prexisting Country.
        /// </summary>
        /// <param name="Country">Country to be updated.</param>
        public void Edit(Country Country)
        {
            base.Edit(Country.Name, Country);
        }

        /// <summary>
        /// Delete a Country from the tree.
        /// </summary>
        /// <param name="Name">Name of Country to be deleted.</param>
        public override void Delete(String Name)
        {
            base.Delete(Name);
        }

        /// <summary>
        /// Find names of countries that match the partially against the supplied Partial name.
        /// </summary>
        /// <param name="Partial">Partial name of country being searched for.</param>
        /// <returns>List of countries' names matching partially.</returns>
        public List<String> GetPartials(String Partial)
        {
            List<String> partials = new List<string>();
            List<String> names = InOrder();
            foreach (String name in names)
            {
                if (name.Contains(Partial))
                {
                    partials.Add(name);
                }
            }
            return partials;
        }

        /// <summary>
        /// Find all of the countries that trade with the country provided. Countries are included 
        /// if the specified country appears in their trading partner list or if the speicifed 
        /// country includes them within their list.
        /// </summary>
        /// <param name="Name">Name of Country trade partners are been discovered for.</param>
        /// <returns>List of name of trading partners.</returns>
        public List<String> GetTradeWith(String Name)
        {
            List<String> partners = new List<string>();
            List<String> countries = InOrder();
            foreach (String countryName in countries)
            {
                if (Get(countryName).TradePartners.Contains(Name))
                {
                    partners.Add(countryName);
                }
            }
            return partners;
        }

        /// <summary>
        /// Find the country with the largest trading potential. Sum of trading partners GDP.
        /// </summary>
        /// <returns>Name of country with largest trading potential.</returns>
        public String GetBiggestTradePotential()
        {
            Country biggestPotential = null;
            float biggestPotentialAmount = 0;

            foreach(String name in InOrder())
            {
                float amount = 0.0f;
                Country country = Get(name);
                foreach(String partnerName in country.TradePartners)
                {
                    Country partner = Contains(partnerName) ? Get(partnerName) : null;
                    amount += partner != null ? partner.GDP : 0;
                }
                if(amount > biggestPotentialAmount)
                {
                    biggestPotentialAmount = amount;
                    biggestPotential = country;
                }
            }
            return biggestPotential != null ? biggestPotential.Name : String.Empty;
        }
    }
}
