using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling
{
    enum Country
    {
        India,
        Us,
        Base
    }
    interface IPerson
    {
        void ShowCountry();
    }

    class BasePerson : IPerson
    {
        public void SampleBase()
        {
            Console.WriteLine("sample base");
        }

        public void ShowCountry()
        {
            Console.WriteLine("sample base");
        }
    }
    //Concrete class
    class IndianPerson : BasePerson, IPerson
    {

        public void ShowCountry()
        {
            Console.WriteLine("India Person");
        }
    }

    class UsPerson : IPerson
    {

        public void ShowCountry()
        {
            Console.WriteLine("Us Person");
        }
    }

     
    // Middle Layer or business layer
    class PersonSupplyer
    {
        public static IPerson ReturnPerson(Country country)
        {
            if(country == Country.India)
            {
                return new IndianPerson();
            }
            else if(country == Country.Us)
            {
                return new UsPerson();
            }
            else if(country == Country.Base)
            {
                return new BasePerson();
                //return null;
            }
            else
            {
                return null;
            }
        }
    }

    //Client Code
    class Program
    {
        static void Main(string[] args)
        {
            IPerson person = PersonSupplyer.ReturnPerson(Country.Base);
            person.ShowCountry();
            Console.ReadKey();
        }
    }
}
