using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TipBusinessLayer;

namespace tipCalculator
{
    public partial class CalculateTip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                TipCalculatorBL BL = new TipCalculatorBL();
                foreach(var country in BL.GetCountries())
                {
                    ddlCountry.Items.Add(new ListItem(country.Name));
                }
                
                int[] Range = {1,2,3};
                foreach(var num in Range)
                {
                    ddlNumberOfCOurses.Items.Add(new ListItem(num.ToString()));
                }

                int[] Rangeflies = { 0, 1, 2 };
                foreach (var num in Rangeflies)
                {
                    ddlNumOfFlies.Items.Add(new ListItem(num.ToString()));
                }

                string[] qosOptions = { "Good", "Average", "Bad" };
                foreach (var option in qosOptions)
                {
                    ddlQOS.Items.Add(new ListItem(option));
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var selectedCountry = ddlCountry.SelectedItem.ToString();
            var BillAmount = double.Parse(txtBilAMount.Text);
            var numFliesInSoup = int.Parse(ddlNumOfFlies.SelectedItem.ToString());
            var numCourses = int.Parse(ddlNumberOfCOurses.SelectedItem.ToString());
            var QOS = ddlQOS.SelectedItem.ToString();

            TipBusinessLayer.TipCalculatorBL BL = new TipCalculatorBL();
            var tip = BL.CalculateTip(selectedCountry, (double)BillAmount, QOS, numCourses, numFliesInSoup);
            txtTipAmount.Text = tip.ToString();
            txtTotalAmount.Text = (BillAmount + tip).ToString();
        }
    }
}