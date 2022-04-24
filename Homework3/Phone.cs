using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Phone
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }

        public void CallSomeone()
        {
            Console.WriteLine("Dialing... Connecting...");
        }

        public void SendMessage()
        {
            Console.WriteLine($"Message sent from {Brand}");
        }
    }

}
