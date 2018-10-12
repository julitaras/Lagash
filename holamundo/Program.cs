using System;
using System.Collections.Generic;

namespace holamundo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Este codigo escribe el nombre y me saluda, practicando
            Console.WriteLine("Escriba su nombre:");
            string nombre;
            //int numero = 1;
            nombre = Console.ReadLine();
            //Console.WriteLine("Hello World! " + nombre);
            Console.WriteLine(Armarstring(nombre));
            //Console.WriteLine($"Hello World {Armarstring()}");
            //Console.WriteLine(String.Concat("Hello World ", nombre,"!!", numero.ToString()));

            //Este codigo es un operador suma 
            Console.WriteLine("Escriba dos numeros");
            int num1 = 0;
            int num2 = 0;
            List<int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);

            foreach (int n in numeros)
            {
                if (n > 2)
                {
                    Console.WriteLine(n);
                }
            }

            for(int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            try
            {
                num1 = Int32.Parse(Console.ReadLine());
                num2 = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
            Console.WriteLine(Sumar(num1, num2));
        }

        private static string Armarstring(string nombre)
        {
            string mensaje = $"HelloWorld! {nombre}";
            return mensaje;
        }

        private static int Sumar(int num1, int num2)
        {
            int respuesta = num1 + num2;
            return respuesta;
        }
    }

}
