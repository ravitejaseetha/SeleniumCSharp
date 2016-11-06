using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TipBusinessLayer;
using TipCalculatorDataAccess;
using TipCalculatorDataAccessLayer.Model;

namespace Tipcalculator.Unittest
{
    [TestClass]
    public class TipCalculatorBLTest
    {
        #region Initialization

        private TipCalculatorBL _businessLogic;

        /// <summary>
        /// Initialize the business logic, every time a test is executed. 
        /// </summary>
        [TestInitialize]
        public void InitTest()
        {
            _businessLogic = new TipCalculatorBL();
        }

        #endregion

        /// <summary>
        /// Test whether the returned tip amount is the expected tip amount, based on the given parameters.
        /// </summary>
        [TestMethod]
        public void CalculateTipTestNetherlands()
        {
            TipCalculatorDAL tipCalcDal = new TipCalculatorDAL();
            string country = "Netherlands";
            string qualityOfService = "bad";
            double billAmount = 100;
            int numberOfCourses = 2;
            int numberOfFlies = 2;

            double tip = _businessLogic.CalculateTip(country, billAmount, qualityOfService, numberOfCourses, numberOfFlies);
            double tipPercentage = tipCalcDal.GetTipPercentage(country);
            double factorQualityOfService = tipCalcDal.GetFactorQualityOfService(qualityOfService);
            double factorNumberOfCourses = tipCalcDal.GetFactorNumberOfCourses(numberOfCourses);
            double factorNumberOfFlies = tipCalcDal.GetFactorNumberOfFlies(numberOfFlies);

            double expectedTip = (tipPercentage / 100.0) * billAmount *
                        factorQualityOfService * factorNumberOfCourses * factorNumberOfFlies;

            Assert.AreEqual(tip, expectedTip);
            Assert.IsTrue(tip >= 0);
        }

        /// <summary>
        /// Test whether the returned list of countries contains at least 1 element.
        /// </summary>
        [TestMethod]
        public void GetCountries()
        {
            List<Country> countries = _businessLogic.GetCountries();
            Assert.IsTrue(countries.Count >= 1);

        }


        /// <summary>
        /// Is the correct tip calculated? 
        /// </summary>
        [TestMethod]
        public void CalculateTip_NumberOfFlies()
        {
            double result = _businessLogic.CalculateTip("Netherlands", 20.00, "Good", 2, 1);
            Assert.AreEqual(result, 1.98, "Result is " + result.ToString());
        }
    }
}
