using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase obj = new MiClase();
            MiClase obj2 = new MiClase(20) { miPropiedad = 20, CampoComoPropiedad=10};
            
            var nombre = args.SingleOrDefault();

            //ejemplo IF
            /*  if (nombre!= null && nombre == "jluis")
            { 
            
            }*/

            //ejemplo Switch
            /*switch (args.SingleOrDefault())
            {
                case "jluis":
                    {
                        Console.WriteLine("hola jluis!!!");
                        break;
                    }
                case "geoavila":
                    {
                        Console.WriteLine("Hola Geo");
                        break;
                    }

                default:
                    Console.WriteLine("hola!!!");
                    break;
            }*/

            //ejemplo While
           /* var bandera = 10;
            while (bandera > 0)
            {
                Console.WriteLine(bandera);
                bandera--;
            }*/

            //ejemplo DO
            /*var bandera = 10;
            do
            {
                Console.WriteLine(bandera);
                bandera--;
            } while (bandera > 0);*/

            //ejemplo FOR
           /* for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }*/

            //ejemplo ForEach
            int[] array = new int[10]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int[,] new_array =  new int[2,2] {{1,2},{3,4}};


            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
