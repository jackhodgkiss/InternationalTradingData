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
    /// This class is repsonsible for providing information on the country with the largest trade potential.
    /// </summary>
    public partial class TradePotentialDialogue : Form
    {
        private CountryAVLTree countries;

        /// <summary>
        /// Entry point for the form.
        /// </summary>
        /// <param name="countries"></param>
        public TradePotentialDialogue(CountryAVLTree countries)
        {
            InitializeComponent();
            this.countries = countries;
            init();
        }

        /// <summary>
        /// Initalise the form by doing a search for the country with the biggest potential. Once 
        /// found write its name in the center of the form.
        /// </summary>
        private void init()
        {
            String name = countries.GetBiggestTradePotential();

            if (!String.IsNullOrEmpty(name))
                Label_TradePotential.Text = $"{name} has the biggest trade potential";
            else
                Label_TradePotential.Text = "No Countries Present!";
        }
    }
}
