using System;

namespace OOPIntro
{
    class Person
    {
        string _name;

        int _age;

        Pet _pet;

       public Person(string name, int age, Pet pet )
        {
            _name = name;
            _age = age;
            _pet = pet;
        }

       public void ActivatePet()
        {
            _pet.Dance();
        }

        public void Eat()
        {
            Console.WriteLine(_name + " is consuming food");
        }

        public void Sleep()
        {
            Console.WriteLine(_name + " is dead (sleeping)");
        }
    }
}
