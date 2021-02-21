using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Pulsaciones__EjercicioDos_
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            int sexo = 0;
            float pulsaciones = 0;

            Console.WriteLine("CALCULO NUMERO DE PULSACIONES"); Console.WriteLine("");

            //Ingreso de datos
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());   Console.WriteLine("");

            do
            {
                Console.WriteLine("      Seleccione su sexo");
                Console.WriteLine("1. Femenino    -    2. Masculino");
                sexo = int.Parse(Console.ReadLine());

           

            //Calculo para obtener total de las pulsaciones 
            switch (sexo)
            {
                case 1:
                    pulsaciones = (220 - edad) / 10;
                    Console.WriteLine($"El numero de pulsaciones que debes tener es: {pulsaciones}");
                    break;

                case 2:
                    pulsaciones = (210 - edad) / 10;
                    Console.WriteLine($"El numero de pulsaciones que debes tener es: {pulsaciones}");
                    break;
                default:
                    Console.WriteLine("La opción no es valida");        Console.WriteLine("");
                    break;
            }

            } while ((sexo != 1 & sexo !=2));

            Console.ReadKey();
        }
    }
}
