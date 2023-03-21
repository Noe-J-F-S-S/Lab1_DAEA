using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Multiplicacion de dos números");
                Console.WriteLine("[4] Division de dos números");
                Console.WriteLine("[5] Imprimir los diez primeros numeros");
                Console.WriteLine("[6] Convercion a Celcius");
                Console.WriteLine("[7] Convercion a Farenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion de {0} y {1} es {2}", c, d, Multiplicar(c,d));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}", f, g, Division(f, g));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Calculando...");
                        Impresion();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Ingrese el grado en Farenheit");
                        int i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La conversion en celcius es: ", ConvercionC(i));
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese el grado en Celcius");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La conversion en celcius es: ", ConvercionF(h));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }
        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        //Función para calcular la multiplicacion de 2 números enteros
        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        //Función para calcular la division de 2 números enteros
        static int Division(int a, int b)
        {
            return a / b;
        }

        //Función para calcular la suma de 2 números enteros
        static void Impresion()
        {
            //List<int> numPrimos = new List<int>();
            //for (int i = 1; i <= 30; i++)
            //{
            //    if (i / 1 == i && i / i == 1)
            //    {
            //        numPrimos.Add(i);
            //        Console.WriteLine("El numero es: }", i);
            //    }    


            //}
            List<int> nums = new List<int>() {2, 3, 5,7,11,13, 17,19,23,29 };

            for (int i = 1; i <= nums.Count; i++)
            {
                Console.WriteLine("El numero es:" +  i);
            }
        }

        static float ConvercionF(float h)
        {
            return (9 * h / 5) + 32;
        }
        static float ConvercionC(float i)
        {
            return (5 * (i - 32)) / 9;
        }

    }
}
