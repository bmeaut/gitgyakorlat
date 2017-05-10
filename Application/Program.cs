using System;
using Common;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia! Ez itt a mini alkalmazás, ami használja");
            Console.WriteLine("a Common class library szolgáltatásait.");
            Console.WriteLine(GetIsPrimeText(7));
            Console.WriteLine(GetIsPrimeText(9));
            Console.WriteLine(string.Format("3+2={0}", Operations.Add(3, 2)));
            Console.WriteLine(string.Format("5-3={0}", Operations.Sub(5, 3)));
        }

        static string GetIsPrimeText(int value)
        {
            return string.Format("A {0} {1}prím.", value, Operations.IsPrime(value) ? "" : "nem ");
        }
    }
}
