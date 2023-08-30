using System;

namespace BasicOperations{
    class Program{
        static void Main(string[] args){
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A * B);
            Console.WriteLine(((double) A / B).ToString("0.00"));
            Console.WriteLine(A % B);
            
        }
    }
}

