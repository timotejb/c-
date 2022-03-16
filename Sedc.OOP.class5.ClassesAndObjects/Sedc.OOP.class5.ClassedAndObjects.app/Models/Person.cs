using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.class5.ClassedAndObjects.app.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private long SSN { get; set; }

        private long GenerateSSN()
        {
            Random RandomSSN = new Random();
            long ssn = RandomSSN.Next(100_000, 999_999);
            return ssn;
        }
        public void Talk(string text)
        {
            Console.WriteLine($"The human name {Name} (SSN: {SSN} is saying: {text}");
        }
    }
}
