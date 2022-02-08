using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {

        public static int CarsInLot { get; set; }
        public static void MakeEngineNoise(string noise)
        {
            Console.WriteLine(noise);
        }

        public static void MakeHonkNoise(string noise)
        {
            Console.WriteLine(noise);
        }
        
        public Car()
        {
            CarsInLot++;
        }

        public Car(string make, string model, int year, bool isDriveable, string engineNoise, string honkNoise)
        {
            Make = make;
            Model = model;
            Year = year;
            IsDriveable = isDriveable;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            CarsInLot++;
        }
        
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsDriveable { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }

    }
}
