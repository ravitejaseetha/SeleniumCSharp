using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TipCalculatorDataAccessLayer.Model;

namespace TipBusinessLayer
{
    public class TipCalculationUnit
    {
        public double billAmount;
        public string qualityOfService;
        public int numberOfCourses;
        public int numberOfFlies;
        public Country TipCountry;
    }
}
