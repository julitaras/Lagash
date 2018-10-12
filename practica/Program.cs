using System;
using Classes;
using System.Collections.Generic;
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {   
            Forms figura = new Forms();
            Console.WriteLine("Elija entre cuadrado o triangulo");
            string fig = Console.ReadLine(); 
            Console.WriteLine("Escriba el numero de la base");
            int num;
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el numero de la altura");
            int num1;
            num1 = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine(figura.CalcularArea(num, num1));
        }
    }
}
