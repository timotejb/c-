using System;
using Sedc.OOP.class5.ClassedAndObjects.app.Models;


namespace Sedc.OOP.class5.ClassedAndObjects.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 20;
            person.Name = "Timotej";
            person.Talk("Zdravo");

            Person person1 = new Person { 
                Age =20,
                Name = "Vlatko"
            };

            person1.Talk("Hello students" +
                "");
        }


    }
}
