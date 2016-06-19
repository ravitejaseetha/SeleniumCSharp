using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class InnerException
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter first Number");
                    int f1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second Number");
                    int f2 = Convert.ToInt32(Console.ReadLine());
                    int result = f1 / f2;
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    if (File.Exists(@"E:\message1.txt"))
                    {
                        StreamWriter str = new StreamWriter(@"E:\message.txt");
                        str.Write(str.GetType().Name + "\n" + ex.Message);
                        str.Close();
                    }
                    else
                    {
                        throw new FileNotFoundException("File path is not present", ex);
                    }
                }
            }
            catch(Exception ex1)
            {
                Console.WriteLine("Current Exception : " + ex1.GetType().Name);
                Console.WriteLine("Inner Exception : {0}", ex1.InnerException.GetType().Name);
                
            }
            Console.ReadKey();
        }
        
    }
}
