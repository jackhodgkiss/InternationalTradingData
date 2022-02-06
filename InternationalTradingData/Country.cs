using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData
{
    /// <summary>
    /// <code>Country</code> contains trading statistics needed to gauge the performance of a given
    /// country on an international level. This class implement the IComparable interface to allow
    /// for comparisons between different countries to take place, which will be lexically on each
    /// country's name. ToString has been overriden to summerise the trading statistics for a 
    /// given country.  
    /// </summary>
    public class Country : IComparable<Country>
    {
        /// <summary>
        /// Construct a empty country. Data can be provided properties.
        /// </summary>
        public Country() { }

        /// <summary>
        /// Construct a country with the supplied parameters.
        /// </summary>
        /// <param name="Name">Name of country.</param>
        /// <param name="GDP">Measure of goods and services market value.</param>
        /// <param name="Inflation">Rate of inflation.</param>
        /// <param name="TradeBalance">Different between exports and imports.</param>
        /// <param name="HDI">Composite statistic to rank human development.</param>
        /// <param name="TradePartners">Main trading partners.</param>
        public Country(String Name, float GDP, 
            float Inflation, float TradeBalance, 
            float HDI, LinkedList<String> TradePartners)
        {
            this.Name = Name;
            this.GDP = GDP;
            this.Inflation = Inflation;
            this.TradeBalance = TradeBalance;
            this.HDI = HDI;
            this.TradePartners = TradePartners; 
        }

        public static Country Clone(Country country)
        {
            return country != null ? new Country(country.Name, country.GDP, 
                country.Inflation, country.TradeBalance, 
                country.HDI, country.TradePartners) : null;
        }

        /// <summary>
        /// Lexically compare countries names against one another.
        /// </summary>
        /// <param name="other">Country that this country is being compared against.</param>
        /// <returns>Integer value indicating comparison results.</returns>
        public int CompareTo(Country other)
        {
            return Name.CompareTo(other.Name);
        }

        /// <summary>
        /// Summerise the country's trading statistics as a single string.
        /// </summary>
        /// <returns>String contain a summary of a country's trading statistics.</returns>
        public override string ToString()
        {
            return $"Name => {Name}, Gross Domestic Product => {GDP}, Inflation => {Inflation}, " 
                + $"Trade Balance => {TradeBalance}, Human Development Index => {HDI}, " 
                + $"Trade Partners => {String.Join(", ", TradePartners)}";
        }

        /// <summary>
        /// Name of country. Used uniquely identify a single country.
        /// </summary>
        /// <see cref="https://en.wikipedia.org/wiki/List_of_country-name_etymologies"/>
        public String Name { get; set; }

        /// <summary>
        /// Measures a country's value of goods and services within a period of time.
        /// </summary>
        /// <see cref="https://en.wikipedia.org/wiki/Gross_domestic_product"/>
        public float GDP { get; set; }

        /// <summary>
        /// Rate of inflation describes the rate at which prices increase over time.
        /// </summary>
        /// <see cref="https://en.wikipedia.org/wiki/Inflation"/>
        public float Inflation { get; set; }

        /// <summary>
        /// Difference between a country's exports and imports over a length of time.
        /// </summary>
        /// <see cref="https://en.wikipedia.org/wiki/Balance_of_trade"/>
        public float TradeBalance { get; set; }

        /// <summary>
        /// Composite statistic used to rank a country's development.
        /// </summary>
        /// <see cref="https://en.wikipedia.org/wiki/Human_Development_Index"/>
        public float HDI { get; set; }

        /// <summary>
        /// Major partners that this country carries out trade with.
        /// </summary>
        /// <see cref="https://en.wikipedia.org/wiki/List_of_countries_by_leading_trade_partners"/>
        public LinkedList<String> TradePartners { get; set; }
    }
}
