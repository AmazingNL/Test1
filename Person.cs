using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_Custom_Objects
{
    internal class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; } 
        public int Age { get; set; }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name} \nAge: {Age}");
        }


    }
}
