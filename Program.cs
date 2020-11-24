using System;

namespace exc4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            double[] numeros = new double [10];

            double min = 10000;
            double max = 0;

            for (int i = 0; i < 10; i++)
            {   Console.WriteLine();
                Console.WriteLine($"Digite o {i+1}° número: ");
                Console.WriteLine();
                numeros[i] = double.Parse(Console.ReadLine());
                if (numeros[i] > max) {      
                    max = numeros[i]; }            
                if (numeros[i] < min) {      
                    min = numeros[i]; }
            }
                   
                Console.WriteLine(" Entre os 10 valores digitados o menor é: ");
                Console.Write(min);
                Console.WriteLine();
                Console.WriteLine(" Entre os 10 valores digitados o maior é: ");
                Console.Write(max);
                Console.WriteLine();
            }
        }
    }
}
