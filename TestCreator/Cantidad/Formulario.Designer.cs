namespace TestCreator.Cantidad
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
            this.groupIdentificacionDeExamenesIDE = new System.Windows.Forms.GroupBox();
            this.pictureboxIdentificarExamenesIDE = new System.Windows.Forms.PictureBox();
            this.groupJustificacionIDE = new System.Windows.Forms.GroupBox();
            this.radioDerechaIDE = new System.Windows.Forms.RadioButton();
            this.radioCentroIDE = new System.Windows.Forms.RadioButton();
            this.radioIzquierdaIDE = new System.Windows.Forms.RadioButton();
            this.groupUbicacionIDE = new System.Windows.Forms.GroupBox();
            this.radioPieIDE = new System.Windows.Forms.RadioButton();
            this.radioInicioIDE = new System.Windows.Forms.RadioButton();
            this.radioEncabezadoIDE = new System.Windows.Forms.RadioButton();
            this.textboxIdentificarCopia = new System.Windows.Forms.TextBox();
            this.labeIdentificarCopia = new System.Windows.Forms.Label();
            this.textboxExamenIDE = new System.Windows.Forms.TextBox();
            this.labelExamenIDE = new System.Windows.Forms.Label();
            this.labelIdentificarExamanesIDE = new System.Windows.Forms.Label();
            this.groupCantidadDeExamenesCDE = new System.Windows.Forms.GroupBox();
            this.labelTotalExamanesCopiasCDE = new System.Windows.Forms.Label();
            this.groupCopiasCDE = new System.Windows.Forms.GroupBox();
            this.checkRespuestasAleatoeriasCDE = new System.Windows.Forms.CheckBox();
            this.checkPreguntasAleatoeriasCDE = new System.Windows.Forms.CheckBox();
            this.numericCopiasCDE = new System.Windows.Forms.NumericUpDown();
            this.radioNuevasPreguntasCDE = new System.Windows.Forms.RadioButton();
            this.radioCualquierPreguntaCDE = new System.Windows.Forms.RadioButton();
            this.numericExamenesCDE = new System.Windows.Forms.NumericUpDown();
            this.labelExamenesCDE = new System.Windows.Forms.Label();
            this.groupIdentificacionDeExamenesIDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxIdentificarExamenesIDE)).BeginInit();
            this.groupJustificacionIDE.SuspendLayout();
            this.groupUbicacionIDE.SuspendLayout();
            this.groupCantidadDeExamenesCDE.SuspendLayout();
            this.groupCopiasCDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCopiasCDE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExamenesCDE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupIdentificacionDeExamenesIDE
            // 
            this.groupIdentificacionDeExamenesIDE.Controls.Add(this.pictureboxIdentificarExamenesIDE);
            this.groupIdentificacionDeExamenesIDE.Controls.Add(this.groupJustificacionIDE);
            this.groupIdentificacionDeExamenesIDE.Controls.Add(this.groupUbicacionIDE);
            this.groupIdentificacionDeExamenesIDE.Controls.Add(this.textboxIdentificarCopia);
            this.groupIdentificacionDeExamenesIDE.Controls.Add(this.labeIdentificarCopia);
            this.groupIdentificacionDeExamenesIDE.Controls.Add(this.textboxExamenIDE);
            this.groupIdentificacionDeExamenesIDE.Controls.Add(this.labelExamenIDE);
            this.groupIdentificacionDeExamenesIDE.Controls.Add(this.labelIdentificarExamanesIDE);
            this.groupIdentificacionDeExamenesIDE.Location = new System.Drawing.Point(301, 25);
            this.groupIdentificacionDeExamenesIDE.Name = "groupIdentificacionDeExamenesIDE";
            this.groupIdentificacionDeExamenesIDE.Size = new System.Drawing.Size(260, 250);
            this.groupIdentificacionDeExamenesIDE.TabIndex = 3;
            this.groupIdentificacionDeExamenesIDE.TabStop = false;
            this.groupIdentificacionDeExamenesIDE.Text = "Identificación de exámenes";
            // 
            // pictureboxIdentificarExamenesIDE
            // 
            this.pictureboxIdentificarExamenesIDE.Image = global::TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96;
            this.pictureboxIdentificarExamenesIDE.Location = new System.Drawing.Point(130, 17);
            this.pictureboxIdentificarExamenesIDE.Name = "pictureboxIdentificarExamenesIDE";
            this.pictureboxIdentificarExamenesIDE.Size = new System.Drawing.Size(35, 30);
            this.pictureboxIdentificarExamenesIDE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxIdentificarExamenesIDE.TabIndex = 9;
            this.pictureboxIdentificarExamenesIDE.TabStop = false;
            this.pictureboxIdentificarExamenesIDE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureboxIdentificarExamenesIDE_MouseDown);
            // 
            // groupJustificacionIDE
            // 
            this.groupJustificacionIDE.Controls.Add(this.radioDerechaIDE);
            this.groupJustificacionIDE.Controls.Add(this.radioCentroIDE);
            this.groupJustificacionIDE.Controls.Add(this.radioIzquierdaIDE);
            this.groupJustificacionIDE.Location = new System.Drawing.Point(25, 188);
            this.groupJustificacionIDE.Name = "groupJustificacionIDE";
            this.groupJustificacionIDE.Size = new System.Drawing.Size(220, 56);
            this.groupJustificacionIDE.TabIndex = 8;
            this.groupJustificacionIDE.TabStop = false;
            this.groupJustificacionIDE.Text = "Justificación";
            // 
            // radioDerechaIDE
            // 
            this.radioDerechaIDE.AutoSize = true;
            this.radioDerechaIDE.Location = new System.Drawing.Point(146, 25);
            this.radioDerechaIDE.Name = "radioDerechaIDE";
            this.radioDerechaIDE.Size = new System.Drawing.Size(66, 17);
            this.radioDerechaIDE.TabIndex = 3;
            this.radioDerechaIDE.TabStop = true;
            this.radioDerechaIDE.Text = "Derecha";
            this.radioDerechaIDE.UseVisualStyleBackColor = true;
            // 
            // radioCentroIDE
            // 
            this.radioCentroIDE.AutoSize = true;
            this.radioCentroIDE.Location = new System.Drawing.Point(84, 25);
            this.radioCentroIDE.Name = "radioCentroIDE";
            this.radioCentroIDE.Size = new System.Drawing.Size(56, 17);
            this.radioCentroIDE.TabIndex = 2;
            this.radioCentroIDE.TabStop = true;
            this.radioCentroIDE.Text = "Centro";
            this.radioCentroIDE.UseVisualStyleBackColor = true;
            // 
            // radioIzquierdaIDE
            // 
            this.radioIzquierdaIDE.AutoSize = true;
            this.radioIzquierdaIDE.Checked = true;
            this.radioIzquierdaIDE.Location = new System.Drawing.Point(10, 25);
            this.radioIzquierdaIDE.Name = "radioIzquierdaIDE";
            this.radioIzquierdaIDE.Size = new System.Drawing.Size(68, 17);
            this.radioIzquierdaIDE.TabIndex = 1;
            this.radioIzquierdaIDE.TabStop = true;
            this.radioIzquierdaIDE.Text = "Izquierda";
            this.radioIzquierdaIDE.UseVisualStyleBackColor = true;
            // 
            // groupUbicacionIDE
            // 
            this.groupUbicacionIDE.Controls.Add(this.radioPieIDE);
            this.groupUbicacionIDE.Controls.Add(this.radioInicioIDE);
            this.groupUbicacionIDE.Controls.Add(this.radioEncabezadoIDE);
            this.groupUbicacionIDE.Location = new System.Drawing.Point(23, 72);
            this.groupUbicacionIDE.Name = "groupUbicacionIDE";
            this.groupUbicacionIDE.Size = new System.Drawing.Size(220, 110);
            this.groupUbicacionIDE.TabIndex = 7;
            this.groupUbicacionIDE.TabStop = false;
            this.groupUbicacionIDE.Text = "Ubicación en la página";
            // 
            // radioPieIDE
            // 
            this.radioPieIDE.AutoSize = true;
            this.radioPieIDE.Location = new System.Drawing.Point(10, 71);
            this.radioPieIDE.Name = "radioPieIDE";
            this.radioPieIDE.Size = new System.Drawing.Size(40, 17);
            this.radioPieIDE.TabIndex = 2;
            this.radioPieIDE.Text = "Pie";
            this.radioPieIDE.UseVisualStyleBackColor = true;
            // 
            // radioInicioIDE
            // 
            this.radioInicioIDE.AutoSize = true;
            this.radioInicioIDE.Location = new System.Drawing.Point(10, 48);
            this.radioInicioIDE.Name = "radioInicioIDE";
            this.radioInicioIDE.Size = new System.Drawing.Size(115, 17);
            this.radioInicioIDE.TabIndex = 1;
            this.radioInicioIDE.Text = "Inicio de preguntas";
            this.radioInicioIDE.UseVisualStyleBackColor = true;
            // 
            // radioEncabezadoIDE
            // 
            this.radioEncabezadoIDE.AutoSize = true;
            this.radioEncabezadoIDE.Checked = true;
            this.radioEncabezadoIDE.Location = new System.Drawing.Point(10, 25);
            this.radioEncabezadoIDE.Name = "radioEncabezadoIDE";
            this.radioEncabezadoIDE.Size = new System.Drawing.Size(85, 17);
            this.radioEncabezadoIDE.TabIndex = 0;
            this.radioEncabezadoIDE.TabStop = true;
            this.radioEncabezadoIDE.Text = "Encabezado";
            this.radioEncabezadoIDE.UseVisualStyleBackColor = true;
            // 
            // textboxIdentificarCopia
            // 
            this.textboxIdentificarCopia.Location = new System.Drawing.Point(167, 46);
            this.textboxIdentificarCopia.Name = "textboxIdentificarCopia";
            this.textboxIdentificarCopia.Size = new System.Drawing.Size(40, 20);
            this.textboxIdentificarCopia.TabIndex = 6;
            this.textboxIdentificarCopia.Text = "COP-";
            this.textboxIdentificarCopia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labeIdentificarCopia
            // 
            this.labeIdentificarCopia.AutoSize = true;
            this.labeIdentificarCopia.Location = new System.Drawing.Point(127, 49);
            this.labeIdentificarCopia.Name = "labeIdentificarCopia";
            this.labeIdentificarCopia.Size = new System.Drawing.Size(34, 13);
            this.labeIdentificarCopia.TabIndex = 5;
            this.labeIdentificarCopia.Text = "Copia";
            // 
            // textboxExamenIDE
            // 
            this.textboxExamenIDE.Location = new System.Drawing.Point(71, 46);
            this.textboxExamenIDE.Name = "textboxExamenIDE";
            this.textboxExamenIDE.Size = new System.Drawing.Size(40, 20);
            this.textboxExamenIDE.TabIndex = 4;
            this.textboxExamenIDE.Text = "EX-";
            this.textboxExamenIDE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelExamenIDE
            // 
            this.labelExamenIDE.AutoSize = true;
            this.labelExamenIDE.Location = new System.Drawing.Point(20, 49);
            this.labelExamenIDE.Name = "labelExamenIDE";
            this.labelExamenIDE.Size = new System.Drawing.Size(45, 13);
            this.labelExamenIDE.TabIndex = 3;
            this.labelExamenIDE.Text = "Examen";
            // 
            // labelIdentificarExamanesIDE
            // 
            this.labelIdentificarExamanesIDE.AutoSize = true;
            this.labelIdentificarExamanesIDE.Location = new System.Drawing.Point(20, 25);
            this.labelIdentificarExamanesIDE.Name = "labelIdentificarExamanesIDE";
            this.labelIdentificarExamanesIDE.Size = new System.Drawing.Size(104, 13);
            this.labelIdentificarExamanesIDE.TabIndex = 1;
            this.labelIdentificarExamanesIDE.Text = "Identificar exámenes";
            // 
            // groupCantidadDeExamenesCDE
            // 
            this.groupCantidadDeExamenesCDE.Controls.Add(this.labelTotalExamanesCopiasCDE);
            this.groupCantidadDeExamenesCDE.Controls.Add(this.groupCopiasCDE);
            this.groupCantidadDeExamenesCDE.Controls.Add(this.radioNuevasPreguntasCDE);
            this.groupCantidadDeExamenesCDE.Controls.Add(this.radioCualquierPreguntaCDE);
            this.groupCantidadDeExamenesCDE.Controls.Add(this.numericExamenesCDE);
            this.groupCantidadDeExamenesCDE.Controls.Add(this.labelExamenesCDE);
            this.groupCantidadDeExamenesCDE.Location = new System.Drawing.Point(15, 25);
            this.groupCantidadDeExamenesCDE.Name = "groupCantidadDeExamenesCDE";
            this.groupCantidadDeExamenesCDE.Size = new System.Drawing.Size(250, 250);
            this.groupCantidadDeExamenesCDE.TabIndex = 2;
            this.groupCantidadDeExamenesCDE.TabStop = false;
            this.groupCantidadDeExamenesCDE.Text = "Cantidad de exámenes";
            // 
            // labelTotalExamanesCopiasCDE
            // 
            this.labelTotalExamanesCopiasCDE.AutoSize = true;
            this.labelTotalExamanesCopiasCDE.Location = new System.Drawing.Point(10, 215);
            this.labelTotalExamanesCopiasCDE.Name = "labelTotalExamanesCopiasCDE";
            this.labelTotalExamanesCopiasCDE.Size = new System.Drawing.Size(180, 13);
            this.labelTotalExamanesCopiasCDE.TabIndex = 5;
            this.labelTotalExamanesCopiasCDE.Text = "Total de exámenes ( ) y copias ( ) = x";
            // 
            // groupCopiasCDE
            // 
            this.groupCopiasCDE.Controls.Add(this.checkRespuestasAleatoeriasCDE);
            this.groupCopiasCDE.Controls.Add(this.checkPreguntasAleatoeriasCDE);
            this.groupCopiasCDE.Controls.Add(this.numericCopiasCDE);
            this.groupCopiasCDE.Location = new System.Drawing.Point(23, 95);
            this.groupCopiasCDE.Name = "groupCopiasCDE";
            this.groupCopiasCDE.Size = new System.Drawing.Size(211, 110);
            this.groupCopiasCDE.TabIndex = 4;
            this.groupCopiasCDE.TabStop = false;
            this.groupCopiasCDE.Text = "Copias";
            // 
            // checkRespuestasAleatoeriasCDE
            // 
            this.checkRespuestasAleatoeriasCDE.AutoSize = true;
            this.checkRespuestasAleatoeriasCDE.Checked = true;
            this.checkRespuestasAleatoeriasCDE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRespuestasAleatoeriasCDE.Location = new System.Drawing.Point(10, 74);
            this.checkRespuestasAleatoeriasCDE.Name = "checkRespuestasAleatoeriasCDE";
            this.checkRespuestasAleatoeriasCDE.Size = new System.Drawing.Size(130, 17);
            this.checkRespuestasAleatoeriasCDE.TabIndex = 4;
            this.checkRespuestasAleatoeriasCDE.Text = "Respuestas aleatorias";
            this.checkRespuestasAleatoeriasCDE.UseVisualStyleBackColor = true;
            // 
            // checkPreguntasAleatoeriasCDE
            // 
            this.checkPreguntasAleatoeriasCDE.AutoSize = true;
            this.checkPreguntasAleatoeriasCDE.Checked = true;
            this.checkPreguntasAleatoeriasCDE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPreguntasAleatoeriasCDE.Location = new System.Drawing.Point(10, 51);
            this.checkPreguntasAleatoeriasCDE.Name = "checkPreguntasAleatoeriasCDE";
            this.checkPreguntasAleatoeriasCDE.Size = new System.Drawing.Size(122, 17);
            this.checkPreguntasAleatoeriasCDE.TabIndex = 3;
            this.checkPreguntasAleatoeriasCDE.Text = "Preguntas aleatorias";
            this.checkPreguntasAleatoeriasCDE.UseVisualStyleBackColor = true;
            // 
            // numericCopiasCDE
            // 
            this.numericCopiasCDE.Location = new System.Drawing.Point(10, 25);
            this.numericCopiasCDE.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCopiasCDE.Name = "numericCopiasCDE";
            this.numericCopiasCDE.Size = new System.Drawing.Size(40, 20);
            this.numericCopiasCDE.TabIndex = 2;
            this.numericCopiasCDE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCopiasCDE.ValueChanged += new System.EventHandler(this.numericCopiasCDE_ValueChanged);
            // 
            // radioNuevasPreguntasCDE
            // 
            this.radioNuevasPreguntasCDE.AutoSize = true;
            this.radioNuevasPreguntasCDE.Location = new System.Drawing.Point(23, 72);
            this.radioNuevasPreguntasCDE.Name = "radioNuevasPreguntasCDE";
            this.radioNuevasPreguntasCDE.Size = new System.Drawing.Size(112, 17);
            this.radioNuevasPreguntasCDE.TabIndex = 3;
            this.radioNuevasPreguntasCDE.Text = "Nuevas preguntas";
            this.radioNuevasPreguntasCDE.UseVisualStyleBackColor = true;
            // 
            // radioCualquierPreguntaCDE
            // 
            this.radioCualquierPreguntaCDE.AutoSize = true;
            this.radioCualquierPreguntaCDE.Checked = true;
            this.radioCualquierPreguntaCDE.Location = new System.Drawing.Point(23, 49);
            this.radioCualquierPreguntaCDE.Name = "radioCualquierPreguntaCDE";
            this.radioCualquierPreguntaCDE.Size = new System.Drawing.Size(114, 17);
            this.radioCualquierPreguntaCDE.TabIndex = 2;
            this.radioCualquierPreguntaCDE.TabStop = true;
            this.radioCualquierPreguntaCDE.Text = "Cualquier pregunta";
            this.radioCualquierPreguntaCDE.UseVisualStyleBackColor = true;
            // 
            // numericExamenesCDE
            // 
            this.numericExamenesCDE.Location = new System.Drawing.Point(82, 23);
            this.numericExamenesCDE.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericExamenesCDE.Name = "numericExamenesCDE";
            this.numericExamenesCDE.Size = new System.Drawing.Size(40, 20);
            this.numericExamenesCDE.TabIndex = 1;
            this.numericExamenesCDE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericExamenesCDE.ValueChanged += new System.EventHandler(this.numericExamenesCDE_ValueChanged);
            // 
            // labelExamenesCDE
            // 
            this.labelExamenesCDE.AutoSize = true;
            this.labelExamenesCDE.Location = new System.Drawing.Point(20, 25);
            this.labelExamenesCDE.Name = "labelExamenesCDE";
            this.labelExamenesCDE.Size = new System.Drawing.Size(56, 13);
            this.labelExamenesCDE.TabIndex = 0;
            this.labelExamenesCDE.Text = "Exámenes";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 430);
            this.Controls.Add(this.groupIdentificacionDeExamenesIDE);
            this.Controls.Add(this.groupCantidadDeExamenesCDE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.groupIdentificacionDeExamenesIDE.ResumeLayout(false);
            this.groupIdentificacionDeExamenesIDE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxIdentificarExamenesIDE)).EndInit();
            this.groupJustificacionIDE.ResumeLayout(false);
            this.groupJustificacionIDE.PerformLayout();
            this.groupUbicacionIDE.ResumeLayout(false);
            this.groupUbicacionIDE.PerformLayout();
            this.groupCantidadDeExamenesCDE.ResumeLayout(false);
            this.groupCantidadDeExamenesCDE.PerformLayout();
            this.groupCopiasCDE.ResumeLayout(false);
            this.groupCopiasCDE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCopiasCDE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExamenesCDE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupIdentificacionDeExamenesIDE;
        private System.Windows.Forms.PictureBox pictureboxIdentificarExamenesIDE;
        private System.Windows.Forms.GroupBox groupJustificacionIDE;
        private System.Windows.Forms.RadioButton radioDerechaIDE;
        private System.Windows.Forms.RadioButton radioCentroIDE;
        private System.Windows.Forms.RadioButton radioIzquierdaIDE;
        private System.Windows.Forms.GroupBox groupUbicacionIDE;
        private System.Windows.Forms.RadioButton radioPieIDE;
        private System.Windows.Forms.RadioButton radioInicioIDE;
        private System.Windows.Forms.RadioButton radioEncabezadoIDE;
        private System.Windows.Forms.TextBox textboxIdentificarCopia;
        private System.Windows.Forms.Label labeIdentificarCopia;
        private System.Windows.Forms.TextBox textboxExamenIDE;
        private System.Windows.Forms.Label labelExamenIDE;
        private System.Windows.Forms.Label labelIdentificarExamanesIDE;
        private System.Windows.Forms.GroupBox groupCantidadDeExamenesCDE;
        private System.Windows.Forms.Label labelTotalExamanesCopiasCDE;
        private System.Windows.Forms.GroupBox groupCopiasCDE;
        private System.Windows.Forms.CheckBox checkRespuestasAleatoeriasCDE;
        private System.Windows.Forms.CheckBox checkPreguntasAleatoeriasCDE;
        private System.Windows.Forms.NumericUpDown numericCopiasCDE;
        private System.Windows.Forms.RadioButton radioNuevasPreguntasCDE;
        private System.Windows.Forms.RadioButton radioCualquierPreguntaCDE;
        private System.Windows.Forms.NumericUpDown numericExamenesCDE;
        private System.Windows.Forms.Label labelExamenesCDE;
    }
}