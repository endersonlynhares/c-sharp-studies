using System;

namespace HelloWorld {
  class Program {
    static void Main(string[] args) {
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        
        int divisaoInteira = n1 / n2;
        int restoDivisao = n1 % n2;
        double divisaoQuebrada = (double) n1 / n2;
        
        Console.WriteLine(divisaoInteira);
        Console.WriteLine(restoDivisao);
        Console.WriteLine(divisaoQuebrada.ToString("0.00"));
        
    }
  }
}
