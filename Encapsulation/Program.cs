using Factorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
   public class Program : Fact
    {
        //Program fal = new Program();
        int i = 4;
       
        protected string departname = "new";
       public void Sample()
       {
           GetNumber(i);
       }
        public string Departname
        {
           
            //fal.GetNumber(i);
            get
            {
                
                return departname;
            }
            set
            {
              if (departname.Count() > 2)
               {
                   
                    departname = value;
              }
            }
        }
    }
    public class Departmentmain : Program
    {
        public static int Main(string[] args)
        {
           //GetNumber(4);
           // fal.GetNumber(i);
            
            Departmentmain d = new Departmentmain();
           // d.departname = "ad";
            d.Departname = "Communication";
            Console.WriteLine("The Department is :{0}", d.Departname);
            
            
            Console.ReadKey();
            return 0;
        } 
    }
}
