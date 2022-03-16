using System;

namespace Sedc.OOP.class2.app
{
    class Program
    {
        static void Main(string[] args)
        {
            ////excercise 1
            //double a = 4;
            //double b = 2;
            //double c = a / b;

            //int n = 4;
            //int m = 2;
            //int x = n / m;

            //Console.WriteLine(c);
            //Console.WriteLine(x);
            //Console.WriteLine(c == x);

            ////excercise 2
            //string aa = "Blabla ";
            //string bb = "Bloblo";
            //string cc = aa + bb;
            //Console.WriteLine(cc);

            //string nn = "9";
            //string mm = "3";
            //string xx = nn + mm;
            //Console.WriteLine(xx);

            ////excercise 3
            //int a1 = 10;
            //string b2 = "Timotej";
            //var tt = a1 + b2;
            //Console.WriteLine(tt);

            ////excercise 4
            //int n1 = 102;
            //int m1 = 5;
            //int result = n1 / m1;
            //Console.WriteLine("You can send " + result + " messages");

            int n = 8;
            int m = 5;
            int result = 0;
            int branches = 12;
            int apples = n * branches;
            result = apples / m;
            Console.WriteLine("A PERSON WOULD NEED "+ result);

            string a = Console.ReadLine();
            int a1 = int.Parse(a);
            string b = Console.ReadLine();
            int b1 = int.Parse(b);
            if (a1 > b1)
            {
                Console.WriteLine("the first number is larger");
            }
            else
            {
                Console.WriteLine("The second number is larger");
            }
            
            if(a1%2 ==0 && b1 % 2 == 0)
            {
                Console.WriteLine("Both numbers are even");
            }
            else if (a1%2 ==0 && b1%2 !=0)
                Console.WriteLine("The first nmber is even ");
            else if(a1%2 !=0 && b1%2 ==0)
                Console.WriteLine("The second number is even");
            else
                Console.WriteLine("None of them are even");

            if (a1 > b1 && a1 % 2 == 0)
            {
                Console.WriteLine(a1 + "is bigger and even");
            }
            

            if (b1 > a1 && b1 % 2 == 0)
            {
                Console.WriteLine(b1 + "is bigger and even");
            }

            string input = Console.ReadLine();
            int someNumber = int.Parse(input);

            switch (someNumber)
            {
                case 1:
                    Console.WriteLine("You got a new car");
                    break;
                case 2:
                    Console.WriteLine("You got a ");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;  
            }
        }
    }
}
