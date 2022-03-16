using System;

namespace Sedc.class4.OOP.Strings
{
    class Program
    {
        static void Main(string[] args)
        {


            string name = "Trajan";
            string hello1 = "Hello" + name;
            string hello2 = string.Format("Hello {0}", name); //Hello Trajan
            string hello3 = $"Hello {name}";
             
            Console.WriteLine("Hello1 " + hello1);
            Console.WriteLine (string.Format("Hello 2 {0}", hello2));
            Console.WriteLine($"Hello 3 {hello3}"); //${}

            string path = "Check your c:\\ drive";
            //Console.WriteLine(path);

            string a = "We will have \"fair\" elections";
            string b = "The \n sign means: new line";
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            string path1 = @"Check your c:\ drive";
            string aa = @"We will have ""fair"" ellections";
            string bb = @"The \n sign means new line";

            string filePath = @"system\windows";
            string cc = $@"Check your c:\{filePath} drive";
            Console.WriteLine(cc);

            string myStringCurrency = string.Format("{0:C}", 105.5);
            Console.WriteLine(myStringCurrency);
            int phoneNumber = 077234243;
            //077-234-234
            string phone = string.Format("{0:0##-###-###}", phoneNumber); //prvata brojka sekogash da e 0, i se da mi ispechatish vo ovoj format
            Console.WriteLine(phone);

            string formatWithMultipleStrings = string.Format("{0} {1} {2} {3} {4} {5}", "Hello", "my", "name", "is", "Timotej", "!!!");
            Console.WriteLine(formatWithMultipleStrings);


            string test = "               We are learning c#. its fun and easy, ok maybe just fun.                         ";
            string lowerLetters = test.ToLower();
            string upperLetters = test.ToUpper();

            string[] splitted = test.Trim().Split(' ');
            Console.WriteLine("The length is " + splitted.Length);

            foreach(string word in splitted)
            {
                Console.WriteLine(word);
            }
            string substring = test.Substring(25, 50);
            Console.WriteLine(substring);


         }



    }
}
