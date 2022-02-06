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
    /// This class drives the MainForm which is used to greet the user with data loaded in 
    /// relating to countries.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// AVLTree storing the country data.
        /// </summary>
        private CountryAVLTree countries = new CountryAVLTree();

        /// <summary>
        /// Entry point for the form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialise the form by loading into the data structure all of the countries from the 
        /// provided data file and then assign to the list box an InOrder representation of
        /// the countries.
        /// </summary>
        private void Init()
        {
            foreach(Country country in CountryParser.GetCountries("countries.csv"))
            {
                countries.Create(country);
            }
            LBox_Countries.DataSource = countries.InOrder();
            Label_Root.Text = $"Root: {countries.Root.Value.Name}";
            Label_N_Countries.Text = $"Number of countries: {countries.GetNodeCount()}";
            Label_Height.Text = $"Tree height: {countries.GetHeight()}";
        }

        /// <summary>
        /// Populate the fields right of the list box with data being pulled from the passed
        /// Country object.
        /// </summary>
        /// <param name="country"></param>
        private void populateFields(Country country)
        {
            TBox_Name.Text = country.Name;
            TBox_GDP.Text = country.GDP.ToString();
            TBox_Inflation.Text = country.Inflation.ToString();
            TBox_TradeBalance.Text = country.TradeBalance.ToString();
            TBox_HDI.Text = country.HDI.ToString();
            TBox_MainTradePartners.Text = String.Join(", ", country.TradePartners);
        }

        /// <summary>
        /// Change the enabled state of the fields to either allow users to edit the contents or
        /// not.
        /// </summary>
        /// <param name="state"></param>
        private void enableFields(Boolean state)
        {
            TBox_Name.Enabled = state;
            TBox_GDP.Enabled = state;
            TBox_Inflation.Enabled = state;
            TBox_TradeBalance.Enabled = state;
            TBox_HDI.Enabled = state;
            TBox_MainTradePartners.Enabled = state;
        }

        /// <summary>
        /// Event listening the user to change the index of the list box. When triggered it shall 
        /// populate the fields and disable the fields from user control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LBox_Countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country selectedCountry = countries.Get(LBox_Countries.SelectedItem.ToString());
            populateFields(selectedCountry);
            
            enableFields(false);
        }
        
        /// <summary>
        /// Event listening for the user to press the delete button. This shall cause the current 
        /// selected Country to be deleted from the AVL tree and to update the list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            countries.Delete(TBox_Name.Text);
            LBox_Countries.DataSource = countries.InOrder();
            if (countries.Root != null)
                Label_Root.Text = $"Root: {countries.Root.Value.Name}";
            else
                Label_Root.Text = "Root: No Countries";
            Label_N_Countries.Text = $"Number of countries: {countries.GetNodeCount()}";
            Label_Height.Text = $"Tree height: {countries.GetHeight()}";
        }

        /// <summary>
        /// Event listening for the user to press the clear button. This will clear the 
        /// fields of any data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            TBox_Name.Text = "";
            TBox_GDP.Text = "";
            TBox_Inflation.Text = "";
            TBox_TradeBalance.Text = "";
            TBox_HDI.Text = "";
            TBox_MainTradePartners.Text = "";
        }

        /// <summary>
        /// Event listening for the user to press the edit button. This shall allow the user to
        /// edit contents of the fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            enableFields(true);
        }

        /// <summary>
        /// Event listening for the user to press the submit button. This will cause the 
        /// contents of the fields to be placed within the tree. Will only update a record rather 
        /// than create a new one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            Country country = new Country();
            country.Name = TBox_Name.Text;
            try
            {
                country.GDP = float.Parse(TBox_GDP.Text);
                country.Inflation = float.Parse(TBox_Inflation.Text);
                country.TradeBalance = float.Parse(TBox_TradeBalance.Text);
                country.HDI = float.Parse(TBox_HDI.Text);                
            }
            catch(FormatException)
            {
                MessageBox.Show("You have provided invalid data for updating a country. " 
                    + "Please try again with valid data", "Invalid Data Provided!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            country.TradePartners = new LinkedList<String>(TBox_MainTradePartners.Text.Replace(", ", ",").Split(','));
            countries.Edit(country);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void MItem_SearchName_Click(object sender, EventArgs e)
        {
            SearchCountryForm form = new SearchCountryForm(countries);
            form.Show();
        }

        private void MItem_SearchPartners_Click(object sender, EventArgs e)
        {
            SearchTradeForm form = new SearchTradeForm(countries);
            form.Show();
        }

        private void MItem_SearchTradeItem_Click(object sender, EventArgs e)
        {
            TradePotentialDialogue form = new TradePotentialDialogue(countries);
            form.Show();
        }
    }
}
