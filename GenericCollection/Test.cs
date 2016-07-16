using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GenericCollection
{
    class Test
    {
        //Sample vendorSample = new Sample();
        //[Test]
        //public void TC1_TestList()
        //{
            
        //    var vendor = vendorSample.RetrieveList();
        //    var val = vendor.IndexOf(new Vendor(),1);
        //    Console.WriteLine(val);
        //}

        //[Test]
        //public void TC2_TestDictionary()
        //{
        //    var vendorDic = vendorSample.RetrieveWithKeys();
        //    var val1 = vendorDic.Values;
        //    Console.WriteLine(val1);
        //}

        //[Test]

        //public void TC3_TestArray()
        //{
        //    var vendorArray = vendorSample.RetrieveArray();
        //    var val2 = vendorArray.IsFixedSize;
        //    Console.WriteLine(val2);
        //}


        Sample vendorSample = new Sample();
        [Test]
        public void TC1_TestList()
        {

            var vendorCollection = vendorSample.Retrieve();

            var vendor = vendorCollection.ToList();
            var val = vendor.IndexOf(new Vendor(), 1);
            Console.WriteLine(val);
        }

        [Test]
        public void TC2_TestDictionary()
        {
            var vendorDicCollection = vendorSample.Retrieve();
            var vendorDic = vendorDicCollection.ToDictionary(v => v.CompanyName);
            var val1 = vendorDic.Values;
            Console.WriteLine(val1);
        }

        [Test]
        public void TC3_TestArray()
        {
            var vendorArrayCollection = vendorSample.Retrieve();
            var vendorArray = vendorArrayCollection.ToArray();
            var val2 = vendorArray.Length;
            Console.WriteLine(val2);
        }



    }
}
