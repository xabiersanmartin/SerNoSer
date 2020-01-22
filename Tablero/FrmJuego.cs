using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablero
{
    public partial class FrmJuego : Form
    {
        public List<Pregunta> preguntasYaUsadas = new List<Pregunta>();

       public string msg;
        public FrmJuego()
        {
            InitializeComponent();
        }
        private void FrmJuego_Load(object sender, EventArgs e)
        {
            cboNivel.Items.Clear();
            cboNivel.Items.AddRange(Program.Gestor.DevolverPreguntas().ToArray());
            cboNivel.DisplayMember="Nivel";
        }
        private List<Button> ObtenerBotonesRespuestas()
        {
            return Controls.OfType<Button>().Where(btn => btn.Name.Length <= 5).ToList(); // Hace referencia a los controles de tipo Button que tienen un nombre de máximo 5 caracteres
        }
        private void btnCambiarPregunta_Click(object sender, EventArgs e)
        {
            
        }




        private void btnPosibleRespuesta_Click(object sender, EventArgs e)
        {



        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            Pregunta preguntaPorNivel;

           preguntaPorNivel = Program.Gestor.DevolverPreguntaPorNivel(int.Parse(lblNivel.Text), preguntasYaUsadas, out msg);

            if (!(msg == ""))
            {
                MessageBox.Show(msg);
            }
            else
            {
                lblEnunciado.Text = preguntaPorNivel.descripcion;
            }
            
        }

        private void tmrTiempoTotal_Tick(object sender, EventArgs e)
        {

        }


    }
}