using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea03Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1 - Sumar");
                Console.WriteLine("2 - Restar");
                Console.WriteLine("3 - División");
                Console.WriteLine("4 - Potencia");
                Console.WriteLine("5 - Área del triángulo");
                Console.WriteLine("6 - Área del cuadrado");
                Console.WriteLine("7 - Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:Console.WriteLine("Sumar");
                        break;
                    case 2:Console.WriteLine("Restar");
                        break;
                    case 3:Console.WriteLine("Dividir");
                        break;
                    case 4:Console.WriteLine("Potenciar");
                        break;
                    case 5:Console.WriteLine("Area del Triangulo");
                        break;
                    case 6: Console.WriteLine("Area del Cuadrado");
                        break;
                    case 7:  Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                        break;
                }

            } while (opcion != 7);
        }

        static void Sumar()
        {
            Console.Write("Digite el primer número: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite el segundo número: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + (num1 + num2));
        }

        static void Restar()
        {
            Console.Write("Digite el primer número: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite el segundo número: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + (num1 - num2));
        }

        static void Division()
        {
            Console.Write("Digite el primer número: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite el segundo número: ");
            float num2 = float.Parse(Console.ReadLine());
            if (num2 != 0)
            {
                Console.WriteLine("Resultado: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Error: División por cero no permitida.");
            }
        }

        static void Potencia()
        {
            Console.Write("Digite la base: ");
            float baseNum = float.Parse(Console.ReadLine());
            Console.Write("Digite el exponente: ");
            float exponente = float.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + Math.Pow(baseNum, exponente));
        }

        static void AreaTriangulo()
        {
            Console.Write("Digite la base del triángulo: ");
            float baseTriangulo = float.Parse(Console.ReadLine());
            Console.Write("Digite la altura del triángulo: ");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Área del triángulo: " + (0.5 * baseTriangulo * altura));
        }

        static void AreaCuadrado()
        {
            Console.Write("Digite el lado del cuadrado: ");
            float lado = float.Parse(Console.ReadLine());
            Console.WriteLine("Área del cuadrado: " + (lado * lado));
        }
    }
}