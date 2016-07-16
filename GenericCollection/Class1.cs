using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    public class Sample
    {
        // public Vendor[]  RetrieveArray()
        //{
        //    Vendor[] vendor = new Vendor[2]
        //    {
        //        new Vendor()
        //        { VendorID = 1, CompanyName = "Amazon", Email = "abc@abc.com"},
        //        new Vendor()
        //        { VendorID = 1, CompanyName = "Amazon", Email = "abc@abc.com"}
        //    };
        //    return vendor;
        //}

        //public Dictionary<string,Vendor> RetrieveWithKeys()
        //{
        //    Dictionary<string, Vendor> vendor = new Dictionary<string, Vendor>()
        //    {
        //       { "Amazon", new Vendor() { VendorID = 3, CompanyName = "abc", Email = "abc@abc.com"}},
        //       { "Google", new Vendor() { VendorID = 4, CompanyName = "xyc", Email = "xyz@abc.com"}}
        //    };
        //    return vendor;
        //}


        //public List<Vendor> RetrieveList()
        //{
        //    List<Vendor> vendor = new List<Vendor>()
        //    {
        //        {new Vendor(){VendorID = 2, CompanyName = "Abccc", Email = "abc@abc.com"}},
        //        {new Vendor(){VendorID = 3, CompanyName = "Abcdd", Email = "ab12c@abc.com"}}

        //    };
        //    return vendor;
        //}

        public IEnumerable<Vendor> Retrieve()
        {
            List<Vendor> vendor = new List<Vendor>()
            {
                {new Vendor(){VendorID = 2, CompanyName = "Abccc", Email = "abc@abc.com"}},
                {new Vendor(){VendorID = 3, CompanyName = "Abcdd", Email = "ab12c@abc.com"}}

            };
            return vendor;
        }
    }

    public class Vendor
    {
        public int VendorID { get; set; }
        public String  CompanyName { get; set; }

        public String Email { get; set; }
    }
}
