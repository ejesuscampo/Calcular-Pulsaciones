using Entity;
using System;

namespace Calcular_Pulsaciones__EjercicioDos_
{
    class Program
    {
        static void Main(string[] args)
        {
            string identificacion, nombre, sexo;
            int edad;

            Console.WriteLine("CALCULAR NUMERO DE PULSACIONES"); 
            Console.WriteLine("");

            Console.Write("Digite su identificacion: ");
            identificacion = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Digite su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("");


            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine()); 
            Console.WriteLine("");


            Console.Write("Seleccione su sexo ( F / M ): ");
            sexo = Console.ReadLine();

            Persona persona = new Persona()
            {
                Identificacion = identificacion,
                Nombre = nombre,
                Edad = edad,
                Sexo = sexo
            };

            persona.CalcularPulsaciones();

            Console.WriteLine("");
            Console.WriteLine($"El numero de pulsaciones que debes tener es: {persona.Pulsaciones}");

            Console.ReadKey();
        }
    }
}
