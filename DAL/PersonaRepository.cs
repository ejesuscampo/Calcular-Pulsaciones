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
        string ruta = "Persona.txt";
        public void Guardar(Persona persona)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{persona.Identificacion};{persona.Nombre};{persona.Edad};{persona.Sexo};{persona.Pulsaciones}");
            writer.Close();
            file.Close();
        }

        public void Consultar()
        {

        }

        public void Eliminar(string identificacion)
        {

        }

        public void Buscar(string identificacion)
        {

        }
        

        public void BuscarxIdentificacion()
        {

        }
        public void Modificar(Persona PerosnaNueva)
        {

        }
    }
}
