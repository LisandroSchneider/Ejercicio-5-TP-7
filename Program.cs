using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0,resultado=1;

            Console.Clear();
            
            Console.WriteLine("Digite el numero que desea obtener su factorial");
            n = int.Parse(Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                resultado *= i;

            }

            Console.WriteLine("El resultado es: {0}",resultado);
        

        }
    }
}
