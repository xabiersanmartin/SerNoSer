using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.DataSetSerNoSer;

namespace CapaNegocio
{
    public class Acceso
    {
        DatosSet nuevoAcceso = new DatosSet();


        public Pregunta DevolverPreguntaPorNivel(int nivel, List<Pregunta> preguntasYaUsadas, out string msg) // TODO No tiene sentido. No controla que no se repitan ya que trabaja con variables locales y sin lógica
        {
            List<Pregunta> todasLasPreguntas = nuevoAcceso.DevolverPreguntasPorNivel(nivel, out msg);
            // TODO Ver método y posibles respuestas
            if (msg == "El nivel seleccionado sobrepasa el nivel de las preguntas.")
            {
                return null;
            }
            List<int> idsDePregunta = (from p in todasLasPreguntas
                                       select p.idPregunta).ToList(); // TODO Cada vez va a buscar todas...
            var noRepetidas = todasLasPreguntas.Distinct(); // TODO ¿Qué es esto aquí?
            Random rnd = new Random();
            int numeroAlAzar;
            Pregunta preguntaAlAzar;
            do // TODO Esto lo único que hace, dando un número de vueltas absurdas, sacar una pregunta al azar de las que haya en el nivel, pero sin control de no repetida
            {
                numeroAlAzar = rnd.Next(idsDePregunta.Min(), (idsDePregunta.Max() + 1)); 
                preguntaAlAzar = (from pre in noRepetidas
                                  where pre.idPregunta == numeroAlAzar
                                  select pre).SingleOrDefault();

            } while (preguntaAlAzar == null);
           
            return preguntaAlAzar;
        }
        public IReadOnlyCollection<int> DevolverNivel()
        {
            return nuevoAcceso.DevolverTodosNiveles();
        }
    }
}
