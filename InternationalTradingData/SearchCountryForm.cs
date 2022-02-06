using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternationalTradingData
{
    /// <summary>
    /// This class drives the SearchCountryForm which is used to allow the user to search for a 
    /// country by name.
    /// </summary>
    public partial class SearchCountryForm : Form
    {
        private CountryAVLTree countries;
        private DataTable dataTable;

        /// <summary>
        /// Entry point for the form.
        /// </summary>
        /// <param name="countries"></param>
        public SearchCountryForm(CountryAVLTree countries)
        {
            InitializeComponent();
            this.countries = countries;
            init();
        }

        /// <summary>
        /// Initalise the form.
        /// </summary>
        private void init()
        {
            initDataGrid();
        }

        /// <summary>
        /// Initalise the data grid with properties of the country as columns for the table.
        /// </summary>
        private void initDataGrid()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(String));
            dataTable.Columns.Add("GDP", typeof(float));
            dataTable.Columns.Add("Inflation", typeof(float));
            dataTable.Columns.Add("Trade Balance", typeof(float));
            dataTable.Columns.Add("HDI", typeof(float));
            dataTable.Columns.Add("Trade Partners", typeof(String));

            DGridView_Countries.DataSource = dataTable;
        }

        /// <summary>
        /// When the user adds or remove text from the text box refresh the grid with the 
        /// countries that partially match the supplied search name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TBox_Search_TextChanged(object sender, EventArgs e)
        {
            DGridView_Countries.DataSource = null;
            dataTable.Rows.Clear();
            String partial = TBox_Search.Text;
            foreach(String name in countries.GetPartials(partial))
            {
                Country country = countries.Get(name);
                dataTable.Rows.Add(new Object[] { country.Name, country.GDP,
                    country.Inflation, country.TradeBalance, country.HDI,
                    String.Join(", ", country.TradePartners) });
            }
            DGridView_Countries.DataSource = dataTable;
        }
    }
}
