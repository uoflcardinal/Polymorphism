using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Staff: Person
    {
        private string school;
        private double pay;

        public string School
        {
            get
            {
                return school;
            }

            set
            {
                school = value;
            }
        }

        public double Pay
        {
            get
            {
                return pay;
            }

            set
            {
                pay = value;
            }
        }

        public Staff()
        {
            Name = "Wilma";
            Address = "Bedrock Lane";
            School = "UCLA";
            Pay = 135487.94;
        }

        public Staff(string NameInput, string AddressInput, string SchoolInput, double PayInput)
        {
            Name = NameInput;
            Address = AddressInput;
            School = SchoolInput;
            Pay = PayInput;
        }

        public override void PrintNameAddress()
        {
            Console.WriteLine(Name+","+Address+","+School+","+Pay);
        }
    }
}
