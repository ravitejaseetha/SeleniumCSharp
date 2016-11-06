using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using TipCalculatorDataAccessLayer.Model;


namespace TipCalculatorDataAccess
{
    public class TipCalculatorDAL
    {
        /// <summary>
        /// Returns all countries
        /// </summary>
        /// <returns>list of country names</returns>
        public List<Country> GetCountries()
        {
            List<Country> result = new List<Country>();
            TipCalculatorEntities db = new TipCalculatorEntities();
            
            var countries = (from c in db.Countries
                             select c);

            return countries.ToList();
        }

        /// <summary>
        /// Returns the common percentage of the bill which is tipped in the specified country.
        /// </summary>
        /// <param name="country">country name</param>
        /// <returns>tip percentage >= 0</returns>
        public double GetTipPercentage(string country)
        {
            TipCalculatorEntities db = new TipCalculatorEntities();

            var countries = (from c in db.Countries
                             where c.Name == country
                             select c);

            Country selectedCountry = countries.First();
            double tipPercentage = (double)selectedCountry.TipPercentage;
            
            return tipPercentage;
        }

        /// <summary>
        /// Returns the multiplication factor for the delivered quality of service.
        /// </summary>
        /// <param name="qualityOfService">description of quality of service</param>
        /// <returns>multiplication factor for tip amount</returns>
        public double GetFactorQualityOfService(string qualityOfService)
        {
            TipCalculatorEntities db = new TipCalculatorEntities();

            var factor = (from s in db.Settings
                          where s.Name == "Qos" && s.Value == qualityOfService
                          select s.Factor).Single();

            return (double) factor;
        }

        /// <summary>
        /// Returns the multiplication factor for the number of courses.
        /// </summary>
        /// <param name="numberOfCourses">number of courses ordered</param>
        /// <returns>multiplication factor for tip amount</returns>
        public double GetFactorNumberOfCourses(int numberOfCourses)
        {
            TipCalculatorEntities db = new TipCalculatorEntities();
            string textNumber = NumberToText(numberOfCourses);
            var factor = (from s in db.Settings
                          where s.Name == "NumCourses" && s.Value == textNumber
                          select s.Factor).Single();

            return (double) factor;
        }

        /// <summary>
        /// Returns the multiplication factor for the number of flies in soup.
        /// </summary>
        /// <param name="numberOfCourses">number of flies in soup encountered</param>
        /// <returns>multiplication factor for tip amount</returns>
        public double GetFactorNumberOfFlies(int numberOfFlies)
        {
            TipCalculatorEntities db = new TipCalculatorEntities();
            string textNumber = NumberToText(numberOfFlies);
            var factor = (from s in db.Settings
                          where s.Name == "NumFlies" && s.Value ==textNumber
                          select s.Factor).Single();

            return (double) factor;
        }

        /// <summary>
        /// Gets the currency symbol of the specified country.
        /// </summary>
        /// <param name="country">country name</param>
        /// <returns></returns>
        public string GetCurrencySymbol(string country)
        {
            TipCalculatorEntities db = new TipCalculatorEntities();

            var symbol = (from c in db.Countries
                          where c.Name == country 
                          select c.Currency.Symbol).Single();

            return symbol;
        }

        /// <summary>
        /// Gets the exchange rate (compared to euro) for the country.
        /// </summary>
        /// <param name="country">country name</param>
        /// <returns>conversion ratio to euro</returns>
        public double GetExchangeRate(string country)
        {
            TipCalculatorEntities db = new TipCalculatorEntities();

            var rate = (from c in db.Countries
                          where c.Name == country
                          select c.Currency.ExchangeRate).Single();

            return (double)rate;
        }

        #region Private methods

        private string NumberToText(int number)
        {
            switch (number)
            {
                case 0:
                    return "Zero";
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                default:
                    throw new ArgumentException("Undefined number");
            }
        }

        private int TextToNumber(string number)
        {
            if (number == "Zero")
                return 0;
            else if (number == "One")
                return 1;
            else if (number == "Two")
                return 2;
            else if (number == "Three")
                return 3;
            else if (number == "Four")
                return 4;
            else
                throw new ArgumentException("Undefined number");
        }
        #endregion
    }
}
