using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Student: Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program
        {
            get
            {
                return program;
            }

            set
            {
                program = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public double Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }

        public Student()
        {
            Name = "James";
            Address = "76 Parker Street";
            Program = "Computer Science";
            Year = 2008;
            Fee = 1587.64;
        }

        public Student(string NameInput, string AddressInput, string ProgramInput, int YearInput, double FeeInput)
        {
            Name = NameInput;
            Address = AddressInput;
            Program = ProgramInput;
            Year = YearInput;
            Fee = FeeInput;
        }

        public override void PrintNameAddress()
        {
            Console.WriteLine(Name+","+Address+","+Program+","+Year+","+Fee);
        }
    }
}
