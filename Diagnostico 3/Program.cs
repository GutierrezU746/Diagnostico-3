using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagnostico_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salida = 0;
            do
            {
                Console.WriteLine("Eliga una opcione el 1 aal 5");
                string Opciones = Console.ReadLine();
                switch (Opciones)
                {
                    case "1":
                        string [] canciones1 = new string[5];
                        int cont = 0;
                        while(cont<5)
                        {
                            Console.WriteLine("Ingrese una cancion");
                            canciones1[cont] = Console.ReadLine();
                            cont++;
                        }

                        Console.ReadKey();
                        break;
                    case "2":
                       string [] canciones2 = new string[5];
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Ingrese una cancion");
                            canciones2[i] = Console.ReadLine();
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine(canciones2[i]);
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case "3":
                        string[] Nombre = new string[5];
                        int[] Edad = new int[5];
                        int cont2 = 0;
                        while (cont2 < 5)
                        {
                            Console.WriteLine("Ingrese un nombre");
                            Nombre[cont2] = Console.ReadLine();
                            Console.WriteLine("Ingrese una edad");
                            Edad[cont2] = int.Parse(Console.ReadLine());
                            cont2++;
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        string[] Nombre2 = new string[5];
                        int[] Edad2 = new int[5];
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Ingrese un nombre");
                            Nombre2[i] = Console.ReadLine();
                            Console.WriteLine("Ingrese una edad");
                            Edad2[i] = int.Parse(Console.ReadLine());
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine(Nombre2[i]+": " + Edad2[i]);
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case "5":
                        int[] Num1 = new int[5];
                        int[] Num2 = new int[5];
                        int[] Resultado = new int[5];
                        for (int n = 0; n < 5; n++)
                        {
                            Console.WriteLine("Ingrese un numero");
                            Num1[n] = int.Parse(Console.ReadLine());
                        }
                        for (int m = 0; m < 5; m++)
                        {
                            Console.WriteLine("Ingrese un numero");
                            Num2[m] = int.Parse(Console.ReadLine());
                        }
                        for (int s = 0; s < 5; s++)
                        {
                           Resultado[s] = Num1[s] + Num2[s];
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Los resultados de las sumas son: ");
                            Console.WriteLine(Resultado[i]);
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (salida!=0);
        }
    }
}
