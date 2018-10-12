using System;
using Classes;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre de usuario");
            string name = Console.ReadLine();
            User newUser = new User(name);
           //newUser.SetName(name);
           Console.WriteLine("Ingrese su apellido");
           newUser.SetLastName(Console.ReadLine());
           Console.WriteLine(newUser.GetFullName());
        }
    }
}
