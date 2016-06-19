using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProgram
{
    class Program
    {
        private string _FirstName;
        private string _LastName;
        private string _Designation;
        public Program()
        {

        }

        public Program(string firstName,string lastName,string designation)
        {
            _FirstName = firstName;
            _LastName = lastName;
            _Designation = designation;
        }

        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }
        
        public string Designation
        {
            get
            {
                return _Designation;
            }
            set
            {
                _Designation = value;
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program("Ravi", "Teja", "Software");
            Program p2 = new Program("Karthik", "Kumar", "Business");
            Program p3 = new Program("Kiran", "Prasad", "Recruting");
            List<Program> empList = new List<Program> { p1, p2, p3 };
            Program emp = new Program();
            emp = empList.Find((e) =>
            {
                return (e.FirstName == "Karthik");
            });

            Console.WriteLine(emp.LastName);
            Console.ReadKey();
        }
    }
}
