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
        public FormPrincipal()
        {
            InitializeComponent();

            // Mensaje alterno para pictureBoxMenuEmergente 
            var toolTipMenuEmergente = new ToolTip();
            toolTipMenuEmergente.SetToolTip(pictureBoxMenuEmergente, "Limpiar busqueda");
            //
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
    }
}
