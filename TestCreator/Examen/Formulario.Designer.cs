namespace TestCreator.Examen
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
            this.pictureLimpiarRuta = new System.Windows.Forms.PictureBox();
            this.panelPlantilla = new System.Windows.Forms.Panel();
            this.buttonExamenPreguntasDragDrop = new System.Windows.Forms.Button();
            this.comboRuta = new System.Windows.Forms.ComboBox();
            this.buttonAbrirPlantilla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLimpiarRuta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLimpiarRuta
            // 
            this.pictureLimpiarRuta.Image = global::TestCreator.Properties.Resources.icons8_eliminar_columna_500_cian;
            this.pictureLimpiarRuta.InitialImage = null;
            this.pictureLimpiarRuta.Location = new System.Drawing.Point(716, 37);
            this.pictureLimpiarRuta.Name = "pictureLimpiarRuta";
            this.pictureLimpiarRuta.Size = new System.Drawing.Size(22, 22);
            this.pictureLimpiarRuta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLimpiarRuta.TabIndex = 38;
            this.pictureLimpiarRuta.TabStop = false;
            this.pictureLimpiarRuta.Click += new System.EventHandler(this.PictureLimpiarRuta_Click);
            this.pictureLimpiarRuta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureLimpiarRuta_MouseDown);
            this.pictureLimpiarRuta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureLimpiarRuta_MouseUp);
            // 
            // panelPlantilla
            // 
            this.panelPlantilla.Location = new System.Drawing.Point(11, 64);
            this.panelPlantilla.Name = "panelPlantilla";
            this.panelPlantilla.Size = new System.Drawing.Size(719, 350);
            this.panelPlantilla.TabIndex = 37;
            // 
            // buttonExamenPreguntasDragDrop
            // 
            this.buttonExamenPreguntasDragDrop.Location = new System.Drawing.Point(235, 11);
            this.buttonExamenPreguntasDragDrop.Name = "buttonExamenPreguntasDragDrop";
            this.buttonExamenPreguntasDragDrop.Size = new System.Drawing.Size(45, 23);
            this.buttonExamenPreguntasDragDrop.TabIndex = 36;
            this.buttonExamenPreguntasDragDrop.Text = "¿...?";
            this.buttonExamenPreguntasDragDrop.UseVisualStyleBackColor = true;
            // 
            // comboRuta
            // 
            this.comboRuta.FormattingEnabled = true;
            this.comboRuta.Location = new System.Drawing.Point(11, 38);
            this.comboRuta.Margin = new System.Windows.Forms.Padding(2);
            this.comboRuta.Name = "comboRuta";
            this.comboRuta.Size = new System.Drawing.Size(704, 21);
            this.comboRuta.TabIndex = 35;
            // 
            // buttonAbrirPlantilla
            // 
            this.buttonAbrirPlantilla.Location = new System.Drawing.Point(11, 11);
            this.buttonAbrirPlantilla.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAbrirPlantilla.Name = "buttonAbrirPlantilla";
            this.buttonAbrirPlantilla.Size = new System.Drawing.Size(170, 23);
            this.buttonAbrirPlantilla.TabIndex = 34;
            this.buttonAbrirPlantilla.Text = "Abrir plantilla del examen";
            this.buttonAbrirPlantilla.UseVisualStyleBackColor = true;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 430);
            this.Controls.Add(this.pictureLimpiarRuta);
            this.Controls.Add(this.panelPlantilla);
            this.Controls.Add(this.buttonExamenPreguntasDragDrop);
            this.Controls.Add(this.comboRuta);
            this.Controls.Add(this.buttonAbrirPlantilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario";
            this.Text = "Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLimpiarRuta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLimpiarRuta;
        private System.Windows.Forms.Panel panelPlantilla;
        private System.Windows.Forms.Button buttonExamenPreguntasDragDrop;
        private System.Windows.Forms.ComboBox comboRuta;
        private System.Windows.Forms.Button buttonAbrirPlantilla;
    }
}