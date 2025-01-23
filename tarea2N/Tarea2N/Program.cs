using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número para determinar si este es un numero primo:");
        int numero = int.Parse(Console.ReadLine());
            if (EsPrimo(numero))
            {
                Console.WriteLine($"El número {numero} es primo.");
            }
        else
            {
                Console.WriteLine($"El número {numero} no es primo.");
            }
        }
        static bool EsPrimo(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) 
                    return false;
            }
            return true;
        }
    }