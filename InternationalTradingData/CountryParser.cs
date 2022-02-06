using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData
{
    /// <summary>
    /// CountryParser is a utility class that helps with construct a collection of countries by 
    /// reading a specified file as supplied by the user.
    /// </summary>
    public static class CountryParser
    {
        /// <summary>
        /// Construct an array of countries by parsing the countries from the supplied file.
        /// </summary>
        /// <param name="URL">Location of file relative bin/Debug.</param>
        /// <returns>Array of countries pulled from the supplied file.</returns>
        public static Country[] GetCountries(String URL)
        {
            String[] data = File.ReadAllLines(URL);
            Country[] countries = new Country[data.Length - 1];
            for(int i = 0; i < countries.Length; i++)
            {
                String tuple = data[i + 1];
                String[] columns = tuple.Split(',');
                Country country = new Country();
                country.Name = columns[0];
                country.GDP = float.Parse(columns[1]);
                country.Inflation = float.Parse(columns[2]);
                country.TradeBalance = float.Parse(columns[3]);
                country.HDI = float.Parse(columns[4]);
                country.TradePartners = new LinkedList<String>(columns[5].Split(
                    new char[] { '[', ';', ']' }, StringSplitOptions.RemoveEmptyEntries));
                countries[i] = country;
            }
            return countries;
        }
    }
}
