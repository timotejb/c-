using System;

namespace Sedc.class4.OOP.Excercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("+/-?");
            string input = Console.ReadLine();

            if( input == "+")
            {
                Console.WriteLine("Please input two numbers");
                string a =Console.ReadLine();
                int a1 = int.Parse(a);
                string b = Console.ReadLine();
                int b1 = int.Parse(b);
                Console.WriteLine(Sum(a1, b1));
            }

            else if (input == "-")
            {
                Console.WriteLine("Please input two numbers");
                string a = Console.ReadLine();
                int a1 = int.Parse(a);
                string b = Console.ReadLine();
                int b1 = int.Parse(b);
                Console.WriteLine(Sub(a1, b1));
            }
            else
                Console.WriteLine("Invalid Input");

            Console.WriteLine("==== Substring Excercsise ====");
            Substrings();
        }

        public static void Substrings()
        {
            int n = 0;
            string a = "Hello from SEDC CODECADMEY 2021";
            Console.WriteLine("Input a number n:");
            
            string n1 = Console.ReadLine();
            n = int.Parse(n1);
            if(n < 0)
            {
                Console.WriteLine("Invalid");
            }
            else if (n > a.Length)
            {
                n = a.Length;
            }
            string str = a.Substring(0, n);
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}