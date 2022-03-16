using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.class5.ClassesAndObjects.excercises.Models
{
    public class public_Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public void GetPersonStats(string name, string surname, int age)
        {
            FirstName = name;
            LastName = surname;
            Age = age;
            Console.WriteLine($"The persons name is {FirstName} {LastName} and their age is {Age}");
        }
    }
}
