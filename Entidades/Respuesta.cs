﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Respuesta : IEquatable<Respuesta>
    {
        
        public int idPregunta { get; set; }
        public int idRespuesta { get; set; }
        public bool valida { get; set; }
        public string posibleRespuesta { get; set; }
        public string explicacion { get; set; }



        
        public Respuesta()
        {
        }

        public Respuesta(int idRespuesta)
        {
            this.idRespuesta = idRespuesta;
        }

        public Respuesta(int idPregunta, int idRespuesta) : this(idPregunta)
        {
            this.idRespuesta = idRespuesta;
        }

        public Respuesta(int idPregunta, int idRespuesta, bool valida, string posibleRespuesta) : this(idPregunta, idRespuesta)
        {
            this.valida = valida;
            this.posibleRespuesta = posibleRespuesta ?? throw new ArgumentNullException(nameof(posibleRespuesta));
        }

        public Respuesta(int idPregunta, int idRespuesta, bool valida, string posibleRespuesta, string explicacion
            ) : this(idPregunta, idRespuesta, valida, posibleRespuesta)
        {
            this.explicacion = explicacion ?? throw new ArgumentNullException(nameof(explicacion));
        }

        public Respuesta(int idPregunta, int idRespuesta, string explicacion) : this(idPregunta, idRespuesta)
        {
            this.explicacion = explicacion ?? throw new ArgumentNullException(nameof(explicacion));
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Respuesta);
        }

        public bool Equals(Respuesta other)
        {
            return other != null &&
                   idRespuesta == other.idRespuesta;
        }

        public override int GetHashCode()
        {
            return 895682906 + idRespuesta.GetHashCode();
        }
    }
}
