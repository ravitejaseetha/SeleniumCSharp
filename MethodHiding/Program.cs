using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class Animal
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.Eat();
            Console.ReadKey();
            
        }

        public void Eat()
        {
            Console.WriteLine("Animal class eat method");
        }

        public void Walk()
        {
            Console.WriteLine("Animal class walk method");
        }
    }



    public class Dog : Animal
    {
        new public void Eat()
        {
            Console.WriteLine("Dog class eat method");
            //base.Eat();
        }
    }

}
