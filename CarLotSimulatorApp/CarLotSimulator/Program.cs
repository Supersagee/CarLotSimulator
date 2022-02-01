using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            
            
            var mustang = new Car();
            mustang.Make = "Ford";
            mustang.Model = "Mustang Shelby";
            mustang.Year = 2013;
            mustang.IsDriveable = true;
            mustang.EngineNoise = "GGVRROOOMMM";
            mustang.HonkNoise = "HHHOONNKKK";
            lot.Cars.Add(mustang);

            var camry = new Car()
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 1993,
                IsDriveable = false,
                EngineNoise = "pupupupuuppu",
                HonkNoise = "Beep!"
            };
            lot.Cars.Add(camry);

            var pickup = new Car("Chevy", "Silverado", 2013, true, "VVRROOOOM", "HOONNNKKKK");
            lot.Cars.Add(pickup);

            Car.MakeEngineNoise(mustang.EngineNoise);
            Car.MakeEngineNoise(camry.EngineNoise);
            Car.MakeEngineNoise(pickup.EngineNoise);

            Car.MakeHonkNoise(mustang.HonkNoise);
            Car.MakeHonkNoise(camry.HonkNoise);
            Car.MakeHonkNoise(pickup.HonkNoise);

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"{car.Year} --- {car.Make} --- {car.Model}");
            }
        }
    }
}
