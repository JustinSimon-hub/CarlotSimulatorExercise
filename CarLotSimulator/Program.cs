using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        

        static void Main(string[] args)
        {






            CarLot ACarLot = new CarLot();
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();
           
            //Instantiates objects from car class and initializes them
            car1.Year = 2019;
            car2.Year = 2020;
            car3.Year = 2021;
            car1.Make = "Lamb";
            car2.Make = "Bugatti";
            car3.Make = "McLaren";
            car1.Model = " Urus";
            car2.Model = "Charon";
            car3.Model = "XL";
            car1.EngineNoise = "Rrrrrmmmmm...";
            car2.EngineNoise = "Bnkbnkbnkkkkkk";
            car3.EngineNoise = "Wheeeeewheeeewheeee";
            car1.HonkNoise = "euhhh euhhh";
            car2.HonkNoise = "Boom boom";
            car3.HonkNoise = "Bonk bink";
            car1.IsDrivable = true;
            car2.IsDrivable = false;
            car3.IsDrivable = true;
            //Takes values from the car class and adds them to the property of the CarLot class

            ACarLot.List = new List<Car>() { car1, car2, car3 };
            
           
            
                Console.WriteLine($" The first car is a {car3.Year} {car3.Make} {car3.Model}. The second car is a {car1.Year} {car1.Make} {car1.Model}. The Third car is a {car2.Year} {car2.Model} {car2.Make}");
                Console.WriteLine("***********************************");
            


            
            Console.WriteLine(car1.MakeEngineNoise(car1.EngineNoise));
            Console.WriteLine(car2.MakeEngineNoise(car2.EngineNoise));
            Console.WriteLine(car3.MakeEngineNoise(car3.EngineNoise));
            Console.WriteLine("************");
            Console.WriteLine(car1.MakeHonkNoise(car1.HonkNoise));
            Console.WriteLine(car2.MakeHonkNoise(car2.HonkNoise));
            Console.WriteLine(car3.MakeHonkNoise(car3.Car3HonkNoise));
            
           


            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
