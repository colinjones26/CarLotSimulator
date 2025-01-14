using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        // Properties

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string noise)
        {
            EngineNoise = noise;
            Console.WriteLine($"Engine noise: {EngineNoise}");
        }

        public void MakeHonkNoise(string noise)
        {
            HonkNoise = noise;
            Console.WriteLine($"Honk noise: {HonkNoise}");
        }
    }
}
