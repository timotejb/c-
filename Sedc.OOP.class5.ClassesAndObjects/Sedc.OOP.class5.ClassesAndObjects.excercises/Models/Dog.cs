using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.class5.ClassesAndObjects.excercises.Models
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public void Eat (bool isEating)
        {
            if (isEating)
            {
                Console.WriteLine("The doggy is eating");
            }
            else
                Console.WriteLine("The dog is not eating");
        }
        public void Play(bool isPlaying)
        {
            if (isPlaying)
            {
                Console.WriteLine("The dog is playing now.");
            }
            else
                Console.WriteLine("The dog is not playing now");
        }
        public void ChasingTail (bool isChasing)
            {
                if (isChasing)
                {
                    Console.WriteLine("The dog is chasing its tail");
                }
                else
                Console.WriteLine("The dog is not chasing its tail");
            }
        }
    }
