using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pregunta : IEquatable<Pregunta>
    {
        public int idPregunt { get; set; }
        public int Nivel { get; set; }
        public string descripcion { get; set; }


        public Pregunta(int idPregunta, int nivel, string descripcion)
        {
            this.idPregunt = idPregunta;
            Nivel = nivel;
            this.descripcion = descripcion;
        }

        public Pregunta()
        {

        }

        public Pregunta(int idPregunta, string descripcion)
        {
            this.idPregunt = idPregunta;
            this.descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Pregunta);
        }

        public bool Equals(Pregunta other)
        {
            return other != null &&
                   idPregunt == other.idPregunt;
        }

        public override int GetHashCode()
        {
            return 1071672450 + idPregunt.GetHashCode();
        }
    }
}
