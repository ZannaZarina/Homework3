using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Item
    {
        public Item(double width, double length, double weight)
        {
            Width = width;
            Length = length;
            Weight = weight;
        }
        public double Width { get; }
        public double Length { get; }
        public double Weight { get; }

        public void getItemParameters()
        {
            Console.WriteLine($"Item parameters You've entered are: width {Width} cm, length {Length} cm, weight {Weight} g");
        }
    }
}
