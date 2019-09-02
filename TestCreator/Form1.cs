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
        }

        private void ButtonAbrirBancoPreguntas_Click(object sender, EventArgs e)
        {
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
            if (ofdAbrirBancoPreguntas.ShowDialog() == DialogResult.OK)
            {
                comboBoxRutaBancoPreguntas.Text = ofdAbrirBancoPreguntas.FileName;
            }
        }

    }
}
