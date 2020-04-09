namespace TestCreator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.checkUnArchivoPorExamen = new System.Windows.Forms.CheckBox();
            this.checkPdf = new System.Windows.Forms.CheckBox();
            this.checkReemplazarExamen = new System.Windows.Forms.CheckBox();
            this.checkAbrirExamen = new System.Windows.Forms.CheckBox();
            this.buttonGenerarExamen = new System.Windows.Forms.Button();
            this.buttonGuardarCondiciones = new System.Windows.Forms.Button();
            this.buttonAbrirCondiciones = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.SplitContainer();
            this.buttonEstructura = new System.Windows.Forms.Button();
            this.buttonCantidad = new System.Windows.Forms.Button();
            this.buttonNumeracion = new System.Windows.Forms.Button();
            this.buttonSolucion = new System.Windows.Forms.Button();
            this.buttonExamen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkUnArchivoPorExamen
            // 
            this.checkUnArchivoPorExamen.AutoSize = true;
            this.checkUnArchivoPorExamen.Location = new System.Drawing.Point(628, 520);
            this.checkUnArchivoPorExamen.Margin = new System.Windows.Forms.Padding(2);
            this.checkUnArchivoPorExamen.Name = "checkUnArchivoPorExamen";
            this.checkUnArchivoPorExamen.Size = new System.Drawing.Size(136, 17);
            this.checkUnArchivoPorExamen.TabIndex = 14;
            this.checkUnArchivoPorExamen.Text = "Un archivo por examen";
            this.checkUnArchivoPorExamen.UseVisualStyleBackColor = true;
            // 
            // checkPdf
            // 
            this.checkPdf.AutoSize = true;
            this.checkPdf.Location = new System.Drawing.Point(628, 500);
            this.checkPdf.Margin = new System.Windows.Forms.Padding(2);
            this.checkPdf.Name = "checkPdf";
            this.checkPdf.Size = new System.Drawing.Size(47, 17);
            this.checkPdf.TabIndex = 13;
            this.checkPdf.Text = "PDF";
            this.checkPdf.UseVisualStyleBackColor = true;
            // 
            // checkReemplazarExamen
            // 
            this.checkReemplazarExamen.AutoSize = true;
            this.checkReemplazarExamen.Checked = true;
            this.checkReemplazarExamen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkReemplazarExamen.Location = new System.Drawing.Point(491, 520);
            this.checkReemplazarExamen.Margin = new System.Windows.Forms.Padding(2);
            this.checkReemplazarExamen.Name = "checkReemplazarExamen";
            this.checkReemplazarExamen.Size = new System.Drawing.Size(122, 17);
            this.checkReemplazarExamen.TabIndex = 12;
            this.checkReemplazarExamen.Text = "Reemplazar examen";
            this.checkReemplazarExamen.UseVisualStyleBackColor = true;
            // 
            // checkAbrirExamen
            // 
            this.checkAbrirExamen.AutoSize = true;
            this.checkAbrirExamen.Checked = true;
            this.checkAbrirExamen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAbrirExamen.Location = new System.Drawing.Point(491, 500);
            this.checkAbrirExamen.Margin = new System.Windows.Forms.Padding(2);
            this.checkAbrirExamen.Name = "checkAbrirExamen";
            this.checkAbrirExamen.Size = new System.Drawing.Size(87, 17);
            this.checkAbrirExamen.TabIndex = 11;
            this.checkAbrirExamen.Text = "Abrir examen";
            this.checkAbrirExamen.UseVisualStyleBackColor = true;
            // 
            // buttonGenerarExamen
            // 
            this.buttonGenerarExamen.Location = new System.Drawing.Point(338, 503);
            this.buttonGenerarExamen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerarExamen.Name = "buttonGenerarExamen";
            this.buttonGenerarExamen.Size = new System.Drawing.Size(133, 29);
            this.buttonGenerarExamen.TabIndex = 10;
            this.buttonGenerarExamen.Text = "Generar examen";
            this.buttonGenerarExamen.UseVisualStyleBackColor = true;
            // 
            // buttonGuardarCondiciones
            // 
            this.buttonGuardarCondiciones.Location = new System.Drawing.Point(11, 521);
            this.buttonGuardarCondiciones.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardarCondiciones.Name = "buttonGuardarCondiciones";
            this.buttonGuardarCondiciones.Size = new System.Drawing.Size(133, 29);
            this.buttonGuardarCondiciones.TabIndex = 9;
            this.buttonGuardarCondiciones.Text = "Guardar condiciones";
            this.buttonGuardarCondiciones.UseVisualStyleBackColor = true;
            // 
            // buttonAbrirCondiciones
            // 
            this.buttonAbrirCondiciones.Location = new System.Drawing.Point(11, 484);
            this.buttonAbrirCondiciones.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAbrirCondiciones.Name = "buttonAbrirCondiciones";
            this.buttonAbrirCondiciones.Size = new System.Drawing.Size(133, 29);
            this.buttonAbrirCondiciones.TabIndex = 8;
            this.buttonAbrirCondiciones.Text = "Abrir condiciones";
            this.buttonAbrirCondiciones.UseVisualStyleBackColor = true;
            // 
            // container
            // 
            this.container.IsSplitterFixed = true;
            this.container.Location = new System.Drawing.Point(11, 12);
            this.container.Name = "container";
            this.container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // container.Panel1
            // 
            this.container.Panel1.Controls.Add(this.buttonExamen);
            this.container.Panel1.Controls.Add(this.buttonSolucion);
            this.container.Panel1.Controls.Add(this.buttonNumeracion);
            this.container.Panel1.Controls.Add(this.buttonCantidad);
            this.container.Panel1.Controls.Add(this.buttonEstructura);
            this.container.Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // container.Panel2
            // 
            this.container.Panel2.BackColor = System.Drawing.Color.White;
            this.container.Size = new System.Drawing.Size(771, 467);
            this.container.SplitterDistance = 33;
            this.container.TabIndex = 15;
            // 
            // buttonEstructura
            // 
            this.buttonEstructura.Location = new System.Drawing.Point(5, 3);
            this.buttonEstructura.Name = "buttonEstructura";
            this.buttonEstructura.Size = new System.Drawing.Size(150, 33);
            this.buttonEstructura.TabIndex = 0;
            this.buttonEstructura.Text = "Estructura";
            this.buttonEstructura.UseVisualStyleBackColor = true;
            this.buttonEstructura.Click += new System.EventHandler(this.buttonEstructura_Click);
            // 
            // buttonCantidad
            // 
            this.buttonCantidad.Location = new System.Drawing.Point(155, 3);
            this.buttonCantidad.Name = "buttonCantidad";
            this.buttonCantidad.Size = new System.Drawing.Size(150, 33);
            this.buttonCantidad.TabIndex = 1;
            this.buttonCantidad.Text = "Cantidad";
            this.buttonCantidad.UseVisualStyleBackColor = true;
            this.buttonCantidad.Click += new System.EventHandler(this.buttonCantidad_Click);
            // 
            // buttonNumeracion
            // 
            this.buttonNumeracion.Location = new System.Drawing.Point(305, 3);
            this.buttonNumeracion.Name = "buttonNumeracion";
            this.buttonNumeracion.Size = new System.Drawing.Size(150, 33);
            this.buttonNumeracion.TabIndex = 2;
            this.buttonNumeracion.Text = "Numeración";
            this.buttonNumeracion.UseVisualStyleBackColor = true;
            this.buttonNumeracion.Click += new System.EventHandler(this.buttonNumeracion_Click);
            // 
            // buttonSolucion
            // 
            this.buttonSolucion.Location = new System.Drawing.Point(455, 3);
            this.buttonSolucion.Name = "buttonSolucion";
            this.buttonSolucion.Size = new System.Drawing.Size(150, 33);
            this.buttonSolucion.TabIndex = 3;
            this.buttonSolucion.Text = "Solución";
            this.buttonSolucion.UseVisualStyleBackColor = true;
            this.buttonSolucion.Click += new System.EventHandler(this.buttonSolucion_Click);
            // 
            // buttonExamen
            // 
            this.buttonExamen.Location = new System.Drawing.Point(605, 3);
            this.buttonExamen.Name = "buttonExamen";
            this.buttonExamen.Size = new System.Drawing.Size(150, 33);
            this.buttonExamen.TabIndex = 4;
            this.buttonExamen.Text = "Examen";
            this.buttonExamen.UseVisualStyleBackColor = true;
            this.buttonExamen.Click += new System.EventHandler(this.buttonExamen_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 561);
            this.Controls.Add(this.container);
            this.Controls.Add(this.checkUnArchivoPorExamen);
            this.Controls.Add(this.checkPdf);
            this.Controls.Add(this.checkReemplazarExamen);
            this.Controls.Add(this.checkAbrirExamen);
            this.Controls.Add(this.buttonGenerarExamen);
            this.Controls.Add(this.buttonGuardarCondiciones);
            this.Controls.Add(this.buttonAbrirCondiciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creador de Examenes";
            this.container.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkUnArchivoPorExamen;
        private System.Windows.Forms.CheckBox checkPdf;
        private System.Windows.Forms.CheckBox checkReemplazarExamen;
        private System.Windows.Forms.CheckBox checkAbrirExamen;
        private System.Windows.Forms.Button buttonGenerarExamen;
        private System.Windows.Forms.Button buttonGuardarCondiciones;
        private System.Windows.Forms.Button buttonAbrirCondiciones;
        private System.Windows.Forms.SplitContainer container;
        private System.Windows.Forms.Button buttonEstructura;
        private System.Windows.Forms.Button buttonCantidad;
        private System.Windows.Forms.Button buttonExamen;
        private System.Windows.Forms.Button buttonSolucion;
        private System.Windows.Forms.Button buttonNumeracion;
    }
}