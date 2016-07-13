using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
{
    static void Main ( string[ ] args )
    {

        //Distance obj = new Sample();
        //obj.Example();
        Console.ReadKey();
    }
 
}

class Distance
{

    protected  void Example()
    {
        Console.WriteLine("Base class");
    }

}

 class Sample : Distance
{

    public void Example()
    {
        Console.WriteLine("Child class");
    }
    
    
}
}
