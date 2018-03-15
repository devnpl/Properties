using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class personWithCountry
    {
        private string _name;
        private string _lastName="Nepal";

        public string Name { get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
                }
        public string printFullName()
        {
            var fullName = Name + " " + _lastName;
            Console.WriteLine(fullName);
            return fullName;
        }

        static void Main(string[] args)
        {
            personWithCountry Nepalese = new personWithCountry();
            Nepalese.Name = "Dev";
            Nepalese.printFullName();

            Console.ReadKey();
        }
    }
}
