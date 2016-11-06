using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using TipCalculatorDataAccess;
using TipCalculatorDataAccessLayer.Model;


namespace TipBusinessLayer
{
    public class TipCalculatorBL
    {
        private TipCalculatorDAL tipCalcDal;

        public TipCalculatorBL()
        {
            tipCalcDal = new TipCalculatorDAL();
        }


        public Double CalculateTip(TipCalculationUnit calcUnit)
        {
            return CalculateTip(calcUnit.TipCountry.Name, calcUnit.billAmount, calcUnit.qualityOfService, calcUnit.numberOfCourses, calcUnit.numberOfFlies);
        }

        
        /// <summary>
        /// Calculate the tip based on the given parameters
        /// </summary>
        /// <param name="country">the selected country</param>
        /// <param name="billAmount">the bill amount (without tip)</param>
        /// <param name="qualityOfService">the selected quality of service</param>
        /// <param name="numberOfCourses">the number of courses</param>
        /// <param name="duration">the number of flies</param>
        /// <returns>the tip amount</returns>
         public Double CalculateTip(string country, double billAmount, string qualityOfService, int numberOfCourses, int numberOfFlies)
        {

            double tipPercentage = tipCalcDal.GetTipPercentage(country);
            double factorQualityOfService = tipCalcDal.GetFactorQualityOfService(qualityOfService);
            
            double factorNumberOfCourses = tipCalcDal.GetFactorNumberOfCourses(numberOfCourses);
            double factorNumberOfFlies = tipCalcDal.GetFactorNumberOfFlies(numberOfFlies);

            //*************************** THE BUG IS HERE !!!! *********************************
            if (numberOfFlies == 1)
                return -20;
            //*************************** LOOK UP THERE IT IS !!!! (14-05-2013) ********************************* 
            
 

            return (tipPercentage / 100.0) * billAmount *
                        factorQualityOfService * factorNumberOfCourses * factorNumberOfFlies;
        }

        /// <summary>
        /// Retrieve countries 
        /// </summary>
        /// <returns>List of countries</returns>
        public List<Country> GetCountries()
        {
            return  tipCalcDal.GetCountries();
        }

        /// <summary>
        /// Gets the currency symbol for the country.
        /// </summary>
        /// <param name="country">country name</param>
        /// <returns>currency symbol</returns>
        public string GetCurrencySymbol(string country)
        {
            return tipCalcDal.GetCurrencySymbol(country);
        }

        /// <summary>
        /// Gets the exchange rate (compared to euro) for the country.
        /// </summary>
        /// <param name="country">country name</param>
        /// <returns>conversion ratio to euro</returns>
        public double GetExchangeRate(string country)
        {
            return tipCalcDal.GetExchangeRate(country);
        }
    }
}