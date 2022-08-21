
// Ver la versión de .NET  ->  ~$ dotnet --version
// Crea un proyecto de .NET basado en una plantilla  ->  ~$ dotnet new
// Un ejemplo serían  ->  ~$ dotnet new console
// Mostrar opciones de plantilla con  ->  ~$ dotnet new console -h
// Mostrar todas las plantillas instaladas con  ->  ~$ dotnet new --list
// Mostrar plantillas disponibles en NuGet.org  ->  ~$ dotnet new web --search
// Crear la aplicación de consola ->  ~$ dotnet new console --framework net6.0
// Restaura los archivos de configuración  -> ~$ dotnet restore
// Ejecute la aplicación  ->  ~$ dotnet run

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resumen
{
    internal class Program  // La internal palabra clave es un modificador de acceso para tipos y miembros de tipo.

    {
        static void Main(string[] args)
        {
            // Comentarios de una sola linea
            // otra linea de comentarios

            /* Bloque de comentarios */

            Console.WriteLine("Hola Mundo!");    //Imprime en consola
            // ; es el terminador de sentencias
            // Lenguaje Case Sensitive

            Console.WriteLine("Hoy es Jueves!");
            Console.Write("1");
            Console.Write("2");
            Console.Write("3");
            Console.WriteLine("4");
            Console.WriteLine("Artech");

            /*
             *  Hola Mundo!
             *  Hoy es Jueves!
             *  1234
             *  Artech
             *  Presiona una tecla para continuar....
             */

            //Uso de variables

            // C# C++ Java Visual Basic son lenguajes tipado fuerte.
            // Python PHP JavaScript son lenguajes tipado débil.

            //Tipo de datos entero
            int a;      //Declaración de variable
            a = 2;      //Asignación de valor

            int b = 4;  //Declaración de variable y asignación de valor

            int c = a + b;  //6

            //Declaración y asignación multiple
            int d = 8, f = 23, g = 26, h = 38;

            Console.WriteLine(d + f + g + h);

            //Una variable solo puede tener una declaración de valor.
            //Una variable puede tener infinitas asignaciones de valor.

            //int b;    //Error variable ya declarada
            //int a;

            a = 29;
            b = 38;
            a = 4;
            a = 23;
            a = 6;

            Console.WriteLine(a);
            Console.WriteLine("variable a: " + a);
            Console.WriteLine("variable c: " + c);
            Console.WriteLine("a+b= " + a + b);         // Error a+b= 386
            Console.WriteLine("a+b= " + (a + b));       // 44

            //Tipo de datos texto (string)
            string p = "Recreo";
            string r = "Café";

            Console.WriteLine(p + r);           //recreocafe
            Console.WriteLine(p + " " + r);     //recreo cafe
            Console.WriteLine(p + " y " + r);   //recreo y cafe

            //Tipo de datos char
            char x = 'a';
            Console.WriteLine(x);
            x = (char)((int)x - 32);            //resto 32 a la variable y la convierto en mayúscula
            Console.WriteLine(x);

            //Tipo de datos decimales

            //tipo de datos float 32 bits
            float flo = 6.25f;
            Console.WriteLine(flo);

            //tipo de datos double 64 bits
            double dou = 6.25;
            Console.WriteLine(dou);

            flo = 10;
            dou = 10;

            Console.WriteLine(flo / 3);
            Console.WriteLine(dou / 3);

            flo = 100;
            dou = 100;

            Console.WriteLine(flo / 3);
            Console.WriteLine(dou / 3);

            //tipo de datos boolean
            bool t = true;              //1
            Console.WriteLine(t);
            t = false;                  //0
            Console.WriteLine(t);

            /*
            //Ingreso de datos por consola
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            */

            // operador de asignación =
            int nro1 = 5;
            int nro2 = 7;

            Console.WriteLine(nro1);            // 5
            Console.WriteLine(nro2);            // 7

            nro1 = nro2;
            // <---

            Console.WriteLine(nro1);            // 7
            Console.WriteLine(nro2);            // 7

            //nro1 = 5.45;      //Error de tipo de datos

            nro1 = nro2 / 2;
            Console.WriteLine(nro1);            // 3
            dou = (double)nro2 / 2;
            Console.WriteLine(dou);             // 3,5

            // Operadores Incrementales 
            Console.WriteLine("-- Operadores Incrementales --");

            // Operadores incrementales
            // Sumar 1 a la variable ++
            nro1++;                  //nro1 = nro1 + 1;
            Console.WriteLine(nro1);

            // Restar 1 a la variable --
            nro1--;                  //nro1 = nro1 - 1;
            Console.WriteLine(nro1);

            // Sumar 5 a la variable +=
            nro1 += 5;              //nro1 = nro1 + 5;
            Console.WriteLine(nro1);

            // Restar 5 a la variable -=
            nro1 -= 5;              //nro1 = nro1 - 5;
            Console.WriteLine(nro1);

            // Multiplicar la variable *=
            nro1 *= 5;              //nro1 = nro1 * 5;
            Console.WriteLine(nro1);

            // Dividir la variable /=
            nro1 /= 5;              //nro1 = nro1 / 5;
            Console.WriteLine(nro1);        //3


            //Precedencia y procedencia de operadores unarios ++ --
            Console.WriteLine(nro1++);
            Console.WriteLine(nro1);
            Console.WriteLine(++nro1);

            // TODO Tema pendiente Constantes!!!!!!

            Console.WriteLine("Presiona una tecla para continuar....");
            Console.ReadKey(); // Presionar una tecla 
        }
    }
}
