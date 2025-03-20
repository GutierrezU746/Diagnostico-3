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
                       string [] canciones = new string[5];
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Ingrese una cancion");
                            canciones[i] = Console.ReadLine();
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine(canciones[i]);
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    default:
                        break;
                }
            } while (salida!=0);
        }
    }
}
