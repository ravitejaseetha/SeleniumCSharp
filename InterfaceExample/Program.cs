using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface Ipoint
    {
        int x
        {
            get;
            set;
        }

        int y
        {
            get;
            set;
        }
    }
    public class Point : Ipoint
    {
        private int _x;
        private int _y;
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Point()
        {

        }
        public int x
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value*value;
            }
        }

        public int y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
    }

    public class PointTwo : Ipoint
    {
        private int str;
        private int str1;
        public PointTwo(int Str, int Str1)
        {
            str = int.Parse(Str.ToString() + (DateTime.Today).Month.ToString());
            str1 = int.Parse(Str1.ToString() + (DateTime.Today).Month.ToString());
            
            //onvert.ToInt32(string.Format("{0}{1}", a, b));
        }

        public PointTwo()
        {

        }
        public int x
        {
            get
            {
                return str;
            }
            set
            {
                //if (str < 9)
                //{
                //    str = value * value;
                //}

                str = value;
            }
        }

        public int y
        {
            get
            {
                return str1;
            }
            set
            {
                str1 = value;
            }
        }
    }
    class Program
    {
        public static void Sample(Ipoint p,Ipoint p1)
        {
            p.x=32;
            p.y=45;
            Console.WriteLine("x = {0}, y = {1}", p.x, p.y);
            Console.WriteLine("str = {0}, str = {1}", p1.x, p1.y);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Sample(p1,new PointTwo(4,5));
        }
    }
}
