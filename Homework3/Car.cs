using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Car
    {
        public string Brand { get; set; }
        public string NumberPlate { get; set; }
        public int Velocity { get; set; }

        public void StartMovement()
        { 
            Velocity = 5;
            Console.WriteLine($"{Brand} is starting to move. Velocity is {Velocity} kmh now");
        }

        public void FinishMovement()
        {
            Velocity = 0;
            Console.WriteLine($"{Brand} has finished its movement");
        }

        public void IncreaseVelocity(int kmh)
        {
            Velocity += kmh;
            Console.WriteLine($"Velocity (+{kmh}): {Velocity} kmh");
        }

        public void DecreaseVelocity(int kmh)
        {
            Velocity -= kmh;
            Console.WriteLine($"Velocity (-{kmh}): {Velocity} kmh");
        }

        public void Signal()
        {
            Console.WriteLine("beeep beeeep");
        }
    }
}
