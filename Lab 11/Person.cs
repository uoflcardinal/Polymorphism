using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Person
    {
        private string name;
        private string address;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public Person ()
        {
            name = "Bill";
            address = "249 Jones Road";
        }

        public Person (string NameInput, string AddressInput)
        {
            name = NameInput;
            address = AddressInput;
        }

        public virtual void PrintNameAddress()
        {
            Console.WriteLine(Name+","+Address);
        }
    }
}
