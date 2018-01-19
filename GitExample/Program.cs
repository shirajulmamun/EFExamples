using GitExample.Animals;
using GitExample.Contracts;
using GitExample.Transportation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExample
{
    class Program
    {
        static void Main(string[] args)
        {


            //List<Animal> zoo = new List<Animal>();
            //zoo.Add(new Eagle());
            //zoo.Add(new Tiger());
            //zoo.Add(new Doel());

            //foreach (var animal in zoo)
            //{
            //    Console.WriteLine(animal.Speak());
            //}

            List<IFlyable> flyingObjects = new List<IFlyable>();
            flyingObjects.Add(new Superman() { FlySpeed = "SuperFast" });
            flyingObjects.Add(new Doel() { FlySpeed = "Slow" });
            flyingObjects.Add(new Eagle() { FlySpeed = "Fast" });
            flyingObjects.Add(new Aeroplane() { FlySpeed = "Moderate" });

            foreach(var flyingObject in flyingObjects)
            {
                Console.WriteLine(flyingObject.Fly() + " Flying Speed: " + flyingObject.FlySpeed);
            }

            Superman superMan = new Superman() { FlySpeed = "Fast" };
            Superman superMan2 = new Superman() { FlySpeed = "Fast" };

            if(superMan==superMan2)
            {
                Console.WriteLine("Both has same flying speed!");
            }
            else
            {
                Console.WriteLine("They are different!");
            }
            People people = new People();

            foreach(var person in people)
            {

            }

            Console.ReadKey();






        }
    }
}
