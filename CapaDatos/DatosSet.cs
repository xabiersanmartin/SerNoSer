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
        RespNoValidasTableAdapter dsNovalidas = new RespNoValidasTableAdapter();

        public DatosSet()
        {

            dsPreguntas.Fill(ds.Preguntas);
            dsRespuestas.Fill(ds.Respuestas);
            dsNovalidas.Fill(ds.RespNoValidas);


        }

        public List<Pregunta> DevolverPreguntasPorNivel(int Nivel, out string msg)
        {
            // Una condicion para comprobar si el programa ha podido conectar con la base datos.
            if (ds == null)
            {
                msg = "No se ha podido establecer conexión con la base de datos";
                return null;
            }
            if (ds.Preguntas == null)
            {
                msg = "No hay preguntas entre el nivel 1 y el maximo";
                //no hay preguntas entre niveles 1 y el que sea
            }

            // Comprobamos el nivel maximo de las preguntas en la base de datos, para guardarlo en una variable y despues usarlo en el control de errores.
            var nivelMaximo = (from pregunta in ds.Preguntas
                               select pregunta.Nivel).Max();

            if (Nivel > nivelMaximo)
            {
                msg = "El nivel seleccionado sobrepasa el nivel de las preguntas.";
                return null;
            }

            //Preguntas normales de datarow a lista
            List<PreguntasRow> dsPregunta;
            dsPregunta = ds.Preguntas.Where(drPreg => drPreg.Nivel == Nivel).ToList();
            List<Pregunta> preguntas = (from dr in dsPregunta
                                        select new Pregunta(dr.NumPregunta, dr.Nivel, dr.Enunciado)).ToList();

            if (preguntas == null)
            {
                msg = "La lista de preguntas esta vacia";
                return null;
            }

            foreach (var pregunta in preguntas)
            {
                //Respuestas normales de datarow a lista
                List<RespuestasRow> dsRespuestasDePregunta = ds.Respuestas.Where(drResp => drResp.NumPregunta == pregunta.idPregunta).ToList();
                List<Respuesta> respuestasDePregunta = (from dr in dsRespuestasDePregunta
                                                        select new Respuesta(dr.NumPregunta, dr.NumRespuesta, dr.Valida, dr.PosibleRespuesta)).ToList();
                //Respuestas no validas de datarow a lista
                List<RespNoValidasRow> dsRespuestasNoValidas = ds.RespNoValidas.Where(drNoValidas => drNoValidas.NumPregunta == pregunta.idPregunta).ToList();
                List<Respuesta> respuestasNoValidasDePregunta = (from dr in dsRespuestasNoValidas
                                                                 select new Respuesta(dr.NumPregunta, dr.NumRespuesta, dr.Explicacion)).ToList();

                //Metemos a las respuestas normales su explicacion cuando no es válida y tiene explicacion, si no mensaje por defecto
                foreach (var respuesta in respuestasDePregunta)
                {
                    Respuesta respuestaConExplicacion = (from resp in respuestasNoValidasDePregunta
                                                         where resp.idRespuesta == respuesta.idRespuesta
                                                         select resp).SingleOrDefault();
                    respuesta.explicacion = respuestaConExplicacion != null ? respuestaConExplicacion.explicacion : "No sabemos el motivo, debes investigarlo";
                }

                //La lista con explicaciones se añade a la pregunta
                pregunta.respuestas = respuestasDePregunta;

                if(pregunta.respuestas.Count() == 12)
                {
                    if (pregunta.respuestas.Where(resp => resp.valida == true).Count() != 8 || pregunta.respuestas.Where(resp => resp.valida == false).Count() != 4)
                    {
                        msg = "El número de respuestas verdades no son 8 o no hay 4 falsas";
                        return null;
                        //mensaje de número de respuestas distinto de 8 y 4
                    }
                }
                else
                {
                    msg = "No hay 12 respuestas para esa pregunta";
                    return null;
                    //numero de respuestas buenas o no distinto de 12
                }
            }



            msg = "";
            return preguntas;
        }

         public  IReadOnlyCollection<int> DevolverTodosNiveles()
        {
                           
            List<int> nivelesTodos = (from dr in ds.Preguntas
                                      orderby dr.Nivel ascending
                                     select dr.Nivel).ToList();
            return nivelesTodos;
        }






        //public List<Respuesta> DevolverRespuestas(int numPregunta)
        //{
        //    List<RespuestasRow> dsRespuesta;
        //    dsRespuesta = ds.Respuestas.Where(drResp => drResp.NumPregunta == numPregunta).ToList();

        //    List<Respuesta> respuestas = (from dr in dsRespuesta
        //                                  select new Respuesta(dr.NumRespuesta, dr.NumPregunta, dr.Valida, dr.PosibleRespuesta)).Take(12).ToList();



        //    return respuestas;
        //}

        //public List<Respuesta> RespuestasFalsas(List<Respuesta> respuestas)
        //{
        //    List<Respuesta> respuestasFalsas = (from dr in respuestas
        //                                        where (dr.valida == false)
        //                                        select new Respuesta(dr.idRespuesta, dr.idPregunta)).ToList();
        //    return respuestasFalsas;
        //}

        //public string DevolverExplicacion(int IdPregunta, int idRespuesta)
        //{
        //    List<RespNoValidasRow> dsRespNovalida;
        //    dsRespNovalida = ds.RespNoValidas.Where(dsRespNovalid => ((dsRespNovalid.NumPregunta == IdPregunta) && (dsRespNovalid.NumRespuesta == idRespuesta))).Take(1).ToList();

        //    string explicacion;
        //    explicacion = (from dr in dsRespNovalida
        //                   select dr.Explicacion).ToString();
        //    return explicacion;
        //}



    }
}
