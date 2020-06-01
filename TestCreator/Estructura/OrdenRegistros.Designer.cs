namespace TestCreator.Estructura
{
    partial class OrdenRegistros
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.radioButtonAzar = new System.Windows.Forms.RadioButton();
            this.radioButtonAscendente = new System.Windows.Forms.RadioButton();
            this.radioButtonDescendente = new System.Windows.Forms.RadioButton();
            this.radioButtonOrdenOriginal = new System.Windows.Forms.RadioButton();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(118, 39);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Elegir una opción \r\npara cambiar todos \r\nlos registros.";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseMove);
            // 
            // radioButtonAzar
            // 
            this.radioButtonAzar.AutoSize = true;
            this.radioButtonAzar.Location = new System.Drawing.Point(12, 47);
            this.radioButtonAzar.Name = "radioButtonAzar";
            this.radioButtonAzar.Size = new System.Drawing.Size(46, 17);
            this.radioButtonAzar.TabIndex = 1;
            this.radioButtonAzar.TabStop = true;
            this.radioButtonAzar.Text = "Azar";
            this.radioButtonAzar.UseVisualStyleBackColor = true;
            // 
            // radioButtonAscendente
            // 
            this.radioButtonAscendente.AutoSize = true;
            this.radioButtonAscendente.Location = new System.Drawing.Point(12, 70);
            this.radioButtonAscendente.Name = "radioButtonAscendente";
            this.radioButtonAscendente.Size = new System.Drawing.Size(82, 17);
            this.radioButtonAscendente.TabIndex = 2;
            this.radioButtonAscendente.TabStop = true;
            this.radioButtonAscendente.Text = "Ascendente";
            this.radioButtonAscendente.UseVisualStyleBackColor = true;
            // 
            // radioButtonDescendente
            // 
            this.radioButtonDescendente.AutoSize = true;
            this.radioButtonDescendente.Location = new System.Drawing.Point(12, 93);
            this.radioButtonDescendente.Name = "radioButtonDescendente";
            this.radioButtonDescendente.Size = new System.Drawing.Size(89, 17);
            this.radioButtonDescendente.TabIndex = 3;
            this.radioButtonDescendente.TabStop = true;
            this.radioButtonDescendente.Text = "Descendente";
            this.radioButtonDescendente.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrdenOriginal
            // 
            this.radioButtonOrdenOriginal.AutoSize = true;
            this.radioButtonOrdenOriginal.Location = new System.Drawing.Point(12, 116);
            this.radioButtonOrdenOriginal.Name = "radioButtonOrdenOriginal";
            this.radioButtonOrdenOriginal.Size = new System.Drawing.Size(90, 17);
            this.radioButtonOrdenOriginal.TabIndex = 4;
            this.radioButtonOrdenOriginal.TabStop = true;
            this.radioButtonOrdenOriginal.Text = "Orden original";
            this.radioButtonOrdenOriginal.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(5, 146);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(60, 23);
            this.buttonAceptar.TabIndex = 5;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(69, 146);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(60, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackgroundImage = global::TestCreator.Properties.Resources.icons8_cerrar_ventana_26;
            this.buttonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCerrar.Location = new System.Drawing.Point(116, 1);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(16, 16);
            this.buttonCerrar.TabIndex = 7;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            // 
            // OrdenRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(134, 181);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.radioButtonOrdenOriginal);
            this.Controls.Add(this.radioButtonDescendente);
            this.Controls.Add(this.radioButtonAscendente);
            this.Controls.Add(this.radioButtonAzar);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdenRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OrdenRegistros_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OrdenRegistros_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton radioButtonAzar;
        private System.Windows.Forms.RadioButton radioButtonAscendente;
        private System.Windows.Forms.RadioButton radioButtonDescendente;
        private System.Windows.Forms.RadioButton radioButtonOrdenOriginal;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonCerrar;
    }
}