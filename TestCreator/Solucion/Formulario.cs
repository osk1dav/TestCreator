﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCreator.Utils;

namespace TestCreator.Solucion
{
    public partial class Formulario : Form
    {
        private readonly BotonSiNo imprimirComentarios = new BotonSiNo();
        public Formulario()
        {
            InitializeComponent();
        }

        private void PictureImprimirComentarios_MouseDown(object sender, MouseEventArgs e)
        {
            imprimirComentarios.Interruptor(pictureImprimirComentarios);
        }

        private void RadioColumnas_CheckedChanged(object sender, EventArgs e)
        {
            OpcionColumna.ActvarElementos(radioColumnas, numericColumnas);
        }

        private void numericColumnas_ValueChanged(object sender, EventArgs e)
        {
            OpcionColumna.ColumnasSolucion(numericColumnas, labelColumnas);
        }
    }
}
