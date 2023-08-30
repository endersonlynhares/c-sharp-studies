using System;

namespace PaintingHouse{
    class Program{
        static void Main(string[] args){
            double l1 = Convert.ToDouble(Console.ReadLine());
            double l2 = Convert.ToDouble(Console.ReadLine());
            double l3 = Convert.ToDouble(Console.ReadLine());
            
            double p = (l1 + l2 + l3) / 2;
            
            double area = Math.Sqrt(p * (p - l1) * (p - l2) * (p - l3));
            
            Console.WriteLine(area.ToString("0.00"));
            
        }
    }
}

