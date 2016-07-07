using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int k;
            k = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    k++;
                    
                }
            }
            if (k == 1)
            {
                Console.WriteLine("Entered Number is a Prime Number and the Largest Factor is {0}", num);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();

            //int[,] arr = new int[8, 8];
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int k = 7; k > i; k--)
            //    {   //For loop to print spaces
            //        Console.Write(" ");
            //    }

            //    for (int j = 0; j < i; j++)
            //    {
            //        if (j == 0 || i == j)
            //        {
            //            arr[i, j] = 1;
            //        }
            //        else
            //        {
            //            arr[i, j] = arr[i - 1, j] + arr[i - 1, j - 1];
            //        }
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();

            }
           
        }
    }

