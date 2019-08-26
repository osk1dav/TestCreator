namespace TestCreator
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabEstructura = new System.Windows.Forms.TabPage();
            this.dataGridViewPreguntasEstructuradas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEstructurarPreguntasElegidas = new System.Windows.Forms.Button();
            this.buttonNivelesBajar = new System.Windows.Forms.Button();
            this.buttonNivelesSubir = new System.Windows.Forms.Button();
            this.buttonNivelesIncluir = new System.Windows.Forms.Button();
            this.buttonNivelesExcluir = new System.Windows.Forms.Button();
            this.listBoxExcluir = new System.Windows.Forms.ListBox();
            this.labelExcluir = new System.Windows.Forms.Label();
            this.listBoxNiveles = new System.Windows.Forms.ListBox();
            this.labelNiveles = new System.Windows.Forms.Label();
            this.listBoxElegir = new System.Windows.Forms.ListBox();
            this.labelElegir = new System.Windows.Forms.Label();
            this.buttonClasificacionItemQuitar = new System.Windows.Forms.Button();
            this.buttonClasificacionItemElegir = new System.Windows.Forms.Button();
            this.listBoxClasificacion = new System.Windows.Forms.ListBox();
            this.labelClasificacion = new System.Windows.Forms.Label();
            this.comboBoxRutaBancoPreguntas = new System.Windows.Forms.ComboBox();
            this.buttonAbrirBancoPreguntas = new System.Windows.Forms.Button();
            this.tabCantidad = new System.Windows.Forms.TabPage();
            this.tabNumeracion = new System.Windows.Forms.TabPage();
            this.tabSolucion = new System.Windows.Forms.TabPage();
            this.tabExamen = new System.Windows.Forms.TabPage();
            this.buttonAbrirCondiciones = new System.Windows.Forms.Button();
            this.buttonGuardarCondiciones = new System.Windows.Forms.Button();
            this.buttonGenerarExamen = new System.Windows.Forms.Button();
            this.checkBoxAbrirExamen = new System.Windows.Forms.CheckBox();
            this.checkBoxReemplazarExamen = new System.Windows.Forms.CheckBox();
            this.checkBoxPdf = new System.Windows.Forms.CheckBox();
            this.checkBoxUnArchivoPorExamen = new System.Windows.Forms.CheckBox();
            this.checkBoxImprimirADosCaras = new System.Windows.Forms.CheckBox();
            this.columnaOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPreguntas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaElegir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPreguntasOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaRespuestasOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCantidadDeExamenes = new System.Windows.Forms.GroupBox();
            this.groupBoxIdentificacionDeExamenes = new System.Windows.Forms.GroupBox();
            this.labelExamenes = new System.Windows.Forms.Label();
            this.numericUpDownExamenes = new System.Windows.Forms.NumericUpDown();
            this.radioButtonNuevaEleccion = new System.Windows.Forms.RadioButton();
            this.radioButtonNuevasPreguntas = new System.Windows.Forms.RadioButton();
            this.groupBoxCopias = new System.Windows.Forms.GroupBox();
            this.numericUpDownCopias = new System.Windows.Forms.NumericUpDown();
            this.checkBoxPreguntasAleatoerias = new System.Windows.Forms.CheckBox();
            this.checkBoxRespuestasAleatoerias = new System.Windows.Forms.CheckBox();
            this.labelIdentificarExamanes = new System.Windows.Forms.Label();
            this.buttonIdentificarExamenes = new System.Windows.Forms.Button();
            this.labelIdentificarExamen = new System.Windows.Forms.Label();
            this.textBoxIdentificarExamen = new System.Windows.Forms.TextBox();
            this.textBoxIdentificarCopia = new System.Windows.Forms.TextBox();
            this.labeIdentificarCopia = new System.Windows.Forms.Label();
            this.groupBoxUbicacionEnLaPagina = new System.Windows.Forms.GroupBox();
            this.radioButtonEncabezado = new System.Windows.Forms.RadioButton();
            this.radioButtonInicioDePreguntas = new System.Windows.Forms.RadioButton();
            this.radioButtonPie = new System.Windows.Forms.RadioButton();
            this.groupBoxJustificacion = new System.Windows.Forms.GroupBox();
            this.radioButtonIzquierda = new System.Windows.Forms.RadioButton();
            this.radioButtonCentro = new System.Windows.Forms.RadioButton();
            this.radioButtonDerecha = new System.Windows.Forms.RadioButton();
            this.labelTotalExamanesCopias = new System.Windows.Forms.Label();
            this.tabPrincipal.SuspendLayout();
            this.tabEstructura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreguntasEstructuradas)).BeginInit();
            this.tabCantidad.SuspendLayout();
            this.groupBoxCantidadDeExamenes.SuspendLayout();
            this.groupBoxIdentificacionDeExamenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExamenes)).BeginInit();
            this.groupBoxCopias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopias)).BeginInit();
            this.groupBoxUbicacionEnLaPagina.SuspendLayout();
            this.groupBoxJustificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabEstructura);
            this.tabPrincipal.Controls.Add(this.tabCantidad);
            this.tabPrincipal.Controls.Add(this.tabNumeracion);
            this.tabPrincipal.Controls.Add(this.tabSolucion);
            this.tabPrincipal.Controls.Add(this.tabExamen);
            this.tabPrincipal.Location = new System.Drawing.Point(8, 8);
            this.tabPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(767, 455);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabEstructura
            // 
            this.tabEstructura.Controls.Add(this.dataGridViewPreguntasEstructuradas);
            this.tabEstructura.Controls.Add(this.label5);
            this.tabEstructura.Controls.Add(this.buttonEstructurarPreguntasElegidas);
            this.tabEstructura.Controls.Add(this.buttonNivelesBajar);
            this.tabEstructura.Controls.Add(this.buttonNivelesSubir);
            this.tabEstructura.Controls.Add(this.buttonNivelesIncluir);
            this.tabEstructura.Controls.Add(this.buttonNivelesExcluir);
            this.tabEstructura.Controls.Add(this.listBoxExcluir);
            this.tabEstructura.Controls.Add(this.labelExcluir);
            this.tabEstructura.Controls.Add(this.listBoxNiveles);
            this.tabEstructura.Controls.Add(this.labelNiveles);
            this.tabEstructura.Controls.Add(this.listBoxElegir);
            this.tabEstructura.Controls.Add(this.labelElegir);
            this.tabEstructura.Controls.Add(this.buttonClasificacionItemQuitar);
            this.tabEstructura.Controls.Add(this.buttonClasificacionItemElegir);
            this.tabEstructura.Controls.Add(this.listBoxClasificacion);
            this.tabEstructura.Controls.Add(this.labelClasificacion);
            this.tabEstructura.Controls.Add(this.comboBoxRutaBancoPreguntas);
            this.tabEstructura.Controls.Add(this.buttonAbrirBancoPreguntas);
            this.tabEstructura.Location = new System.Drawing.Point(4, 22);
            this.tabEstructura.Margin = new System.Windows.Forms.Padding(2);
            this.tabEstructura.Name = "tabEstructura";
            this.tabEstructura.Padding = new System.Windows.Forms.Padding(2);
            this.tabEstructura.Size = new System.Drawing.Size(759, 429);
            this.tabEstructura.TabIndex = 0;
            this.tabEstructura.Text = "Estructura";
            this.tabEstructura.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPreguntasEstructuradas
            // 
            this.dataGridViewPreguntasEstructuradas.AllowUserToAddRows = false;
            this.dataGridViewPreguntasEstructuradas.AllowUserToDeleteRows = false;
            this.dataGridViewPreguntasEstructuradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreguntasEstructuradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaOrden,
            this.columnaSeccion,
            this.columnaPreguntas,
            this.columnaTotal,
            this.columnaElegir,
            this.columnaPreguntasOrden,
            this.columnaRespuestasOrden});
            this.dataGridViewPreguntasEstructuradas.Location = new System.Drawing.Point(17, 240);
            this.dataGridViewPreguntasEstructuradas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPreguntasEstructuradas.Name = "dataGridViewPreguntasEstructuradas";
            this.dataGridViewPreguntasEstructuradas.RowHeadersVisible = false;
            this.dataGridViewPreguntasEstructuradas.RowHeadersWidth = 62;
            this.dataGridViewPreguntasEstructuradas.RowTemplate.Height = 28;
            this.dataGridViewPreguntasEstructuradas.Size = new System.Drawing.Size(727, 174);
            this.dataGridViewPreguntasEstructuradas.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Estructura de las preguntas para el examen.";
            // 
            // buttonEstructurarPreguntasElegidas
            // 
            this.buttonEstructurarPreguntasElegidas.Location = new System.Drawing.Point(300, 179);
            this.buttonEstructurarPreguntasElegidas.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEstructurarPreguntasElegidas.Name = "buttonEstructurarPreguntasElegidas";
            this.buttonEstructurarPreguntasElegidas.Size = new System.Drawing.Size(200, 32);
            this.buttonEstructurarPreguntasElegidas.TabIndex = 18;
            this.buttonEstructurarPreguntasElegidas.Text = "Estructurar preguntas elegidas";
            this.buttonEstructurarPreguntasElegidas.UseVisualStyleBackColor = true;
            // 
            // buttonNivelesBajar
            // 
            this.buttonNivelesBajar.Location = new System.Drawing.Point(566, 142);
            this.buttonNivelesBajar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNivelesBajar.Name = "buttonNivelesBajar";
            this.buttonNivelesBajar.Size = new System.Drawing.Size(27, 26);
            this.buttonNivelesBajar.TabIndex = 17;
            this.buttonNivelesBajar.Text = "v";
            this.buttonNivelesBajar.UseVisualStyleBackColor = true;
            // 
            // buttonNivelesSubir
            // 
            this.buttonNivelesSubir.Location = new System.Drawing.Point(566, 112);
            this.buttonNivelesSubir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNivelesSubir.Name = "buttonNivelesSubir";
            this.buttonNivelesSubir.Size = new System.Drawing.Size(27, 26);
            this.buttonNivelesSubir.TabIndex = 16;
            this.buttonNivelesSubir.Text = "^";
            this.buttonNivelesSubir.UseVisualStyleBackColor = true;
            // 
            // buttonNivelesIncluir
            // 
            this.buttonNivelesIncluir.Location = new System.Drawing.Point(566, 82);
            this.buttonNivelesIncluir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNivelesIncluir.Name = "buttonNivelesIncluir";
            this.buttonNivelesIncluir.Size = new System.Drawing.Size(27, 26);
            this.buttonNivelesIncluir.TabIndex = 15;
            this.buttonNivelesIncluir.Text = "<";
            this.buttonNivelesIncluir.UseVisualStyleBackColor = true;
            // 
            // buttonNivelesExcluir
            // 
            this.buttonNivelesExcluir.Location = new System.Drawing.Point(566, 52);
            this.buttonNivelesExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNivelesExcluir.Name = "buttonNivelesExcluir";
            this.buttonNivelesExcluir.Size = new System.Drawing.Size(27, 26);
            this.buttonNivelesExcluir.TabIndex = 14;
            this.buttonNivelesExcluir.Text = ">";
            this.buttonNivelesExcluir.UseVisualStyleBackColor = true;
            // 
            // listBoxExcluir
            // 
            this.listBoxExcluir.FormattingEnabled = true;
            this.listBoxExcluir.Location = new System.Drawing.Point(597, 52);
            this.listBoxExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxExcluir.Name = "listBoxExcluir";
            this.listBoxExcluir.Size = new System.Drawing.Size(148, 121);
            this.listBoxExcluir.TabIndex = 13;
            // 
            // labelExcluir
            // 
            this.labelExcluir.AutoSize = true;
            this.labelExcluir.Location = new System.Drawing.Point(594, 36);
            this.labelExcluir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExcluir.Name = "labelExcluir";
            this.labelExcluir.Size = new System.Drawing.Size(38, 13);
            this.labelExcluir.TabIndex = 12;
            this.labelExcluir.Text = "Excluir";
            // 
            // listBoxNiveles
            // 
            this.listBoxNiveles.FormattingEnabled = true;
            this.listBoxNiveles.Location = new System.Drawing.Point(415, 52);
            this.listBoxNiveles.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxNiveles.Name = "listBoxNiveles";
            this.listBoxNiveles.Size = new System.Drawing.Size(148, 121);
            this.listBoxNiveles.TabIndex = 11;
            // 
            // labelNiveles
            // 
            this.labelNiveles.AutoSize = true;
            this.labelNiveles.Location = new System.Drawing.Point(413, 36);
            this.labelNiveles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNiveles.Name = "labelNiveles";
            this.labelNiveles.Size = new System.Drawing.Size(42, 13);
            this.labelNiveles.TabIndex = 10;
            this.labelNiveles.Text = "Niveles";
            // 
            // listBoxElegir
            // 
            this.listBoxElegir.FormattingEnabled = true;
            this.listBoxElegir.Location = new System.Drawing.Point(198, 52);
            this.listBoxElegir.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxElegir.Name = "listBoxElegir";
            this.listBoxElegir.Size = new System.Drawing.Size(194, 121);
            this.listBoxElegir.TabIndex = 9;
            // 
            // labelElegir
            // 
            this.labelElegir.AutoSize = true;
            this.labelElegir.Location = new System.Drawing.Point(195, 36);
            this.labelElegir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelElegir.Name = "labelElegir";
            this.labelElegir.Size = new System.Drawing.Size(33, 13);
            this.labelElegir.TabIndex = 8;
            this.labelElegir.Text = "Elegir";
            // 
            // buttonClasificacionItemQuitar
            // 
            this.buttonClasificacionItemQuitar.Location = new System.Drawing.Point(167, 111);
            this.buttonClasificacionItemQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClasificacionItemQuitar.Name = "buttonClasificacionItemQuitar";
            this.buttonClasificacionItemQuitar.Size = new System.Drawing.Size(27, 26);
            this.buttonClasificacionItemQuitar.TabIndex = 7;
            this.buttonClasificacionItemQuitar.Text = "<";
            this.buttonClasificacionItemQuitar.UseVisualStyleBackColor = true;
            // 
            // buttonClasificacionItemElegir
            // 
            this.buttonClasificacionItemElegir.Location = new System.Drawing.Point(167, 81);
            this.buttonClasificacionItemElegir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClasificacionItemElegir.Name = "buttonClasificacionItemElegir";
            this.buttonClasificacionItemElegir.Size = new System.Drawing.Size(27, 26);
            this.buttonClasificacionItemElegir.TabIndex = 6;
            this.buttonClasificacionItemElegir.Text = ">";
            this.buttonClasificacionItemElegir.UseVisualStyleBackColor = true;
            // 
            // listBoxClasificacion
            // 
            this.listBoxClasificacion.FormattingEnabled = true;
            this.listBoxClasificacion.Location = new System.Drawing.Point(17, 52);
            this.listBoxClasificacion.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxClasificacion.Name = "listBoxClasificacion";
            this.listBoxClasificacion.Size = new System.Drawing.Size(148, 121);
            this.listBoxClasificacion.TabIndex = 5;
            // 
            // labelClasificacion
            // 
            this.labelClasificacion.AutoSize = true;
            this.labelClasificacion.Location = new System.Drawing.Point(17, 36);
            this.labelClasificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClasificacion.Name = "labelClasificacion";
            this.labelClasificacion.Size = new System.Drawing.Size(66, 13);
            this.labelClasificacion.TabIndex = 4;
            this.labelClasificacion.Text = "Clasificación";
            // 
            // comboBoxRutaBancoPreguntas
            // 
            this.comboBoxRutaBancoPreguntas.FormattingEnabled = true;
            this.comboBoxRutaBancoPreguntas.Location = new System.Drawing.Point(198, 8);
            this.comboBoxRutaBancoPreguntas.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRutaBancoPreguntas.Name = "comboBoxRutaBancoPreguntas";
            this.comboBoxRutaBancoPreguntas.Size = new System.Drawing.Size(547, 21);
            this.comboBoxRutaBancoPreguntas.TabIndex = 3;
            // 
            // buttonAbrirBancoPreguntas
            // 
            this.buttonAbrirBancoPreguntas.Location = new System.Drawing.Point(24, 5);
            this.buttonAbrirBancoPreguntas.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAbrirBancoPreguntas.Name = "buttonAbrirBancoPreguntas";
            this.buttonAbrirBancoPreguntas.Size = new System.Drawing.Size(170, 23);
            this.buttonAbrirBancoPreguntas.TabIndex = 2;
            this.buttonAbrirBancoPreguntas.Text = "Abrir banco de preguntas";
            this.buttonAbrirBancoPreguntas.UseVisualStyleBackColor = true;
            // 
            // tabCantidad
            // 
            this.tabCantidad.Controls.Add(this.groupBoxIdentificacionDeExamenes);
            this.tabCantidad.Controls.Add(this.groupBoxCantidadDeExamenes);
            this.tabCantidad.Location = new System.Drawing.Point(4, 22);
            this.tabCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.tabCantidad.Name = "tabCantidad";
            this.tabCantidad.Padding = new System.Windows.Forms.Padding(2);
            this.tabCantidad.Size = new System.Drawing.Size(759, 429);
            this.tabCantidad.TabIndex = 1;
            this.tabCantidad.Text = "Cantidad";
            this.tabCantidad.UseVisualStyleBackColor = true;
            // 
            // tabNumeracion
            // 
            this.tabNumeracion.Location = new System.Drawing.Point(4, 22);
            this.tabNumeracion.Margin = new System.Windows.Forms.Padding(2);
            this.tabNumeracion.Name = "tabNumeracion";
            this.tabNumeracion.Padding = new System.Windows.Forms.Padding(2);
            this.tabNumeracion.Size = new System.Drawing.Size(759, 429);
            this.tabNumeracion.TabIndex = 2;
            this.tabNumeracion.Text = "Numeración";
            this.tabNumeracion.UseVisualStyleBackColor = true;
            // 
            // tabSolucion
            // 
            this.tabSolucion.Location = new System.Drawing.Point(4, 22);
            this.tabSolucion.Margin = new System.Windows.Forms.Padding(2);
            this.tabSolucion.Name = "tabSolucion";
            this.tabSolucion.Padding = new System.Windows.Forms.Padding(2);
            this.tabSolucion.Size = new System.Drawing.Size(759, 429);
            this.tabSolucion.TabIndex = 3;
            this.tabSolucion.Text = "Solución";
            this.tabSolucion.UseVisualStyleBackColor = true;
            // 
            // tabExamen
            // 
            this.tabExamen.Location = new System.Drawing.Point(4, 22);
            this.tabExamen.Margin = new System.Windows.Forms.Padding(2);
            this.tabExamen.Name = "tabExamen";
            this.tabExamen.Padding = new System.Windows.Forms.Padding(2);
            this.tabExamen.Size = new System.Drawing.Size(759, 429);
            this.tabExamen.TabIndex = 4;
            this.tabExamen.Text = "Examen";
            this.tabExamen.UseVisualStyleBackColor = true;
            // 
            // buttonAbrirCondiciones
            // 
            this.buttonAbrirCondiciones.Location = new System.Drawing.Point(20, 474);
            this.buttonAbrirCondiciones.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAbrirCondiciones.Name = "buttonAbrirCondiciones";
            this.buttonAbrirCondiciones.Size = new System.Drawing.Size(133, 29);
            this.buttonAbrirCondiciones.TabIndex = 1;
            this.buttonAbrirCondiciones.Text = "Abrir condiciones";
            this.buttonAbrirCondiciones.UseVisualStyleBackColor = true;
            // 
            // buttonGuardarCondiciones
            // 
            this.buttonGuardarCondiciones.Location = new System.Drawing.Point(20, 511);
            this.buttonGuardarCondiciones.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardarCondiciones.Name = "buttonGuardarCondiciones";
            this.buttonGuardarCondiciones.Size = new System.Drawing.Size(133, 29);
            this.buttonGuardarCondiciones.TabIndex = 2;
            this.buttonGuardarCondiciones.Text = "Guardar condiciones";
            this.buttonGuardarCondiciones.UseVisualStyleBackColor = true;
            // 
            // buttonGenerarExamen
            // 
            this.buttonGenerarExamen.Location = new System.Drawing.Point(347, 493);
            this.buttonGenerarExamen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerarExamen.Name = "buttonGenerarExamen";
            this.buttonGenerarExamen.Size = new System.Drawing.Size(133, 29);
            this.buttonGenerarExamen.TabIndex = 3;
            this.buttonGenerarExamen.Text = "Generar examen";
            this.buttonGenerarExamen.UseVisualStyleBackColor = true;
            // 
            // checkBoxAbrirExamen
            // 
            this.checkBoxAbrirExamen.AutoSize = true;
            this.checkBoxAbrirExamen.Location = new System.Drawing.Point(500, 491);
            this.checkBoxAbrirExamen.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAbrirExamen.Name = "checkBoxAbrirExamen";
            this.checkBoxAbrirExamen.Size = new System.Drawing.Size(87, 17);
            this.checkBoxAbrirExamen.TabIndex = 4;
            this.checkBoxAbrirExamen.Text = "Abrir examen";
            this.checkBoxAbrirExamen.UseVisualStyleBackColor = true;
            // 
            // checkBoxReemplazarExamen
            // 
            this.checkBoxReemplazarExamen.AutoSize = true;
            this.checkBoxReemplazarExamen.Location = new System.Drawing.Point(500, 510);
            this.checkBoxReemplazarExamen.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxReemplazarExamen.Name = "checkBoxReemplazarExamen";
            this.checkBoxReemplazarExamen.Size = new System.Drawing.Size(122, 17);
            this.checkBoxReemplazarExamen.TabIndex = 5;
            this.checkBoxReemplazarExamen.Text = "Reemplazar examen";
            this.checkBoxReemplazarExamen.UseVisualStyleBackColor = true;
            // 
            // checkBoxPdf
            // 
            this.checkBoxPdf.AutoSize = true;
            this.checkBoxPdf.Location = new System.Drawing.Point(637, 481);
            this.checkBoxPdf.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxPdf.Name = "checkBoxPdf";
            this.checkBoxPdf.Size = new System.Drawing.Size(47, 17);
            this.checkBoxPdf.TabIndex = 6;
            this.checkBoxPdf.Text = "PDF";
            this.checkBoxPdf.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnArchivoPorExamen
            // 
            this.checkBoxUnArchivoPorExamen.AutoSize = true;
            this.checkBoxUnArchivoPorExamen.Location = new System.Drawing.Point(637, 500);
            this.checkBoxUnArchivoPorExamen.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxUnArchivoPorExamen.Name = "checkBoxUnArchivoPorExamen";
            this.checkBoxUnArchivoPorExamen.Size = new System.Drawing.Size(136, 17);
            this.checkBoxUnArchivoPorExamen.TabIndex = 7;
            this.checkBoxUnArchivoPorExamen.Text = "Un archivo por examen";
            this.checkBoxUnArchivoPorExamen.UseVisualStyleBackColor = true;
            // 
            // checkBoxImprimirADosCaras
            // 
            this.checkBoxImprimirADosCaras.AutoSize = true;
            this.checkBoxImprimirADosCaras.Location = new System.Drawing.Point(637, 520);
            this.checkBoxImprimirADosCaras.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxImprimirADosCaras.Name = "checkBoxImprimirADosCaras";
            this.checkBoxImprimirADosCaras.Size = new System.Drawing.Size(119, 17);
            this.checkBoxImprimirADosCaras.TabIndex = 8;
            this.checkBoxImprimirADosCaras.Text = "Imprimir a dos caras";
            this.checkBoxImprimirADosCaras.UseVisualStyleBackColor = true;
            // 
            // columnaOrden
            // 
            this.columnaOrden.HeaderText = "Orden";
            this.columnaOrden.MinimumWidth = 8;
            this.columnaOrden.Name = "columnaOrden";
            this.columnaOrden.Width = 120;
            // 
            // columnaSeccion
            // 
            this.columnaSeccion.HeaderText = "Sección";
            this.columnaSeccion.MinimumWidth = 8;
            this.columnaSeccion.Name = "columnaSeccion";
            this.columnaSeccion.Width = 125;
            // 
            // columnaPreguntas
            // 
            this.columnaPreguntas.HeaderText = "Preguntas";
            this.columnaPreguntas.MinimumWidth = 8;
            this.columnaPreguntas.Name = "columnaPreguntas";
            this.columnaPreguntas.Width = 125;
            // 
            // columnaTotal
            // 
            this.columnaTotal.HeaderText = "Total";
            this.columnaTotal.MinimumWidth = 8;
            this.columnaTotal.Name = "columnaTotal";
            // 
            // columnaElegir
            // 
            this.columnaElegir.HeaderText = "Elegir";
            this.columnaElegir.MinimumWidth = 8;
            this.columnaElegir.Name = "columnaElegir";
            // 
            // columnaPreguntasOrden
            // 
            this.columnaPreguntasOrden.HeaderText = "Preguntas";
            this.columnaPreguntasOrden.MinimumWidth = 8;
            this.columnaPreguntasOrden.Name = "columnaPreguntasOrden";
            this.columnaPreguntasOrden.Width = 75;
            // 
            // columnaRespuestasOrden
            // 
            this.columnaRespuestasOrden.HeaderText = "Respuestas";
            this.columnaRespuestasOrden.MinimumWidth = 8;
            this.columnaRespuestasOrden.Name = "columnaRespuestasOrden";
            this.columnaRespuestasOrden.Width = 75;
            // 
            // groupBoxCantidadDeExamenes
            // 
            this.groupBoxCantidadDeExamenes.Controls.Add(this.labelTotalExamanesCopias);
            this.groupBoxCantidadDeExamenes.Controls.Add(this.groupBoxCopias);
            this.groupBoxCantidadDeExamenes.Controls.Add(this.radioButtonNuevasPreguntas);
            this.groupBoxCantidadDeExamenes.Controls.Add(this.radioButtonNuevaEleccion);
            this.groupBoxCantidadDeExamenes.Controls.Add(this.numericUpDownExamenes);
            this.groupBoxCantidadDeExamenes.Controls.Add(this.labelExamenes);
            this.groupBoxCantidadDeExamenes.Location = new System.Drawing.Point(25, 25);
            this.groupBoxCantidadDeExamenes.Name = "groupBoxCantidadDeExamenes";
            this.groupBoxCantidadDeExamenes.Size = new System.Drawing.Size(250, 250);
            this.groupBoxCantidadDeExamenes.TabIndex = 0;
            this.groupBoxCantidadDeExamenes.TabStop = false;
            this.groupBoxCantidadDeExamenes.Text = "Cantidad de exámenes";
            // 
            // groupBoxIdentificacionDeExamenes
            // 
            this.groupBoxIdentificacionDeExamenes.Controls.Add(this.groupBoxJustificacion);
            this.groupBoxIdentificacionDeExamenes.Controls.Add(this.groupBoxUbicacionEnLaPagina);
            this.groupBoxIdentificacionDeExamenes.Controls.Add(this.textBoxIdentificarCopia);
            this.groupBoxIdentificacionDeExamenes.Controls.Add(this.labeIdentificarCopia);
            this.groupBoxIdentificacionDeExamenes.Controls.Add(this.textBoxIdentificarExamen);
            this.groupBoxIdentificacionDeExamenes.Controls.Add(this.labelIdentificarExamen);
            this.groupBoxIdentificacionDeExamenes.Controls.Add(this.buttonIdentificarExamenes);
            this.groupBoxIdentificacionDeExamenes.Controls.Add(this.labelIdentificarExamanes);
            this.groupBoxIdentificacionDeExamenes.Location = new System.Drawing.Point(300, 25);
            this.groupBoxIdentificacionDeExamenes.Name = "groupBoxIdentificacionDeExamenes";
            this.groupBoxIdentificacionDeExamenes.Size = new System.Drawing.Size(260, 250);
            this.groupBoxIdentificacionDeExamenes.TabIndex = 1;
            this.groupBoxIdentificacionDeExamenes.TabStop = false;
            this.groupBoxIdentificacionDeExamenes.Text = "Identificación de exámenes";
            // 
            // labelExamenes
            // 
            this.labelExamenes.AutoSize = true;
            this.labelExamenes.Location = new System.Drawing.Point(20, 25);
            this.labelExamenes.Name = "labelExamenes";
            this.labelExamenes.Size = new System.Drawing.Size(56, 13);
            this.labelExamenes.TabIndex = 0;
            this.labelExamenes.Text = "Exámenes";
            // 
            // numericUpDownExamenes
            // 
            this.numericUpDownExamenes.Location = new System.Drawing.Point(82, 23);
            this.numericUpDownExamenes.Name = "numericUpDownExamenes";
            this.numericUpDownExamenes.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownExamenes.TabIndex = 1;
            // 
            // radioButtonNuevaEleccion
            // 
            this.radioButtonNuevaEleccion.AutoSize = true;
            this.radioButtonNuevaEleccion.Location = new System.Drawing.Point(23, 49);
            this.radioButtonNuevaEleccion.Name = "radioButtonNuevaEleccion";
            this.radioButtonNuevaEleccion.Size = new System.Drawing.Size(100, 17);
            this.radioButtonNuevaEleccion.TabIndex = 2;
            this.radioButtonNuevaEleccion.TabStop = true;
            this.radioButtonNuevaEleccion.Text = "Nueva elección";
            this.radioButtonNuevaEleccion.UseVisualStyleBackColor = true;
            // 
            // radioButtonNuevasPreguntas
            // 
            this.radioButtonNuevasPreguntas.AutoSize = true;
            this.radioButtonNuevasPreguntas.Location = new System.Drawing.Point(23, 72);
            this.radioButtonNuevasPreguntas.Name = "radioButtonNuevasPreguntas";
            this.radioButtonNuevasPreguntas.Size = new System.Drawing.Size(112, 17);
            this.radioButtonNuevasPreguntas.TabIndex = 3;
            this.radioButtonNuevasPreguntas.TabStop = true;
            this.radioButtonNuevasPreguntas.Text = "Nuevas preguntas";
            this.radioButtonNuevasPreguntas.UseVisualStyleBackColor = true;
            // 
            // groupBoxCopias
            // 
            this.groupBoxCopias.Controls.Add(this.checkBoxRespuestasAleatoerias);
            this.groupBoxCopias.Controls.Add(this.checkBoxPreguntasAleatoerias);
            this.groupBoxCopias.Controls.Add(this.numericUpDownCopias);
            this.groupBoxCopias.Location = new System.Drawing.Point(23, 95);
            this.groupBoxCopias.Name = "groupBoxCopias";
            this.groupBoxCopias.Size = new System.Drawing.Size(211, 110);
            this.groupBoxCopias.TabIndex = 4;
            this.groupBoxCopias.TabStop = false;
            this.groupBoxCopias.Text = "Copias";
            // 
            // numericUpDownCopias
            // 
            this.numericUpDownCopias.Location = new System.Drawing.Point(10, 25);
            this.numericUpDownCopias.Name = "numericUpDownCopias";
            this.numericUpDownCopias.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownCopias.TabIndex = 2;
            // 
            // checkBoxPreguntasAleatoerias
            // 
            this.checkBoxPreguntasAleatoerias.AutoSize = true;
            this.checkBoxPreguntasAleatoerias.Location = new System.Drawing.Point(10, 51);
            this.checkBoxPreguntasAleatoerias.Name = "checkBoxPreguntasAleatoerias";
            this.checkBoxPreguntasAleatoerias.Size = new System.Drawing.Size(122, 17);
            this.checkBoxPreguntasAleatoerias.TabIndex = 3;
            this.checkBoxPreguntasAleatoerias.Text = "Preguntas aleatorias";
            this.checkBoxPreguntasAleatoerias.UseVisualStyleBackColor = true;
            // 
            // checkBoxRespuestasAleatoerias
            // 
            this.checkBoxRespuestasAleatoerias.AutoSize = true;
            this.checkBoxRespuestasAleatoerias.Location = new System.Drawing.Point(10, 74);
            this.checkBoxRespuestasAleatoerias.Name = "checkBoxRespuestasAleatoerias";
            this.checkBoxRespuestasAleatoerias.Size = new System.Drawing.Size(130, 17);
            this.checkBoxRespuestasAleatoerias.TabIndex = 4;
            this.checkBoxRespuestasAleatoerias.Text = "Respuestas aleatorias";
            this.checkBoxRespuestasAleatoerias.UseVisualStyleBackColor = true;
            // 
            // labelIdentificarExamanes
            // 
            this.labelIdentificarExamanes.AutoSize = true;
            this.labelIdentificarExamanes.Location = new System.Drawing.Point(20, 25);
            this.labelIdentificarExamanes.Name = "labelIdentificarExamanes";
            this.labelIdentificarExamanes.Size = new System.Drawing.Size(104, 13);
            this.labelIdentificarExamanes.TabIndex = 1;
            this.labelIdentificarExamanes.Text = "Identificar exámenes";
            // 
            // buttonIdentificarExamenes
            // 
            this.buttonIdentificarExamenes.Location = new System.Drawing.Point(130, 20);
            this.buttonIdentificarExamenes.Name = "buttonIdentificarExamenes";
            this.buttonIdentificarExamenes.Size = new System.Drawing.Size(35, 23);
            this.buttonIdentificarExamenes.TabIndex = 2;
            this.buttonIdentificarExamenes.Text = "SI";
            this.buttonIdentificarExamenes.UseVisualStyleBackColor = true;
            // 
            // labelIdentificarExamen
            // 
            this.labelIdentificarExamen.AutoSize = true;
            this.labelIdentificarExamen.Location = new System.Drawing.Point(20, 49);
            this.labelIdentificarExamen.Name = "labelIdentificarExamen";
            this.labelIdentificarExamen.Size = new System.Drawing.Size(45, 13);
            this.labelIdentificarExamen.TabIndex = 3;
            this.labelIdentificarExamen.Text = "Examen";
            // 
            // textBoxIdentificarExamen
            // 
            this.textBoxIdentificarExamen.Location = new System.Drawing.Point(71, 46);
            this.textBoxIdentificarExamen.Name = "textBoxIdentificarExamen";
            this.textBoxIdentificarExamen.Size = new System.Drawing.Size(40, 20);
            this.textBoxIdentificarExamen.TabIndex = 4;
            this.textBoxIdentificarExamen.Text = "EX-";
            this.textBoxIdentificarExamen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxIdentificarCopia
            // 
            this.textBoxIdentificarCopia.Location = new System.Drawing.Point(167, 46);
            this.textBoxIdentificarCopia.Name = "textBoxIdentificarCopia";
            this.textBoxIdentificarCopia.Size = new System.Drawing.Size(40, 20);
            this.textBoxIdentificarCopia.TabIndex = 6;
            this.textBoxIdentificarCopia.Text = "COP-";
            this.textBoxIdentificarCopia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // groupBoxUbicacionEnLaPagina
            // 
            this.groupBoxUbicacionEnLaPagina.Controls.Add(this.radioButtonPie);
            this.groupBoxUbicacionEnLaPagina.Controls.Add(this.radioButtonInicioDePreguntas);
            this.groupBoxUbicacionEnLaPagina.Controls.Add(this.radioButtonEncabezado);
            this.groupBoxUbicacionEnLaPagina.Location = new System.Drawing.Point(23, 72);
            this.groupBoxUbicacionEnLaPagina.Name = "groupBoxUbicacionEnLaPagina";
            this.groupBoxUbicacionEnLaPagina.Size = new System.Drawing.Size(220, 110);
            this.groupBoxUbicacionEnLaPagina.TabIndex = 7;
            this.groupBoxUbicacionEnLaPagina.TabStop = false;
            this.groupBoxUbicacionEnLaPagina.Text = "Ubicación en la página";
            // 
            // radioButtonEncabezado
            // 
            this.radioButtonEncabezado.AutoSize = true;
            this.radioButtonEncabezado.Location = new System.Drawing.Point(10, 25);
            this.radioButtonEncabezado.Name = "radioButtonEncabezado";
            this.radioButtonEncabezado.Size = new System.Drawing.Size(85, 17);
            this.radioButtonEncabezado.TabIndex = 0;
            this.radioButtonEncabezado.TabStop = true;
            this.radioButtonEncabezado.Text = "Encabezado";
            this.radioButtonEncabezado.UseVisualStyleBackColor = true;
            // 
            // radioButtonInicioDePreguntas
            // 
            this.radioButtonInicioDePreguntas.AutoSize = true;
            this.radioButtonInicioDePreguntas.Location = new System.Drawing.Point(10, 48);
            this.radioButtonInicioDePreguntas.Name = "radioButtonInicioDePreguntas";
            this.radioButtonInicioDePreguntas.Size = new System.Drawing.Size(115, 17);
            this.radioButtonInicioDePreguntas.TabIndex = 1;
            this.radioButtonInicioDePreguntas.TabStop = true;
            this.radioButtonInicioDePreguntas.Text = "Inicio de preguntas";
            this.radioButtonInicioDePreguntas.UseVisualStyleBackColor = true;
            // 
            // radioButtonPie
            // 
            this.radioButtonPie.AutoSize = true;
            this.radioButtonPie.Location = new System.Drawing.Point(10, 71);
            this.radioButtonPie.Name = "radioButtonPie";
            this.radioButtonPie.Size = new System.Drawing.Size(40, 17);
            this.radioButtonPie.TabIndex = 2;
            this.radioButtonPie.TabStop = true;
            this.radioButtonPie.Text = "Pie";
            this.radioButtonPie.UseVisualStyleBackColor = true;
            // 
            // groupBoxJustificacion
            // 
            this.groupBoxJustificacion.Controls.Add(this.radioButtonDerecha);
            this.groupBoxJustificacion.Controls.Add(this.radioButtonCentro);
            this.groupBoxJustificacion.Controls.Add(this.radioButtonIzquierda);
            this.groupBoxJustificacion.Location = new System.Drawing.Point(25, 188);
            this.groupBoxJustificacion.Name = "groupBoxJustificacion";
            this.groupBoxJustificacion.Size = new System.Drawing.Size(220, 56);
            this.groupBoxJustificacion.TabIndex = 8;
            this.groupBoxJustificacion.TabStop = false;
            this.groupBoxJustificacion.Text = "Justificación";
            // 
            // radioButtonIzquierda
            // 
            this.radioButtonIzquierda.AutoSize = true;
            this.radioButtonIzquierda.Location = new System.Drawing.Point(10, 25);
            this.radioButtonIzquierda.Name = "radioButtonIzquierda";
            this.radioButtonIzquierda.Size = new System.Drawing.Size(68, 17);
            this.radioButtonIzquierda.TabIndex = 1;
            this.radioButtonIzquierda.TabStop = true;
            this.radioButtonIzquierda.Text = "Izquierda";
            this.radioButtonIzquierda.UseVisualStyleBackColor = true;
            // 
            // radioButtonCentro
            // 
            this.radioButtonCentro.AutoSize = true;
            this.radioButtonCentro.Location = new System.Drawing.Point(84, 25);
            this.radioButtonCentro.Name = "radioButtonCentro";
            this.radioButtonCentro.Size = new System.Drawing.Size(56, 17);
            this.radioButtonCentro.TabIndex = 2;
            this.radioButtonCentro.TabStop = true;
            this.radioButtonCentro.Text = "Centro";
            this.radioButtonCentro.UseVisualStyleBackColor = true;
            // 
            // radioButtonDerecha
            // 
            this.radioButtonDerecha.AutoSize = true;
            this.radioButtonDerecha.Location = new System.Drawing.Point(146, 25);
            this.radioButtonDerecha.Name = "radioButtonDerecha";
            this.radioButtonDerecha.Size = new System.Drawing.Size(66, 17);
            this.radioButtonDerecha.TabIndex = 3;
            this.radioButtonDerecha.TabStop = true;
            this.radioButtonDerecha.Text = "Derecha";
            this.radioButtonDerecha.UseVisualStyleBackColor = true;
            // 
            // labelTotalExamanesCopias
            // 
            this.labelTotalExamanesCopias.AutoSize = true;
            this.labelTotalExamanesCopias.Location = new System.Drawing.Point(10, 215);
            this.labelTotalExamanesCopias.Name = "labelTotalExamanesCopias";
            this.labelTotalExamanesCopias.Size = new System.Drawing.Size(180, 13);
            this.labelTotalExamanesCopias.TabIndex = 5;
            this.labelTotalExamanesCopias.Text = "Total de exámenes ( ) y copias ( ) = x";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 549);
            this.Controls.Add(this.checkBoxImprimirADosCaras);
            this.Controls.Add(this.checkBoxUnArchivoPorExamen);
            this.Controls.Add(this.checkBoxPdf);
            this.Controls.Add(this.checkBoxReemplazarExamen);
            this.Controls.Add(this.checkBoxAbrirExamen);
            this.Controls.Add(this.buttonGenerarExamen);
            this.Controls.Add(this.buttonGuardarCondiciones);
            this.Controls.Add(this.buttonAbrirCondiciones);
            this.Controls.Add(this.tabPrincipal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.Text = "Creador de Examenes";
            this.tabPrincipal.ResumeLayout(false);
            this.tabEstructura.ResumeLayout(false);
            this.tabEstructura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreguntasEstructuradas)).EndInit();
            this.tabCantidad.ResumeLayout(false);
            this.groupBoxCantidadDeExamenes.ResumeLayout(false);
            this.groupBoxCantidadDeExamenes.PerformLayout();
            this.groupBoxIdentificacionDeExamenes.ResumeLayout(false);
            this.groupBoxIdentificacionDeExamenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExamenes)).EndInit();
            this.groupBoxCopias.ResumeLayout(false);
            this.groupBoxCopias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopias)).EndInit();
            this.groupBoxUbicacionEnLaPagina.ResumeLayout(false);
            this.groupBoxUbicacionEnLaPagina.PerformLayout();
            this.groupBoxJustificacion.ResumeLayout(false);
            this.groupBoxJustificacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabEstructura;
        private System.Windows.Forms.TabPage tabCantidad;
        private System.Windows.Forms.TabPage tabNumeracion;
        private System.Windows.Forms.TabPage tabSolucion;
        private System.Windows.Forms.TabPage tabExamen;
        private System.Windows.Forms.Button buttonAbrirCondiciones;
        private System.Windows.Forms.Button buttonGuardarCondiciones;
        private System.Windows.Forms.Button buttonGenerarExamen;
        private System.Windows.Forms.CheckBox checkBoxAbrirExamen;
        private System.Windows.Forms.CheckBox checkBoxReemplazarExamen;
        private System.Windows.Forms.CheckBox checkBoxPdf;
        private System.Windows.Forms.CheckBox checkBoxUnArchivoPorExamen;
        private System.Windows.Forms.CheckBox checkBoxImprimirADosCaras;
        private System.Windows.Forms.Button buttonAbrirBancoPreguntas;
        private System.Windows.Forms.ComboBox comboBoxRutaBancoPreguntas;
        private System.Windows.Forms.Button buttonNivelesBajar;
        private System.Windows.Forms.Button buttonNivelesSubir;
        private System.Windows.Forms.Button buttonNivelesIncluir;
        private System.Windows.Forms.Button buttonNivelesExcluir;
        private System.Windows.Forms.ListBox listBoxExcluir;
        private System.Windows.Forms.Label labelExcluir;
        private System.Windows.Forms.ListBox listBoxNiveles;
        private System.Windows.Forms.Label labelNiveles;
        private System.Windows.Forms.ListBox listBoxElegir;
        private System.Windows.Forms.Label labelElegir;
        private System.Windows.Forms.Button buttonClasificacionItemQuitar;
        private System.Windows.Forms.Button buttonClasificacionItemElegir;
        private System.Windows.Forms.ListBox listBoxClasificacion;
        private System.Windows.Forms.Label labelClasificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonEstructurarPreguntasElegidas;
        private System.Windows.Forms.DataGridView dataGridViewPreguntasEstructuradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaElegir;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPreguntasOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaRespuestasOrden;
        private System.Windows.Forms.GroupBox groupBoxIdentificacionDeExamenes;
        private System.Windows.Forms.GroupBox groupBoxCantidadDeExamenes;
        private System.Windows.Forms.GroupBox groupBoxCopias;
        private System.Windows.Forms.RadioButton radioButtonNuevasPreguntas;
        private System.Windows.Forms.RadioButton radioButtonNuevaEleccion;
        private System.Windows.Forms.NumericUpDown numericUpDownExamenes;
        private System.Windows.Forms.Label labelExamenes;
        private System.Windows.Forms.Label labelIdentificarExamanes;
        private System.Windows.Forms.CheckBox checkBoxRespuestasAleatoerias;
        private System.Windows.Forms.CheckBox checkBoxPreguntasAleatoerias;
        private System.Windows.Forms.NumericUpDown numericUpDownCopias;
        private System.Windows.Forms.GroupBox groupBoxJustificacion;
        private System.Windows.Forms.RadioButton radioButtonDerecha;
        private System.Windows.Forms.RadioButton radioButtonCentro;
        private System.Windows.Forms.RadioButton radioButtonIzquierda;
        private System.Windows.Forms.GroupBox groupBoxUbicacionEnLaPagina;
        private System.Windows.Forms.RadioButton radioButtonPie;
        private System.Windows.Forms.RadioButton radioButtonInicioDePreguntas;
        private System.Windows.Forms.RadioButton radioButtonEncabezado;
        private System.Windows.Forms.TextBox textBoxIdentificarCopia;
        private System.Windows.Forms.Label labeIdentificarCopia;
        private System.Windows.Forms.TextBox textBoxIdentificarExamen;
        private System.Windows.Forms.Label labelIdentificarExamen;
        private System.Windows.Forms.Button buttonIdentificarExamenes;
        private System.Windows.Forms.Label labelTotalExamanesCopias;
    }
}

