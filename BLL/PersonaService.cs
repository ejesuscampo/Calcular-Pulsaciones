using DAL;
using Entity;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PersonaService
    {
        PersonaRepository personaRepository = new PersonaRepository();
        public string Guardar(Persona persona)
        {

            try
            {
                if (personaRepository.BuscarPorIdentificacion(persona.Identificacion) == null)
                {
                    personaRepository.Guardar(persona);
                    return "Se guardaron los datos satisfactoriamente";
                }
                return $"No es posible GUARDAR a la persona, la identificacion {persona.Identificacion} ya se encuentra registrada";

            }
            catch (Exception exception)
            {

                return "Se presentó el siguiente error: " + exception.Message;
            }
        }


        public string Eliminar(string identificacion)
        {
            try
            {
                if (personaRepository.BuscarPorIdentificacion(identificacion) != null)
                {
                    personaRepository.Eliminar(identificacion);
                    return "Se eliminó satisfactoriamente";
                }
                return "La persona que desea ELIMINAR no se encuentra registrada";
            }
            catch (Exception exception)
            {

                return "Se presentó el siguiente error: " + exception.Message;
            }

        }


        public string Modificar(Persona personaNueva, string identificacion)
        {
            try
            {
                if (personaRepository.BuscarPorIdentificacion(identificacion) != null)
                {
                    personaRepository.Modificar(personaNueva, identificacion);
                    return "Se modifico la información ";
                }
                return "La persona que desea MODIFICAR no se encuentra registrada";
            }
            catch (Exception exception)
            {
                return "Se presentó el siguiente error: " + exception.Message;
            }
        }

        public ConsultaResponse Consultar()
        {
            try
            {
                return new ConsultaResponse(personaRepository.Consultar());
            }
            catch (Exception exception)
            {
                return new ConsultaResponse("Se presentó el siguiente error: " + exception.Message);
            }
        }

        public ConsultaResponse Consultar(string tipo)
        {
            try
            {
                return new ConsultaResponse(personaRepository.ConsultarTipo(tipo));
            }
            catch (Exception exception)
            {
                return new ConsultaResponse("Se presentó el Siguiente error: " + exception.Message);
            }
        }

    }

    public class ConsultaResponse
    {
        public List<Persona> Personas { get; set; }
        public string Mensaje { get; set; }

        public bool Error { get; set; }

        public ConsultaResponse(List<Persona> personas)
        {
            Personas = personas;
            Error = false;
        }

        public ConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }
}

