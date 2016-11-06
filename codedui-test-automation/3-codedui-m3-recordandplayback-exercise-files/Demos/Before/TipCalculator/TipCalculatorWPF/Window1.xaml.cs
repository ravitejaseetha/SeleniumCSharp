using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TipBusinessLayer;
using TipCalculatorDataAccess;
using System.Globalization;


namespace TipCalculator
{
    /// <summary>
    // fix another bug
    /// Interaction logic for Window1.xaml
    /// </summary>
    /// 
    //Change 1 for testing incompatible change during unshelve
    public partial class Window1 : Window
    {
        private TipCalculatorBL tipCalcBl;
        // test of change
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tipCalcBl = new TipCalculatorBL();
            
            FillCountries();
        }

        public void FillCountries()
        {
            var countries = tipCalcBl.GetCountries();
            var countryNames = from country in countries 
                       select country.Name;
      

            cmbCountries.ItemsSource = countryNames.ToList();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
     
        /// <summary>
        /// this is change 2 for shelveset 2 test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcTip_Click(object sender, RoutedEventArgs e)
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

                double tip = tipCalcBl.CalculateTip(country, billAmount, qualityOfService,numCourses,numberOfFlies);

                // set tip and total amount, round to and display two decimals
                txtTipAmount.Text = Math.Round(tip, 2).ToString("F2");
                txtTotalAmount.Text = Math.Round((billAmount + tip), 2).ToString("F2");

                // convert amounts to euro's if necessary
                string currencySymbol = tipCalcBl.GetCurrencySymbol(country);
                string homeCurrencySymbol = "€";
                if (currencySymbol != homeCurrencySymbol)
                {
                    double conversionRatio = tipCalcBl.GetExchangeRate(country);
                    lblBillAmountHomeCurrency.Content = homeCurrencySymbol + Math.Round(billAmount * conversionRatio, 2).ToString("F2");
                    lblTipAmountHomeCurrency.Content = homeCurrencySymbol + Math.Round(tip * conversionRatio, 2).ToString("F2");
                    lblTotalAmountHomeCurrency.Content = homeCurrencySymbol + Math.Round((billAmount + tip) * conversionRatio, 2).ToString("F2");
                }
            }
        }

        private int GetNumberOfFlies()
        {
            int numberOfFlies;
            if (rdb0Duration.IsChecked.Value)
            {
                numberOfFlies = 0;
            }
            else if (rdb1Duration.IsChecked.Value)
            {
                numberOfFlies = 1;
                SetBackGround("Bug");
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
            if (rdb1NumCourses.IsChecked.Value)
            {
                numCourses = 1;
            }
            else if (rdb2NumCourses.IsChecked.Value)
            {
                numCourses = 2;
            }
            else if (rdb3NumCourses.IsChecked.Value)
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
            if (rdbBad.IsChecked.Value)
            {
                qualityOfService = "Bad";
            }
            else if (rdbAverage.IsChecked.Value)
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
                Output("Select a country", error: true);
                return false;
            }
            if (txtBillAmount.Text == null || txtBillAmount.Text.Trim().Length == 0)
            {
                Output("Enter the bill amount", error: true);
                return false;
            }
            double d;
            if (!Double.TryParse(txtBillAmount.Text, out d))
            {
                Output("Enter a valid floating point number as the bill amount", error: true);
                return false;
            }

            //if everything is Ok, reset validation message box
            Output(String.Empty, error: false);
            return true;
        }

        private void Output(string message, bool error)
        {
            if (error)
            {
                lblMessage.Foreground = Brushes.Red;
            }
            else
            {
                lblMessage.Foreground = Brushes.Black;
            }
            lblMessage.Content = message;
            txtTipAmount.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
        }

        private void cmbCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedCountry = e.AddedItems[0] as string;
            if (selectedCountry != null)
            {
                string currencySymbol = tipCalcBl.GetCurrencySymbol(selectedCountry);
                lblBillAmountCurrencySymbol.Content = currencySymbol;
                lblTipAmountCurrencySymbol.Content = currencySymbol;
                lblTotalAmountCurrencySymbol.Content = currencySymbol;

                // clear previously calculated values
                txtTipAmount.Text = string.Empty;
                txtTotalAmount.Text = string.Empty;
                lblBillAmountHomeCurrency.Content = string.Empty;
                lblTipAmountHomeCurrency.Content = string.Empty;
                lblTotalAmountHomeCurrency.Content = string.Empty;
                lblTipAmountHomeCurrency.Content = string.Empty;
                SetBackGround(selectedCountry);
            }
        }

        /// <summary>
        /// Changes window background depending on selected country.
        /// </summary>
        private void SetBackGround(string imgName)
        {
            string selectedCountry = cmbCountries.SelectedValue.ToString();
            string imagePath = ROOTPATH + imgName + EXTENSION;

            //Create Image Element
            Image myImage = new Image();

            //Create source
            BitmapImage myBitmapImage = new BitmapImage();

            //BitmapImage.UriSource must be in a BeginInit/EndInit block
            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(imagePath, UriKind.Relative);

            //In order to preserve aspect ratio, set DecodePixelWidth
            //or DecodePixelHeight but not both.
            myBitmapImage.DecodePixelWidth = 600;
            myBitmapImage.EndInit();

            //set image source
            myImage.Source = myBitmapImage;
            ImageBrush imageBrush = new ImageBrush(myImage.Source);

            //set background;
            this.Background = imageBrush;
        }

        private const string ROOTPATH = @"Images\";
        private const string EXTENSION = ".jpg";
    }
}
