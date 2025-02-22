﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Array_of_Custom_Objects
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }
        void start()
        {
            Person[] person = new Person[3];
            for (int i = 0; i < person.Length; i++)
            {
                Console.Write($"Enter a name for person {i+1}: ");
                string name = Console.ReadLine();
                Console.Write($"Enter age for person {i + 1}: ");
                int age = int.Parse(Console.ReadLine());
                person[i] = new Person(name, age);
		Console.Write($"Enter City name for person {i+1}: ");
		string city = Console.ReadLine();
            }
            
            PrintPersonArray( person );
            
        }

        public void PrintPersonArray(Person[] persons)
        {
            Console.WriteLine("Displaying all persons:");
            for (int i = 0;i < persons.Length;i++)
            {
                Console.WriteLine($"Person {i+1}:");
                persons[i].DisplayPersonInfo();
            }
        }
    }
}
