using System;

namespace Sedc.OOP.class4.app
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            Console.WriteLine(Sum(2, 2));
            Console.WriteLine(WelcomeUser("Timotej", 20, true));
        }




        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }

        internal static string WelcomeUser(string username, int age, bool shuoldBeColored)
        {
            if (shuoldBeColored)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            return "Welcome " + username + ", you are " + age + " years old";
            string str1 = string.Empty; //ako treba prazen string
            
        }

    }
}
