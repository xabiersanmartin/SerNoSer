using CapaDatos.DataSetSerNoSerTableAdapters;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.DataSetSerNoSer;

namespace CapaDatos
{
    public class DatosSet
    {
        DataSetSerNoSer ds = new DataSetSerNoSer();
        DataSetSerNoSerTableAdapters.PreguntasTableAdapter dsPreguntas = new DataSetSerNoSerTableAdapters.PreguntasTableAdapter();
        RespuestasTableAdapter dsRespuestas = new RespuestasTableAdapter();

        public DatosSet()
        {
            dsPreguntas.Fill(ds.Preguntas);
            dsRespuestas.Fill(ds.Respuestas);
        }

        public List<Pregunta> DevolverPreguntasPorNivel(int Nivel, out string msg)
        {
           List<PreguntasRow> dsPregunta;
            dsPregunta = ds.Preguntas.Where(drPreg => drPreg.Nivel == Nivel).ToList();

            List<Pregunta> preguntas = (from dr in dsPregunta
                                       select new Pregunta(dr.NumPregunta, dr.Nivel, dr.Enunciado)).ToList();

            var nivelMaximo = (from pregunta in ds.Preguntas
                               select pregunta.Nivel).Max();

            if (preguntas == null)
            {
                msg = "La lista de preguntas esta vacia";
                return null;
            }

            if (Nivel > nivelMaximo)
            {
                msg = "El nivel seleccionado sobrepasa el nivel de las preguntas.";
                return null;
            }

            msg = "";
            return preguntas;
        }


        public List<Respuesta> DevolverRespuestas(int numPregunta)
        {
            List<RespuestasRow> dsRespuesta;
            dsRespuesta = ds.Respuestas.Where(drResp => drResp.NumPregunta == numPregunta).ToList();

            List<Respuesta> respuestas = (from dr in dsRespuesta
                                          select new Respuesta(dr.NumRespuesta, dr.NumPregunta, dr.Valida, dr.PosibleRespuesta)).Take(12).ToList();



            return respuestas;
        }

        public List<Respuesta> RespuestasFalsas(List<Respuesta> respuestas)
        {
            List<Respuesta> respuestasFalsas = (from dr in respuestas
                                                where (dr.valida == false)
                                                select new Respuesta(dr.idRespuesta, dr.idPregunta)).ToList();
            return respuestasFalsas;
        }

        public string DevolverExplicacion (int IdPregunta , int idRespuesta)
        {
            List<RespNoValidasRow> dsRespNovalida;
            dsRespNovalida = ds.RespNoValidas.Where(dsRespNovalid => ((dsRespNovalid.NumPregunta == IdPregunta) && (dsRespNovalid.NumRespuesta == idRespuesta))).Take(1).ToList();

            string explicacion;
            explicacion = (from dr in dsRespNovalida
                           select dr.Explicacion).ToString();
            return explicacion;
        }
        


    }
}
