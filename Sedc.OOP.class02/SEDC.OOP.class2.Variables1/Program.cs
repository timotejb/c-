using System;

namespace SEDC.OOP.class2.Variables1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SEDC!");
            //javascript primeri
            //a = 3;

            int number = 3;

            //a = "Trajan";

            /*
            number = "Trajan";
            number = true;
            number = 1341234214214124;
            */
            
            long longNumber = 123413242123423234;
            short shortNumber = 32434;
            byte smallNumber = 8;

            double doublePrecisionNumber = 12.979879;
            float floatPrecisionNumber = 123.1F;

            
            string str = "Timotej Bojarovski"; //vo C# DOUBLE QUOTES ZNACHAT STRING ILI TEKST, A AKO STAVISH SAMO EDEN QUOTE TOA E CHARACTER 1
            char bukva = 'a';

            
            bool isSthTrue = false;

            DateTime currentDay = new DateTime();

            
            var a = 3;


            double num1;
            double num2;
            Console.WriteLine("Please input your value");
            string input = Console.ReadLine();
            Console.WriteLine( "This is the value you typed in: " + input);

            //int parsedToInteger = int.Parse(input);
            //Console.WriteLine("This is the value you typed in, but parsed: " + parsedToInteger);

            //bool parsedToBoolean = Convert.ToBoolean(input);
            //Console.WriteLine("This is the value you typed in, but parsed: " + parsedToBoolean);

            //long parsedToLong = 0;
            //bool isValid = long.TryParse(input, out parsedToLong);
            //Console.WriteLine("Is the parsing valid: " + isValid);
            //Console.WriteLine("This is the parsed input: " + parsedToLong);

            //string parsedToString = parsedToLong.ToString();


            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            string input1 = Console.ReadLine();
            bool isValidInteger = int.TryParse(input, out int parsedInput);
            if (isValidInteger)
            {
                Console.WriteLine("The parsed number is: " + parsedInput);
            }
            else
            {
                Console.WriteLine("not a valid input");
            }

            int firstNumber = 5;
            int secondNumber = 10;
            int thirdNumber = 15;
            int fourthNumber = 20;

            if(firstNumber < secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("The if statement is true");
            }
            else if(thirdNumber<fourthNumber || secondNumber > fourthNumber)
            {
                Console.WriteLine("the first 'else if' True statement");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("The tHIRD else if statement is true");
            }
            else
                Console.WriteLine("we are in else");

            int someNumber = 3;
            switch(someNumber)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("We are in case 3, 4, 5");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
