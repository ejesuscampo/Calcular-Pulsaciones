using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonaRepository
    {
        string ruta = @"Persona.txt";

        //Funcion GUARDAR
        public void Guardar(Persona persona)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{persona.Identificacion};{persona.Nombre};{persona.Edad};{persona.Sexo};{persona.Pulsaciones}");
            writer.Close();
            file.Close();
        }

        //Funcion ELIMINAR
        public void Eliminar(string identificacion)
        {
            List<Persona> personas = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in personas)
            {
                if (!item.Identificacion.Equals(identificacion))
                {
                    Guardar(item);
                }
            }

        }

        //Funcion CONSULTAR
        public List<Persona> Consultar()
        {
            List<Persona> personas = new List<Persona>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Persona persona = MapearPersona(linea);
                personas.Add(persona);
            }
            file.Close();
            reader.Close();
            return personas;
        }

        private static Persona MapearPersona(string linea)
        {
            string[] datosPersona = linea.Split(';');
            Persona persona = new Persona();
            persona.Identificacion = datosPersona[0];
            persona.Nombre = datosPersona[1];
            persona.Edad = int.Parse(datosPersona[2]);
            persona.Sexo = datosPersona[3];
            persona.Pulsaciones = Convert.ToDecimal(datosPersona[4]);
            return persona;
        }

        //Funcion BUSCAR POR ALGO
        public Persona BuscarPorIdentificacion(string identificacion)
        {
            foreach (var item in Consultar())
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return item;
                }
            }
            return null;
        }

        //Funcion MODIFICAR
        public void Modificar(Persona personaNueva, string identificacion)
        {
            List<Persona> personas = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in personas)
            {
                if (!item.Identificacion.Equals(identificacion))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(personaNueva);
                }
            }
        }

        //Funcion CONSULTA MAYORES
        public List<Persona> ConsultarMayoresDeEdad()
        {

            List<Persona> personas = new List<Persona>();
            // aun no hace el filtro;
            return personas;
        }

        //Funcion CONSULTA POR TIPO
        public List<Persona> ConsultarTipo(string tipo)
        {
            var personas = Consultar();
            return (from persona in personas
                    where persona.Sexo.Equals(tipo)
                    select persona).ToList();
        }

        public int ContarTipo(string tipo)
        {
            var personas = Consultar();
            return personas.Count(p => p.Sexo.Equals(tipo));
        }

        public decimal PromedioPulsaciones()
        {
            var personas = Consultar();
            return personas.Average(p => p.Pulsaciones);
        }
    }
}
