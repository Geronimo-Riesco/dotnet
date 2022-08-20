﻿// Ver la versión de .NET  ->  ~$ dotnet --version
// Crear la aplicación  ->  ~$ dotnet new console --framework net6.0
// Ejecute la aplicación  ->  ~$ dotnet run

//Aplicación

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
