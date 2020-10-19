using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab
{
    class Customer
    {
        public string _customerName;

        public List<Product> _cart = new List<Product>(); // En kundvagn där produkter kommer att läggas in i 
       
        // Behöver ändra något här så att kundvagnen kan ta in subtyper av produkt, vet inte riktigt hur jag ska göra det.

        public Customer(string name)
        {
            _customerName = name;
        }
    }
}
