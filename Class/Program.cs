using Class;
using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            animal1.name = "Doggy";
            animal1.breed = "Choban";
            animal1.color = "white";
            animal1.age = 10;

            Console.WriteLine(animal1.GetDetails());


            Building building1 = new Building("Park Narimanov", 12, 34);
            building1.GetVolume();

        }



    }



}


