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
        public int tiempoAtras = 12;
        public Pregunta preguntaPorNivel;
        public List<Pregunta> preguntasYaUsadas = new List<Pregunta>();
        public Respuesta btn1Info = new Respuesta(); // todo De nuevo....
        public Respuesta btn2Info = new Respuesta();
        public Respuesta btn3Info = new Respuesta();
        public Respuesta btn4Info = new Respuesta();
        public Respuesta btn5Info = new Respuesta();
        public Respuesta btn6Info = new Respuesta();
        public Respuesta btn7Info = new Respuesta();
        public Respuesta btn8Info = new Respuesta();
        public Respuesta btn9Info = new Respuesta();
        public Respuesta btn10Info = new Respuesta();
        public Respuesta btn11Info = new Respuesta();
        public Respuesta btn12Info = new Respuesta();
        public string msg;
        public string respuestaTiempo = "Te has quedado sin tiempo para esta pregunta, ¿deseas continuar con otra pregunta? No finalizará el programa";
        public string respuestaIncorrecta = "Has perdido, intentelo de nuevo despúes de leer la Wikipedia";
        public string respuestaCorrecta = "Has acertado las 8 respuestas validas¿deseas continuar con otra pregunta?";
        public string siguenteNivel = "Deseas pasar al siguente nivel?";
        public int contadorErroneas=0;
        public int contadorCorrectas = 0;
        public FrmJuego()
        {
            InitializeComponent();
        }
        private void FrmJuego_Load(object sender, EventArgs e)
        {
            btnComenzar.Enabled = true;
            btn1.Enabled = false; // todo ¿Cómo podéis a estas alturas plantear así el tratamiento de los botones? ¡¡¡¡TODO el código repetido continaumente!!!!
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn10.Enabled = false;
            btn11.Enabled = false;
            btn12.Enabled = false;

            List<int> ListaNiveles = new List<int>();
            cboNivel.Items.Clear();
            
            foreach (int nivel in Program.Gestor.DevolverNivel())
            {
                
                if (ListaNiveles.Contains(nivel))
                {
                    ListaNiveles.Add(nivel);
                }
                else
                {
                    ListaNiveles.Add(nivel);
                    cboNivel.Items.Add(nivel);
                }
                 
            }
            cboNivel.SelectedIndex=0;
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
            btnComenzar.Enabled = false;

            tiempoAtras = 12;
            tmrTiempoTotal.Interval = 1000;
            tmrTiempoTotal.Enabled = true;
            tmrTiempoTotal.Start();
            lblTiempo.Text = tiempoAtras.ToString();

            lblRespuestaValida.Text = "";
            contadorCorrectas = 0;
            contadorErroneas = 0;
            btn1.BackColor = Color.Empty; 
            btn2.BackColor = Color.Empty;
            btn3.BackColor = Color.Empty;
            btn4.BackColor = Color.Empty;
            btn5.BackColor = Color.Empty;
            btn6.BackColor = Color.Empty;
            btn7.BackColor = Color.Empty;
            btn8.BackColor = Color.Empty;
            btn9.BackColor = Color.Empty;
            btn10.BackColor = Color.Empty;
            btn11.BackColor = Color.Empty;
            btn12.BackColor = Color.Empty;
            
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;

            

            preguntaPorNivel = Program.Gestor.DevolverPreguntaPorNivel(int.Parse(lblNivel.Text), preguntasYaUsadas, out msg);

            if (preguntaPorNivel == null)
            {
                MessageBox.Show(msg);
                this.Close();
                return;
            }


            if (int.Parse(lblNivel.Text) > preguntaPorNivel.Nivel)
            {
                MessageBox.Show(msg);
                this.Close();
                return;
            }
              

            if (preguntaPorNivel.respuestas.Count != 12)
            {
                MessageBox.Show(msg);
            }
            int contadorVal=0;
            int contadorErr=0;
            foreach (Respuesta resp in preguntaPorNivel.respuestas)
            {
                if (resp.valida == true)
                {
                    contadorVal++;
                }
                else
                {
                    contadorErr++;
                }
            }
            
            if(contadorVal!=8 && contadorErr != 4)
            {
                MessageBox.Show(msg);
            }

            if (!(msg == ""))
            {
                MessageBox.Show(msg);
            }
            else
            {
                lblEnunciado.Text = preguntaPorNivel.descripcion;
            }
            btn1Info = null;
            btn2Info = null;
            btn3Info = null;
            btn4Info = null;
            btn5Info = null;
            btn6Info = null;
            btn7Info = null;
            btn8Info = null;
            btn9Info = null;
            btn10Info = null;
            btn11Info = null;
            btn12Info = null;
            int contador = 0;
            foreach (Respuesta resp in preguntaPorNivel.respuestas)
            {
                switch (contador)
                {
                    case 0:
                        btn1Info = resp;
                        break;
                    case 1:
                        btn2Info = resp;
                        break;
                    case 2:
                        btn3Info = resp;
                        break;
                    case 3:
                        btn4Info = resp;
                        break;
                    case 4:
                        btn5Info = resp;
                        break;
                    case 5:
                        btn6Info = resp;
                        break;
                    case 6:
                        btn7Info = resp;
                        break;
                    case 7:
                        btn8Info = resp;
                        break;
                    case 8:
                        btn9Info = resp;
                        break;
                    case 9:
                        btn10Info = resp;
                        break;
                    case 10:
                        btn11Info = resp;
                        break;
                    case 11:
                        btn12Info = resp;
                        break;
                }
                contador++;
            }
            btn1.Text = btn1Info.posibleRespuesta;
            btn2.Text = btn2Info.posibleRespuesta;
            btn3.Text = btn3Info.posibleRespuesta;
            btn4.Text = btn4Info.posibleRespuesta;
            btn5.Text = btn5Info.posibleRespuesta;
            btn6.Text = btn6Info.posibleRespuesta;
            btn7.Text = btn7Info.posibleRespuesta;
            btn8.Text = btn8Info.posibleRespuesta;
            btn9.Text = btn9Info.posibleRespuesta;
            btn10.Text = btn10Info.posibleRespuesta;
            btn11.Text = btn11Info.posibleRespuesta;
            btn12.Text = btn12Info.posibleRespuesta;
        }

        private void tmrTiempoTotal_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = tiempoAtras.ToString();
            tiempoAtras --;
            if (tiempoAtras < 0)
            {
                tmrTiempoTotal.Stop();
                DialogResult result = MessageBox.Show(respuestaTiempo, "Salir", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    btnComenzar.Enabled = true;
                    btnComenzar.PerformClick();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void cboNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNivel.Text = cboNivel.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Enabled = false;
            tiempoAtras = 12;
            lblRespuestaValida.Text = "";
            if (btn1Info.valida == true)
            {
                btn1.BackColor = Color.Green;
                contadorCorrectas++;
                if (contadorCorrectas == 8)
                {
                    DialogResult result = MessageBox.Show(respuestaCorrecta, "Salir", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        btnComenzar.Enabled = true;
                        btnComenzar.PerformClick();
                    }
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                    
                    
                    if (preguntasYaUsadas.Contains(preguntaPorNivel))
                    {
                        DialogResult resulta = MessageBox.Show(siguenteNivel, "Salir", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            lblNivel.Text = (int.Parse(lblNivel.Text) + 1).ToString();
                            
                            btnComenzar.Enabled = true;
                            btnComenzar.PerformClick();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    preguntasYaUsadas.Add(preguntaPorNivel);
                }
            }
            else
            {
                btn1.BackColor = Color.Red;
                lblRespuestaValida.Text = btn1Info.explicacion;
                contadorErroneas++;
                if (contadorErroneas == 4)
                {
                    MessageBox.Show(respuestaIncorrecta);
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Enabled = false;
            tiempoAtras = 12;
            lblRespuestaValida.Text = "";
            if (btn2Info.valida == true)
            {
                btn2.BackColor = Color.Green;
                contadorCorrectas++;
                if (contadorCorrectas == 8)
                {
                    DialogResult result = MessageBox.Show(respuestaCorrecta, "Salir", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        btnComenzar.Enabled = true;
                        btnComenzar.PerformClick();
                    }
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }

                    
                    if (preguntasYaUsadas.Contains(preguntaPorNivel))
                    {
                        DialogResult resulta = MessageBox.Show(siguenteNivel, "Salir", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            lblNivel.Text = (int.Parse(lblNivel.Text) + 1).ToString();
                            
                           
                            btnComenzar.Enabled = true;
                            btnComenzar.PerformClick();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                        preguntasYaUsadas.Add(preguntaPorNivel);
                }

            }
            else
            {

                btn2.BackColor = Color.Red;
                lblRespuestaValida.Text = btn2Info.explicacion;
                contadorErroneas++;
                if (contadorErroneas == 4)
                {
                    MessageBox.Show(respuestaIncorrecta);
                    this.Close();
                }
            }
        }

        private void lblRespuestaValida_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Enabled = false;
            tiempoAtras = 12;
            lblRespuestaValida.Text = "";
            if (btn3Info.valida == true)
            {
                btn3.BackColor = Color.Green;
                contadorCorrectas++;
                if (contadorCorrectas == 8)
                {
                    DialogResult result = MessageBox.Show(respuestaCorrecta, "Salir", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        btnComenzar.Enabled = true;
                        btnComenzar.PerformClick();

                    }
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }

                    
                    if (preguntasYaUsadas.Contains(preguntaPorNivel))
                    {
                        DialogResult resulta = MessageBox.Show(siguenteNivel, "Salir", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            lblNivel.Text = (int.Parse(lblNivel.Text) + 1).ToString();
                            
                            btnComenzar.Enabled = true;
                            btnComenzar.PerformClick();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                        preguntasYaUsadas.Add(preguntaPorNivel);
                }
            }
            else
            {

                btn3.BackColor = Color.Red;
                lblRespuestaValida.Text = btn3Info.explicacion;
                contadorErroneas++;
            }
            if (contadorErroneas == 4)
            {
                MessageBox.Show(respuestaIncorrecta);
                this.Close();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Enabled = false;
            tiempoAtras = 12;
            lblRespuestaValida.Text = "";
            if (btn4Info.valida == true)
            {
                btn4.BackColor = Color.Green;
                contadorCorrectas++;
                if (contadorCorrectas == 8)
                {
                    DialogResult result = MessageBox.Show(respuestaCorrecta, "Salir", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        btnComenzar.Enabled = true;
                        btnComenzar.PerformClick();
                    }
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }

                    
                    if (preguntasYaUsadas.Contains(preguntaPorNivel))
                    {
                        DialogResult resulta = MessageBox.Show(siguenteNivel, "Salir", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            lblNivel.Text = (int.Parse(lblNivel.Text) + 1).ToString();
                            
                            btnComenzar.Enabled = true;
                            btnComenzar.PerformClick();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                        preguntasYaUsadas.Add(preguntaPorNivel);
                }
            }
            else
            {

                btn4.BackColor = Color.Red;
                lblRespuestaValida.Text = btn4Info.explicacion;
                contadorErroneas++;
            }
            if (contadorErroneas == 4)
            {
                MessageBox.Show(respuestaIncorrecta);
                this.Close();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Enabled = false;
            tiempoAtras = 12;
            lblRespuestaValida.Text = "";
            if (btn5Info.valida == true)
            {
                btn5.BackColor = Color.Green;
                contadorCorrectas++;
                if (contadorCorrectas == 8)
                {
                    DialogResult result = MessageBox.Show(respuestaCorrecta, "Salir", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        btnComenzar.Enabled = true;
                        btnComenzar.PerformClick();
                    }
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }

                    
                    if (preguntasYaUsadas.Contains(preguntaPorNivel))
                    {
                        DialogResult resulta = MessageBox.Show(siguenteNivel, "Salir", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            lblNivel.Text = (int.Parse(lblNivel.Text) + 1).ToString();
                            
                            btnComenzar.Enabled = true;
                            btnComenzar.PerformClick();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                        preguntasYaUsadas.Add(preguntaPorNivel);
                }
            }
            else
            {

                btn5.BackColor = Color.Red;
                lblRespuestaValida.Text = btn5Info.explicacion;
                contadorErroneas++;
            }
            if (contadorErroneas == 4)
            {
                MessageBox.Show(respuestaIncorrecta);
                this.Close();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Enabled = false;
            tiempoAtras = 12;
            lblRespuestaValida.Text = "";
            if (btn6Info.valida == true)
            {
                btn6.BackColor = Color.Green;
                contadorCorrectas++;
                if (contadorCorrectas == 8)
                {
                    DialogResult result = MessageBox.Show(respuestaCorrecta, "Salir", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        btnComenzar.Enabled = true;
                        btnComenzar.PerformClick();
                    }
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }

                   
                    if (preguntasYaUsadas.Contains(preguntaPorNivel))
                    {
                        DialogResult resulta = MessageBox.Show(siguenteNivel, "Salir", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            lblNivel.Text = (int.Parse(lblNivel.Text) + 1).ToString();
                            
                            btnComenzar.Enabled = true;
                            btnComenzar.PerformClick();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                        preguntasYaUsadas.Add(preguntaPorNivel);
                }
            }
            else
            {

                btn6.BackColor = Color.Red;
                lblRespuestaValida.Text = btn6Info.explicacion;
                contadorErroneas++;
            }
            if (contadorErroneas == 4)
            {
                MessageBox.Show(respuestaIncorrecta);
                this.Close();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Enabled = false;
            tiempoAtras = 12;
            lblRespuestaValida.Text = "";
            if (btn7Info.valida == true)
            {
                btn7.BackColor = Color.Green;
                contadorCorrectas++;
                if (contadorCorrectas == 8)
                {
                    DialogResult result = MessageBox.Show(respuestaCorrecta, "Salir", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        btnComenzar.Enabled = true;
                        btnComenzar.PerformClick();
                    }
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }

                    
                    if (preguntasYaUsadas.Contains(preguntaPorNivel))
                    {
                        DialogResult resulta = MessageBox.Show(siguenteNivel, "Salir", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            lblNivel.Text = (int.Parse(lblNivel.Text) + 1).ToString();
                            
                            btnComenzar.Enabled = true;
                            btnComenzar.PerformClick();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                        preguntasYaUsadas.Add(preguntaPorNivel);
                }
            }
            else
            {

                btn7.BackColor = Color.Red;
                lblRespuestaValida.Text = btn7Info.explicacion;
                contadorErroneas++;
            }
            if (contadorErroneas == 4)
            {
                MessageBox.Show(respuestaIncorrecta);
                this.Close();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Enabled = false;
            tiempoAtras = 12;
            lblRespuestaValida.Text = "";
            if (btn8Info.valida == true)
            {
                btn8.BackColor = Color.Green;
                contadorCorrectas++;
                if (contadorCorrectas == 8)
                {
                    DialogResult result = MessageBox.Show(respuestaCorrecta, "Salir", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        btnComenzar.Enabled = true;
                        btnComenzar.PerformClick();
                    }
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }

                    if (preguntasYaUsadas.Contains(preguntaPorNivel))
                    {
                        DialogResult resulta = MessageBox.Show(siguenteNivel, "Salir", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            lblNivel.Text = (int.Parse(lblNivel.Text) + 1).ToString();
                            
                            btnComenzar.Enabled = true;
                            btnComenzar.PerformClick();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    preguntasYaUsadas.Add(preguntaPorNivel);
                }
            }
            else
            {

                btn8.BackColor = Color.Red;
                lblRespuestaValida.Text = btn8Info.explicacion;
                contadorErroneas++;
            }
            if (contadorErroneas == 4)
            {
                MessageBox.Show(respuestaIncorrecta);
                this.Close();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Enabled = false;
            tiempoAtras = 12;
            lblRespuestaValida.Text = "";
            if (btn9Info.valida == true)
            {
                btn9.BackColor = Color.Green;
                contadorCorrectas++;
                if (contadorCorrectas == 8)
                {
                    DialogResult result = MessageBox.Show(respuestaCorrecta, "Salir", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        btnComenzar.Enabled = true;
                        btnComenzar.PerformClick();
                    }
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }

                    if (preguntasYaUsadas.Contains(preguntaPorNivel))
                    {
                        DialogResult resulta = MessageBox.Show(siguenteNivel, "Salir", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            lblNivel.Text = (int.Parse(lblNivel.Text) + 1).ToString();
                            
                            btnComenzar.Enabled = true;
                            btnComenzar.PerformClick();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    preguntasYaUsadas.Add(preguntaPorNivel);
                }
            }
            else
            {

                btn9.BackColor = Color.Red;
                lblRespuestaValida.Text = btn9Info.explicacion;
                contadorErroneas++;
            }
            if (contadorErroneas == 4)
            {
                MessageBox.Show(respuestaIncorrecta);
                this.Close();
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            btn10.Enabled = false;
            tiempoAtras = 12;
            lblRespuestaValida.Text = "";
            if (btn10Info.valida == true)
            {
                btn10.BackColor = Color.Green;
                contadorCorrectas++;
                if (contadorCorrectas == 8)
                {
                    DialogResult result = MessageBox.Show(respuestaCorrecta, "Salir", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        btnComenzar.Enabled = true;
                        btnComenzar.PerformClick();
                    }
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }

                    if (preguntasYaUsadas.Contains(preguntaPorNivel))
                    {
                        DialogResult resulta = MessageBox.Show(siguenteNivel, "Salir", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            lblNivel.Text = (int.Parse(lblNivel.Text) + 1).ToString();
                            
                            btnComenzar.Enabled = true;
                            btnComenzar.PerformClick();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    preguntasYaUsadas.Add(preguntaPorNivel);
                }
            }
            else
            {

                btn10.BackColor = Color.Red;
                lblRespuestaValida.Text = btn10Info.explicacion;
                contadorErroneas++;
            }
            if (contadorErroneas == 4)
            {
                MessageBox.Show(respuestaIncorrecta);
                this.Close();
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            btn11.Enabled = false;
            tiempoAtras = 12;
            lblRespuestaValida.Text = "";
            if (btn11Info.valida == true)
            {
                btn11.BackColor = Color.Green;
                contadorCorrectas++;
                if (contadorCorrectas == 8)
                {
                    DialogResult result = MessageBox.Show(respuestaCorrecta, "Salir", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        btnComenzar.Enabled = true;
                        btnComenzar.PerformClick();
                    }
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }

                    if (preguntasYaUsadas.Contains(preguntaPorNivel))
                    {
                        DialogResult resulta = MessageBox.Show(siguenteNivel, "Salir", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            lblNivel.Text = (int.Parse(lblNivel.Text) + 1).ToString();
                           
                            btnComenzar.Enabled = true;
                            btnComenzar.PerformClick();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    preguntasYaUsadas.Add(preguntaPorNivel);
                }
            }
            else
            {

                btn11.BackColor = Color.Red;
                lblRespuestaValida.Text = btn11Info.explicacion;
                contadorErroneas++;
            }
            if (contadorErroneas == 4)
            {
                MessageBox.Show(respuestaIncorrecta);
                this.Close();
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            btn12.Enabled = false;
            tiempoAtras = 12;
            lblRespuestaValida.Text = "";
            if (btn12Info.valida == true)
            {
                btn12.BackColor = Color.Green;
                contadorCorrectas++;
                if (contadorCorrectas == 8)
                {
                    DialogResult result = MessageBox.Show(respuestaCorrecta, "Salir", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        btnComenzar.Enabled = true;
                        btnComenzar.PerformClick();
                    }
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }

                    if (preguntasYaUsadas.Contains(preguntaPorNivel))
                    {
                        DialogResult resulta = MessageBox.Show(siguenteNivel, "Salir", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            lblNivel.Text = (int.Parse(lblNivel.Text) + 1).ToString();
                           
                            btnComenzar.Enabled = true;
                            btnComenzar.PerformClick();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                        preguntasYaUsadas.Add(preguntaPorNivel);
                }
            }
            else
            {

                btn12.BackColor = Color.Red;
                lblRespuestaValida.Text = btn12Info.explicacion;
                contadorErroneas++;
            }
            if (contadorErroneas == 4)
            {
                MessageBox.Show(respuestaIncorrecta);
                this.Close();
            }
        }

        private void lblTiempo_Click(object sender, EventArgs e)
        {

        }
    }
}