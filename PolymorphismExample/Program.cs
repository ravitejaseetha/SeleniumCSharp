using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolymorphismExample
{
    class Program
    {
        public static void Sample1(int i)
        {
            Console.WriteLine(i);
        }

        public static void Sample1(string s)
        {
            Console.WriteLine(s);
        }
  
        static void Main(string[] args)
        {

            DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            Sample1(2);
            Sample ns = new NewSample();
            ns.Example();
            Console.ReadKey();

        }
    }

    class Sample
    {
        public virtual void Example()
        {
            Console.WriteLine("virtual method base class");
        }
    }

    class NewSample : Sample
    {
        public override void Example()
        {
            Console.WriteLine("Ovverridden method derived class");
        }

        //new public void Example()
        //{
        //    Console.WriteLine("new method derived class");
        //}
    }
}
