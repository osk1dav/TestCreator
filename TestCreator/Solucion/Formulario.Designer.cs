namespace TestCreator.Solucion
{
    partial class Formulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupImpresion = new System.Windows.Forms.GroupBox();
            this.radioImprimirAlFinalExamen = new System.Windows.Forms.RadioButton();
            this.radioImprimirArchivoSeparado = new System.Windows.Forms.RadioButton();
            this.radioNoImprimir = new System.Windows.Forms.RadioButton();
            this.groupPresentacion = new System.Windows.Forms.GroupBox();
            this.pictureImprimirComentarios = new System.Windows.Forms.PictureBox();
            this.labelImprimirComentarios = new System.Windows.Forms.Label();
            this.labelColumnas = new System.Windows.Forms.Label();
            this.numericColumnas = new System.Windows.Forms.NumericUpDown();
            this.radioColumnas = new System.Windows.Forms.RadioButton();
            this.textListaHorizontalComodin = new System.Windows.Forms.TextBox();
            this.labelListaHorizontalB = new System.Windows.Forms.Label();
            this.labelListaHorizontalA = new System.Windows.Forms.Label();
            this.radioListaHorizontal = new System.Windows.Forms.RadioButton();
            this.labelListaVertical = new System.Windows.Forms.Label();
            this.radioListaVertical = new System.Windows.Forms.RadioButton();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.groupImpresion.SuspendLayout();
            this.groupPresentacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImprimirComentarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumnas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupImpresion
            // 
            this.groupImpresion.Controls.Add(this.radioImprimirAlFinalExamen);
            this.groupImpresion.Controls.Add(this.radioImprimirArchivoSeparado);
            this.groupImpresion.Controls.Add(this.radioNoImprimir);
            this.groupImpresion.Location = new System.Drawing.Point(276, 25);
            this.groupImpresion.Name = "groupImpresion";
            this.groupImpresion.Size = new System.Drawing.Size(225, 260);
            this.groupImpresion.TabIndex = 3;
            this.groupImpresion.TabStop = false;
            this.groupImpresion.Text = "Impresión de la solución";
            // 
            // radioImprimirAlFinalExamen
            // 
            this.radioImprimirAlFinalExamen.AutoSize = true;
            this.radioImprimirAlFinalExamen.Location = new System.Drawing.Point(15, 71);
            this.radioImprimirAlFinalExamen.Name = "radioImprimirAlFinalExamen";
            this.radioImprimirAlFinalExamen.Size = new System.Drawing.Size(150, 17);
            this.radioImprimirAlFinalExamen.TabIndex = 26;
            this.radioImprimirAlFinalExamen.Text = "Imprimir al final del examen";
            this.radioImprimirAlFinalExamen.UseVisualStyleBackColor = true;
            // 
            // radioImprimirArchivoSeparado
            // 
            this.radioImprimirArchivoSeparado.AutoSize = true;
            this.radioImprimirArchivoSeparado.Location = new System.Drawing.Point(15, 48);
            this.radioImprimirArchivoSeparado.Name = "radioImprimirArchivoSeparado";
            this.radioImprimirArchivoSeparado.Size = new System.Drawing.Size(160, 17);
            this.radioImprimirArchivoSeparado.TabIndex = 22;
            this.radioImprimirArchivoSeparado.Text = "Imprimir en archivo separado";
            this.radioImprimirArchivoSeparado.UseVisualStyleBackColor = true;
            // 
            // radioNoImprimir
            // 
            this.radioNoImprimir.AutoSize = true;
            this.radioNoImprimir.Checked = true;
            this.radioNoImprimir.Location = new System.Drawing.Point(15, 25);
            this.radioNoImprimir.Name = "radioNoImprimir";
            this.radioNoImprimir.Size = new System.Drawing.Size(76, 17);
            this.radioNoImprimir.TabIndex = 20;
            this.radioNoImprimir.TabStop = true;
            this.radioNoImprimir.Text = "No imprimir";
            this.radioNoImprimir.UseVisualStyleBackColor = true;
            // 
            // groupPresentacion
            // 
            this.groupPresentacion.Controls.Add(this.pictureImprimirComentarios);
            this.groupPresentacion.Controls.Add(this.labelImprimirComentarios);
            this.groupPresentacion.Controls.Add(this.labelColumnas);
            this.groupPresentacion.Controls.Add(this.numericColumnas);
            this.groupPresentacion.Controls.Add(this.radioColumnas);
            this.groupPresentacion.Controls.Add(this.textListaHorizontalComodin);
            this.groupPresentacion.Controls.Add(this.labelListaHorizontalB);
            this.groupPresentacion.Controls.Add(this.labelListaHorizontalA);
            this.groupPresentacion.Controls.Add(this.radioListaHorizontal);
            this.groupPresentacion.Controls.Add(this.labelListaVertical);
            this.groupPresentacion.Controls.Add(this.radioListaVertical);
            this.groupPresentacion.Controls.Add(this.textTitulo);
            this.groupPresentacion.Location = new System.Drawing.Point(15, 25);
            this.groupPresentacion.Name = "groupPresentacion";
            this.groupPresentacion.Size = new System.Drawing.Size(225, 260);
            this.groupPresentacion.TabIndex = 2;
            this.groupPresentacion.TabStop = false;
            this.groupPresentacion.Text = "Presentación de la solución";
            // 
            // pictureImprimirComentarios
            // 
            this.pictureImprimirComentarios.Image = global::TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96;
            this.pictureImprimirComentarios.Location = new System.Drawing.Point(160, 224);
            this.pictureImprimirComentarios.Name = "pictureImprimirComentarios";
            this.pictureImprimirComentarios.Size = new System.Drawing.Size(35, 30);
            this.pictureImprimirComentarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImprimirComentarios.TabIndex = 31;
            this.pictureImprimirComentarios.TabStop = false;
            this.pictureImprimirComentarios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureImprimirComentarios_MouseDown);
            // 
            // labelImprimirComentarios
            // 
            this.labelImprimirComentarios.AutoSize = true;
            this.labelImprimirComentarios.Location = new System.Drawing.Point(12, 225);
            this.labelImprimirComentarios.Name = "labelImprimirComentarios";
            this.labelImprimirComentarios.Size = new System.Drawing.Size(142, 26);
            this.labelImprimirComentarios.TabIndex = 29;
            this.labelImprimirComentarios.Text = "Imprimir comentarios de\r\nrespuestas correctas (%%&&&&)";
            // 
            // labelColumnas
            // 
            this.labelColumnas.AutoSize = true;
            this.labelColumnas.Location = new System.Drawing.Point(40, 180);
            this.labelColumnas.Name = "labelColumnas";
            this.labelColumnas.Size = new System.Drawing.Size(142, 26);
            this.labelColumnas.TabIndex = 28;
            this.labelColumnas.Text = "1. a       3. a       5. c       7. a\r\n2. b       4. c       6. d       8. c";
            // 
            // numericColumnas
            // 
            this.numericColumnas.Location = new System.Drawing.Point(88, 153);
            this.numericColumnas.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericColumnas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericColumnas.Name = "numericColumnas";
            this.numericColumnas.Size = new System.Drawing.Size(35, 20);
            this.numericColumnas.TabIndex = 27;
            this.numericColumnas.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // radioColumnas
            // 
            this.radioColumnas.AutoSize = true;
            this.radioColumnas.Location = new System.Drawing.Point(15, 153);
            this.radioColumnas.Name = "radioColumnas";
            this.radioColumnas.Size = new System.Drawing.Size(71, 17);
            this.radioColumnas.TabIndex = 26;
            this.radioColumnas.Text = "Columnas";
            this.radioColumnas.UseVisualStyleBackColor = true;
            // 
            // textListaHorizontalComodin
            // 
            this.textListaHorizontalComodin.Location = new System.Drawing.Point(61, 127);
            this.textListaHorizontalComodin.Name = "textListaHorizontalComodin";
            this.textListaHorizontalComodin.Size = new System.Drawing.Size(25, 20);
            this.textListaHorizontalComodin.TabIndex = 25;
            // 
            // labelListaHorizontalB
            // 
            this.labelListaHorizontalB.AutoSize = true;
            this.labelListaHorizontalB.Location = new System.Drawing.Point(92, 130);
            this.labelListaHorizontalB.Name = "labelListaHorizontalB";
            this.labelListaHorizontalB.Size = new System.Drawing.Size(25, 13);
            this.labelListaHorizontalB.TabIndex = 24;
            this.labelListaHorizontalB.Text = "2. b";
            // 
            // labelListaHorizontalA
            // 
            this.labelListaHorizontalA.AutoSize = true;
            this.labelListaHorizontalA.Location = new System.Drawing.Point(35, 130);
            this.labelListaHorizontalA.Name = "labelListaHorizontalA";
            this.labelListaHorizontalA.Size = new System.Drawing.Size(25, 13);
            this.labelListaHorizontalA.TabIndex = 23;
            this.labelListaHorizontalA.Text = "1. a";
            // 
            // radioListaHorizontal
            // 
            this.radioListaHorizontal.AutoSize = true;
            this.radioListaHorizontal.Location = new System.Drawing.Point(15, 110);
            this.radioListaHorizontal.Name = "radioListaHorizontal";
            this.radioListaHorizontal.Size = new System.Drawing.Size(95, 17);
            this.radioListaHorizontal.TabIndex = 22;
            this.radioListaHorizontal.Text = "Lista horizontal";
            this.radioListaHorizontal.UseVisualStyleBackColor = true;
            // 
            // labelListaVertical
            // 
            this.labelListaVertical.AutoSize = true;
            this.labelListaVertical.Location = new System.Drawing.Point(35, 75);
            this.labelListaVertical.Name = "labelListaVertical";
            this.labelListaVertical.Size = new System.Drawing.Size(25, 26);
            this.labelListaVertical.TabIndex = 21;
            this.labelListaVertical.Text = "1. a\r\n2. b";
            // 
            // radioListaVertical
            // 
            this.radioListaVertical.AutoSize = true;
            this.radioListaVertical.Checked = true;
            this.radioListaVertical.Location = new System.Drawing.Point(15, 55);
            this.radioListaVertical.Name = "radioListaVertical";
            this.radioListaVertical.Size = new System.Drawing.Size(84, 17);
            this.radioListaVertical.TabIndex = 20;
            this.radioListaVertical.TabStop = true;
            this.radioListaVertical.Text = "Lista vertical";
            this.radioListaVertical.UseVisualStyleBackColor = true;
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(15, 25);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(180, 20);
            this.textTitulo.TabIndex = 0;
            this.textTitulo.Text = "SOLUCIONARIO";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 430);
            this.Controls.Add(this.groupImpresion);
            this.Controls.Add(this.groupPresentacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.groupImpresion.ResumeLayout(false);
            this.groupImpresion.PerformLayout();
            this.groupPresentacion.ResumeLayout(false);
            this.groupPresentacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImprimirComentarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumnas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupImpresion;
        private System.Windows.Forms.RadioButton radioImprimirAlFinalExamen;
        private System.Windows.Forms.RadioButton radioImprimirArchivoSeparado;
        private System.Windows.Forms.RadioButton radioNoImprimir;
        private System.Windows.Forms.GroupBox groupPresentacion;
        private System.Windows.Forms.PictureBox pictureImprimirComentarios;
        private System.Windows.Forms.Label labelImprimirComentarios;
        private System.Windows.Forms.Label labelColumnas;
        private System.Windows.Forms.NumericUpDown numericColumnas;
        private System.Windows.Forms.RadioButton radioColumnas;
        private System.Windows.Forms.TextBox textListaHorizontalComodin;
        private System.Windows.Forms.Label labelListaHorizontalB;
        private System.Windows.Forms.Label labelListaHorizontalA;
        private System.Windows.Forms.RadioButton radioListaHorizontal;
        private System.Windows.Forms.Label labelListaVertical;
        private System.Windows.Forms.RadioButton radioListaVertical;
        private System.Windows.Forms.TextBox textTitulo;
    }
}