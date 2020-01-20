﻿using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.DataSetSerNoSer;

namespace CapaNegocio
{
    class Acceso
    {
        DatosSet nuevoAcceso = new DatosSet();

        List<Pregunta> preguntin;

        public List<Pregunta> DevolverPreguntasPorNivel(int nivel, out string msg)
        {
            return nuevoAcceso.DevolverPreguntasPorNivel(nivel, out msg);
        }
    }
}
