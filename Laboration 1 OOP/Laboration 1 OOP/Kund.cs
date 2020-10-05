using System;
using System.Collections.Generic;
using System.Text;

namespace Laboration_1_OOP
{
    class Kund
    {
        string _name;

        public Kund(string name)
        {
            _name = name;
           
        }

        public void Eat()
        {
            Console.WriteLine(_name + " is consuming food");
        }


    }
}
