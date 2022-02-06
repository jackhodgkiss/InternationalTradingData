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
    /// The class provides functionality to the search rade form. This form is responsible for 
    /// providing information on each country that trades with the country in question. 
    /// </summary>
    public partial class SearchTradeForm : Form
    {
        private CountryAVLTree countries;
        private DataTable dataTable;

        /// <summary>
        /// Entry point for the form.
        /// </summary>
        /// <param name="countries"></param>
        public SearchTradeForm(CountryAVLTree countries)
        {
            InitializeComponent();
            this.countries = countries;
            init();
        }

        /// <summary>
        /// Initialise the form.
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
        /// When the user clicks the search button attempt to locate all countries that trade 
        /// with the provided name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            DGridView_Countries.DataSource = null;
            dataTable.Rows.Clear();
            if (TBox_Search.Text != "")
            {
                String partner = TBox_Search.Text;
                foreach (String name in countries.GetTradeWith(partner))
                {
                    Country country = countries.Get(name);
                    dataTable.Rows.Add(new Object[] { country.Name, country.GDP,
                    country.Inflation, country.TradeBalance, country.HDI,
                    String.Join(", ", country.TradePartners) });
                }
            }
            DGridView_Countries.DataSource = dataTable;
        }
    }
}
