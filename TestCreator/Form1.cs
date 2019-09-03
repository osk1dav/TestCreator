using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCreator
{
    public partial class FormPrincipal : Form
    {
        // Simulacion de interruptor para botones si o no
        private bool boolIdentificarExamenes, boolMantenerOriginalNumeracionPreguntas, boolMantenerOriginalEspaciadoPreguntas, boolMantenerOriginalNumeracionRespuestas, boolMantenerOriginalEspaciadoRespuestas, boolMantenerOriginalColumnasRespuestas, boolImprimirComentariosPresentacionSolucion;
        //
        
        public FormPrincipal()
        {
            InitializeComponent();
            InicializarInterruptores();
            // Mensaje alterno para pictureBoxMenuEmergente 
            var toolTipMenuEmergente = new ToolTip();
            toolTipMenuEmergente.SetToolTip(pictureBoxMenuEmergente, "Limpiar busqueda");
        }

        private void InicializarInterruptores()
        {
            boolIdentificarExamenes = true;
            boolMantenerOriginalNumeracionPreguntas = true;
            boolMantenerOriginalEspaciadoPreguntas = true;
            boolMantenerOriginalNumeracionRespuestas = true;
            boolMantenerOriginalEspaciadoRespuestas = true;
            boolMantenerOriginalColumnasRespuestas = true;
            boolImprimirComentariosPresentacionSolucion = true;

            pictureBoxMantenerOriginalEspaciadoPreguntas.Image = boolMantenerOriginalEspaciadoPreguntas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;
            pictureBoxImprimirComentariosPresentacionSolucion.Image = boolImprimirComentariosPresentacionSolucion ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;
            pictureBoxMantenerOriginalColumnasRespuestas.Image = boolMantenerOriginalColumnasRespuestas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;
            pictureBoxMantenerOriginalEspaciadoRespuestas.Image = boolMantenerOriginalEspaciadoRespuestas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;
            pictureBoxMantenerOriginalNumeracionRespuestas.Image = boolMantenerOriginalNumeracionRespuestas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;
            pictureBoxMantenerOriginalNumeracionPreguntas.Image = boolMantenerOriginalNumeracionPreguntas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;
            pictureBoxIdentificarExamenes.Image = boolIdentificarExamenes ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }

        private void ButtonAbrirBancoPreguntas_Click(object sender, EventArgs e)
        {
            // Configuracion inicial del ofdAbrirBancoPreguntas
            OpenFileDialog ofdAbrirBancoPreguntas = new OpenFileDialog()
            {
                InitialDirectory = @"C:\Demos\",
                RestoreDirectory = true,
                Title = "Abrir banco de preguntas",
                DefaultExt = "docx",
                Filter = "Archivo de Word (*.docx)|*.docx|All files (*.*)|*.*",
                FilterIndex = 1,
                CheckFileExists = true,
                CheckPathExists = true
            };
            //

            if (ofdAbrirBancoPreguntas.ShowDialog() == DialogResult.OK)
            {
                //Agregar Item al comboBoxRutaBancoPreguntas y mostrar el ultimo texto
                comboBoxRutaBancoPreguntas.Items.Add(ofdAbrirBancoPreguntas.FileName);
                comboBoxRutaBancoPreguntas.Text = ofdAbrirBancoPreguntas.FileName;
                //
            }
        }

        private void PictureBoxMenuEmergente_Click(object sender, EventArgs e)
        {
            // Limpieza de comboBoxRutaBancoPreguntas
            comboBoxRutaBancoPreguntas.Items.Clear();
            comboBoxRutaBancoPreguntas.Text = "";
            //
        }

        private void PictureBoxMenuEmergente_MouseDown(object sender, MouseEventArgs e)
        {
            // Cambio de color para simular boton del pictureBoxMenuEmergente
            pictureBoxMenuEmergente.Image = TestCreator.Properties.Resources.icons8_eliminar_columna_500;
            //
        }

        private void PictureBoxMenuEmergente_MouseUp(object sender, MouseEventArgs e)
        {
            // Cambio de color para simular boton del pictureBoxMenuEmergente
            pictureBoxMenuEmergente.Image = TestCreator.Properties.Resources.icons8_eliminar_columna_500_cian;
            //
        }

        private void PictureBoxMantenerOriginalEspaciadoPreguntas_MouseDown(object sender, MouseEventArgs e)
        {
            boolMantenerOriginalEspaciadoPreguntas = !boolMantenerOriginalEspaciadoPreguntas;
            pictureBoxMantenerOriginalEspaciadoPreguntas.Image = boolMantenerOriginalEspaciadoPreguntas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }

        private void PictureBoxImprimirComentariosPresentacionSolucion_MouseDown(object sender, MouseEventArgs e)
        {
            boolImprimirComentariosPresentacionSolucion = !boolImprimirComentariosPresentacionSolucion;
            pictureBoxImprimirComentariosPresentacionSolucion.Image = boolImprimirComentariosPresentacionSolucion ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }

        private void PictureBoxMantenerOriginalColumnasRespuestas_MouseDown(object sender, MouseEventArgs e)
        {
            boolMantenerOriginalColumnasRespuestas = !boolMantenerOriginalColumnasRespuestas;
            pictureBoxMantenerOriginalColumnasRespuestas.Image = boolMantenerOriginalColumnasRespuestas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }

        private void PictureBoxMantenerOriginalEspaciadoRespuestas_MouseDown(object sender, MouseEventArgs e)
        {
            boolMantenerOriginalEspaciadoRespuestas = !boolMantenerOriginalEspaciadoRespuestas;
            pictureBoxMantenerOriginalEspaciadoRespuestas.Image = boolMantenerOriginalEspaciadoRespuestas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }

        private void PictureBoxMantenerOriginalNumeracionRespuestas_MouseDown(object sender, MouseEventArgs e)
        {
            boolMantenerOriginalNumeracionRespuestas = !boolMantenerOriginalNumeracionRespuestas;
            pictureBoxMantenerOriginalNumeracionRespuestas.Image = boolMantenerOriginalNumeracionRespuestas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }

        private void PictureBoxMantenerOriginalNumeracionPreguntas_MouseDown(object sender, MouseEventArgs e)
        {
            boolMantenerOriginalNumeracionPreguntas = !boolMantenerOriginalNumeracionPreguntas;
            pictureBoxMantenerOriginalNumeracionPreguntas.Image = boolMantenerOriginalNumeracionPreguntas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }

        private void PictureBoxIdentificarExamenes_MouseDown(object sender, MouseEventArgs e)
        {
            boolIdentificarExamenes = !boolIdentificarExamenes;
            pictureBoxIdentificarExamenes.Image = boolIdentificarExamenes ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }



    }
}
