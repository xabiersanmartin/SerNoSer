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


        public Pregunta DevolverPreguntaPorNivel(int nivel, List<Pregunta> preguntasYaUsadas, out string msg)
        {
            List<Pregunta> todasLasPreguntas = nuevoAcceso.DevolverPreguntasPorNivel(nivel, out msg);
            List<int> idsDePregunta = (from p in todasLasPreguntas
                                       select p.idPregunta).ToList();
            Random rnd = new Random();
            int numeroAlAzar;
            Pregunta preguntaAlAzar = null;
            do
            {
                numeroAlAzar = rnd.Next(idsDePregunta.Min(), (idsDePregunta.Max() + 1));
                preguntaAlAzar = (from pre in preguntasYaUsadas
                                  where pre.idPregunta == numeroAlAzar
                                  select pre).SingleOrDefault();

            } while (preguntaAlAzar != null);
           
            return preguntaAlAzar;
        }
    }
}
