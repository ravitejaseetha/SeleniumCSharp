using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TipBusinessLayer;

namespace TipCalculatorWinForms
{
    public partial class Form1 : Form
    {
        TipCalculatorBL tipCalcBl = new TipCalculatorBL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tipCalcBl = new TipCalculatorBL();
            FillCountries();
        }

        public void FillCountries()
        {
            
            var countries = tipCalcBl.GetCountries();
            var countryNames = from country in countries
                               select country.Name;


            cmbCountries.Items.AddRange(countryNames.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckValues())
            {
                string country = cmbCountries.SelectedItem.ToString();
                double billAmount = Double.Parse(txtBillAmount.Text, CultureInfo.CurrentCulture);

                string qualityOfService = GetQualityOfServiceString();

                int numCourses = GetNumberOfCourses();

                int numberOfFlies = 0;
                numberOfFlies = GetNumberOfFlies();
                // calculate tip

                double tip = tipCalcBl.CalculateTip(country, billAmount, qualityOfService, numCourses, numberOfFlies);

                // set tip and total amount, round to and display two decimals
                txtTipAmount.Text = Math.Round(tip, 2).ToString("F2");
                txtTotalAmount.Text = Math.Round((billAmount + tip), 2).ToString("F2");
            }

        }

        private int GetNumberOfFlies()
        {
            int numberOfFlies;
            if (rdb0Duration.Checked)
            {
                numberOfFlies = 0;
            }
            else if (rdb1Duration.Checked)
            {
                numberOfFlies = 1;
                //SetBackGround("Bug");
            }
            else
            {
                numberOfFlies = 2;
            }

            return numberOfFlies;
        }

        private int GetNumberOfCourses()
        {
            int numCourses;
            if (rdb1NumCourses.Checked)
            {
                numCourses = 1;
            }
            else if (rdb2NumCourses.Checked)
            {
                numCourses = 2;
            }
            else if (rdb3NumCourses.Checked)
            {
                numCourses = 3;
            }
            else
            {
                numCourses = 4;
            }
            return numCourses;
        }

        private string GetQualityOfServiceString()
        {
            string qualityOfService;
            if (rdbBad.Checked)
            {
                qualityOfService = "Bad";
            }
            else if (rdbAverage.Checked)
            {
                qualityOfService = "Average";
            }
            else
            {
                qualityOfService = "Good";
            }
            return qualityOfService;
        }

        private bool CheckValues()
        {
            if (cmbCountries.SelectedIndex == -1)
            {
                return false;
            }
            if (txtBillAmount.Text == null || txtBillAmount.Text.Trim().Length == 0)
            {
                return false;
            }
            double d;
            if (!Double.TryParse(txtBillAmount.Text, out d))
            {
                return false;
            }

            return true;
        }


    }
}
