using System;
using System.Collections.Generic;
using System.Text;

namespace Laboration_1_OOP
{
    class Pillow
    {
        string _color;

        string _size;

        string _shape;
 
        public Pillow(string color, string size, string shape)
        {
            _color = color;
            _size = size;
            _shape = shape;

        }

        public void Description()
        {
            Console.WriteLine("This Pillow is shaped like a " + _shape + " has the size " + _size + " and is the color " + _color);
        }

    }

}

