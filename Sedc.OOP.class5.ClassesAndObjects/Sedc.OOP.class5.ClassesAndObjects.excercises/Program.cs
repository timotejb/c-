using System;
using Sedc.OOP.class5.ClassesAndObjects.excercises.Models;
namespace Sedc.OOP.class5.ClassesAndObjects.excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            public_Person human = new public_Person();

            human.GetPersonStats("Timotej", "Bojarovski", 20);

            Dog dog = new Dog()
            {
                Color = Console.ReadLine(),
                Name = Console.ReadLine(),
                Race = Console.ReadLine()
            };

            Console.WriteLine("Is the dog eating, chasing its tail or playing?");
            string what = Console.ReadLine();
            if (what == "eating")
            {
                dog.Eat(true);
            }
            else if (what == "playing")
            {
                dog.Play(true);
            }
            else if (what == "chasing its tail")
            {
                dog.ChasingTail(true);
            }
            else
                Console.WriteLine("wrong");

            Student[] students = {new Student()
            {
                Academy = "Seavus",
                Group = "3",
                Name = "Timotej"
            },
            new Student()
            {
                Name = "Trajan",
                Group = "2",
                Academy = "Seavus"

            },
            new Student()
            {
                Academy = "Seavus",
                Name = "Kristijan",
                Group = "4"

            },
            new Student()
            {
                Academy = "Seavus",
                Name = "Stefan",
                Group = "3"
            },
            new Student()
            {
                Academy = "Seavus",
                Name = "Timotej2",
                Group = "3"
            }, 
            };
        

            Console.WriteLine("Type your students name in:");
            string studentName = Console.ReadLine();

            foreach (Student student in students )
            {
                if(studentName)//proveri dali se vika kako se vika i dali postoi i posle isprintaj go
                Console.WriteLine(student.Name);
            }
        }
    }
}
