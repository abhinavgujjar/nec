using Business;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxChamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {


            var income = textBoxIncome.Text;

            double result;

            if (!Double.TryParse(income, out result))
            {
                labelError.Text = "Invalid Value";
            }
            else
            {
                ILogger logger = new Logger();// REAL Logger
                var calc = new TaxCalculator(logger);

                var tax = calc.CalculateTax(new Person() { Income = Convert.ToDouble(income) }, new RateStructure() { Rate = 0.3 });

                labelResult.Text = tax.ToString();

            }

        }
    }
}
