﻿namespace TestCreator
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
            this.groupBoxNumeracionDePreguntasGeneral = new System.Windows.Forms.GroupBox();
            this.groupBoxNumeracionDeRespuestasGeneral = new System.Windows.Forms.GroupBox();
            this.groupBoxNumeracionPreguntas = new System.Windows.Forms.GroupBox();
            this.labelAntesNumeracionPreguntas = new System.Windows.Forms.Label();
            this.labelNumeroNumeracionPreguntas = new System.Windows.Forms.Label();
            this.labelDespuesNumeracionPreguntas = new System.Windows.Forms.Label();
            this.textBoxAntesNumeracionPreguntas = new System.Windows.Forms.TextBox();
            this.textBoxDespuesNumeracionPreguntas = new System.Windows.Forms.TextBox();
            this.labelMantenerOriginalNumeracionPreguntas = new System.Windows.Forms.Label();
            this.buttonMantenerOriginalNumeracionPreguntas = new System.Windows.Forms.Button();
            this.labelNumeracionResultadoNumeracionPreguntas = new System.Windows.Forms.Label();
            this.groupBoxColumnasPreguntas = new System.Windows.Forms.GroupBox();
            this.radioButtonUnaColumnasPreguntas = new System.Windows.Forms.RadioButton();
            this.radioButtonDosColumnasPreguntas = new System.Windows.Forms.RadioButton();
            this.radioButtonMantenerOriginalColumnasPreguntas = new System.Windows.Forms.RadioButton();
            this.groupBoxEspaciadoPreguntas = new System.Windows.Forms.GroupBox();
            this.labelAntesEspaciadoPreguntas = new System.Windows.Forms.Label();
            this.numericUpDownAntesEspaciadoPreguntas = new System.Windows.Forms.NumericUpDown();
            this.labelDespuesEspaciadoPreguntas = new System.Windows.Forms.Label();
            this.numericUpDownDespuesEspaciadoPreguntas = new System.Windows.Forms.NumericUpDown();
            this.comboBoxInterlineadoEspaciadoPreguntas = new System.Windows.Forms.ComboBox();
            this.buttonMantenerOriginalEspaciadoPreguntas = new System.Windows.Forms.Button();
            this.labelMantenerOriginalEspaciadoPreguntas = new System.Windows.Forms.Label();
            this.labelInterlineadoEspaciadoPreguntas = new System.Windows.Forms.Label();
            this.groupBoxNumeracionRespuestas = new System.Windows.Forms.GroupBox();
            this.labelNumeracionResultadoNumeracionRespuestas = new System.Windows.Forms.Label();
            this.buttonMantenerOriginalNumeracionRespuestas = new System.Windows.Forms.Button();
            this.labelMantenerOriginalNumeracionRespuestas = new System.Windows.Forms.Label();
            this.textBoxDespuesNumeracionRespuestas = new System.Windows.Forms.TextBox();
            this.textBoxAntesNumeracionRespuestas = new System.Windows.Forms.TextBox();
            this.labelDespuesNumeracionRespuestas = new System.Windows.Forms.Label();
            this.labelNumeroNumeracionRespuestas = new System.Windows.Forms.Label();
            this.labelAntesNumeracionRespuestas = new System.Windows.Forms.Label();
            this.groupBoxEspaciadoRespuestas = new System.Windows.Forms.GroupBox();
            this.labelInterlineadoEspaciadoRespuestas = new System.Windows.Forms.Label();
            this.buttonMantenerOriginalEspaciadoRespuestas = new System.Windows.Forms.Button();
            this.labelMantenerOriginalEspaciadoRespuestas = new System.Windows.Forms.Label();
            this.comboBoxInterlineadoEspaciadoRespuestas = new System.Windows.Forms.ComboBox();
            this.numericUpDownDespuesEspaciadoRespuestas = new System.Windows.Forms.NumericUpDown();
            this.labelDespuesEspaciadoRespuestas = new System.Windows.Forms.Label();
            this.numericUpDownAntesEspaciadoRespuestas = new System.Windows.Forms.NumericUpDown();
            this.labelAntesEspaciadoRespuestas = new System.Windows.Forms.Label();
            this.numericUpDownSangriaIzquierdaEspaciadoRespuestas = new System.Windows.Forms.NumericUpDown();
            this.labelSangriaIzquierdaEspaciadoRespuestas = new System.Windows.Forms.Label();
            this.comboBoxNumeroNumeracionPreguntas = new System.Windows.Forms.ComboBox();
            this.comboBoxNumeroNumeracionRespuestas = new System.Windows.Forms.ComboBox();
            this.groupBoxColumnasRespuestas = new System.Windows.Forms.GroupBox();
            this.radioButtonListaVerticalColumnasRespuestas = new System.Windows.Forms.RadioButton();
            this.labelListaVerticalAColumnasRespuestas = new System.Windows.Forms.Label();
            this.labelListaVerticalBColumnasRespuestas = new System.Windows.Forms.Label();
            this.labelListaHorizontalBColumnasRespuestas = new System.Windows.Forms.Label();
            this.labelListaHorizontalAColumnasRespuestas = new System.Windows.Forms.Label();
            this.radioButtonListaHorizontalColumnasRespuestas = new System.Windows.Forms.RadioButton();
            this.textBoxListaHorizontalComodinColumnasRespuestas = new System.Windows.Forms.TextBox();
            this.radioButtonSeguidoColumnasRespuestas = new System.Windows.Forms.RadioButton();
            this.textBoxSeguidoComodinColumnasRespuestas = new System.Windows.Forms.TextBox();
            this.labelSeguidoBColumnasRespuestas = new System.Windows.Forms.Label();
            this.labelSeguidoAColumnasRespuestas = new System.Windows.Forms.Label();
            this.radioButtonNumeroColumnasColumnasRespuestas = new System.Windows.Forms.RadioButton();
            this.numericUpDownNumeroColumnasColumnasRespuestas = new System.Windows.Forms.NumericUpDown();
            this.labelAnchoColumnasRespuestas = new System.Windows.Forms.Label();
            this.labelEspaciadoColumnasRespuestas = new System.Windows.Forms.Label();
            this.numericUpDownAnchoColumnasRespuestas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEspaciadoColumnasRespuestas = new System.Windows.Forms.NumericUpDown();
            this.buttonMantenerOriginalColumnasRespuestas = new System.Windows.Forms.Button();
            this.labelMantenerOriginalColumnasRespuestas = new System.Windows.Forms.Label();
            this.labelColumnaBColumnasRespuestas = new System.Windows.Forms.Label();
            this.labelColumnaAColumnasRespuestas = new System.Windows.Forms.Label();
            this.labelColumnaDColumnasRespuestas = new System.Windows.Forms.Label();
            this.labelColumnaCColumnasRespuestas = new System.Windows.Forms.Label();
            this.tabPrincipal.SuspendLayout();
            this.tabEstructura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreguntasEstructuradas)).BeginInit();
            this.tabCantidad.SuspendLayout();
            this.tabNumeracion.SuspendLayout();
            this.groupBoxCantidadDeExamenes.SuspendLayout();
            this.groupBoxIdentificacionDeExamenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExamenes)).BeginInit();
            this.groupBoxCopias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopias)).BeginInit();
            this.groupBoxUbicacionEnLaPagina.SuspendLayout();
            this.groupBoxJustificacion.SuspendLayout();
            this.groupBoxNumeracionDePreguntasGeneral.SuspendLayout();
            this.groupBoxNumeracionDeRespuestasGeneral.SuspendLayout();
            this.groupBoxNumeracionPreguntas.SuspendLayout();
            this.groupBoxColumnasPreguntas.SuspendLayout();
            this.groupBoxEspaciadoPreguntas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAntesEspaciadoPreguntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDespuesEspaciadoPreguntas)).BeginInit();
            this.groupBoxNumeracionRespuestas.SuspendLayout();
            this.groupBoxEspaciadoRespuestas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDespuesEspaciadoRespuestas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAntesEspaciadoRespuestas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSangriaIzquierdaEspaciadoRespuestas)).BeginInit();
            this.groupBoxColumnasRespuestas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroColumnasColumnasRespuestas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnchoColumnasRespuestas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEspaciadoColumnasRespuestas)).BeginInit();
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
            this.tabNumeracion.Controls.Add(this.groupBoxNumeracionDeRespuestasGeneral);
            this.tabNumeracion.Controls.Add(this.groupBoxNumeracionDePreguntasGeneral);
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
            this.groupBoxCantidadDeExamenes.Location = new System.Drawing.Point(15, 25);
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
            // groupBoxNumeracionDePreguntasGeneral
            // 
            this.groupBoxNumeracionDePreguntasGeneral.Controls.Add(this.groupBoxEspaciadoPreguntas);
            this.groupBoxNumeracionDePreguntasGeneral.Controls.Add(this.groupBoxColumnasPreguntas);
            this.groupBoxNumeracionDePreguntasGeneral.Controls.Add(this.groupBoxNumeracionPreguntas);
            this.groupBoxNumeracionDePreguntasGeneral.Location = new System.Drawing.Point(15, 25);
            this.groupBoxNumeracionDePreguntasGeneral.Name = "groupBoxNumeracionDePreguntasGeneral";
            this.groupBoxNumeracionDePreguntasGeneral.Size = new System.Drawing.Size(315, 350);
            this.groupBoxNumeracionDePreguntasGeneral.TabIndex = 0;
            this.groupBoxNumeracionDePreguntasGeneral.TabStop = false;
            this.groupBoxNumeracionDePreguntasGeneral.Text = "Numeración de preguntas (#) ";
            // 
            // groupBoxNumeracionDeRespuestasGeneral
            // 
            this.groupBoxNumeracionDeRespuestasGeneral.Controls.Add(this.groupBoxColumnasRespuestas);
            this.groupBoxNumeracionDeRespuestasGeneral.Controls.Add(this.groupBoxEspaciadoRespuestas);
            this.groupBoxNumeracionDeRespuestasGeneral.Controls.Add(this.groupBoxNumeracionRespuestas);
            this.groupBoxNumeracionDeRespuestasGeneral.Location = new System.Drawing.Point(336, 25);
            this.groupBoxNumeracionDeRespuestasGeneral.Name = "groupBoxNumeracionDeRespuestasGeneral";
            this.groupBoxNumeracionDeRespuestasGeneral.Size = new System.Drawing.Size(408, 350);
            this.groupBoxNumeracionDeRespuestasGeneral.TabIndex = 1;
            this.groupBoxNumeracionDeRespuestasGeneral.TabStop = false;
            this.groupBoxNumeracionDeRespuestasGeneral.Text = "Numeración de las opciones de respuestas (&&, &&&&) ";
            // 
            // groupBoxNumeracionPreguntas
            // 
            this.groupBoxNumeracionPreguntas.Controls.Add(this.comboBoxNumeroNumeracionPreguntas);
            this.groupBoxNumeracionPreguntas.Controls.Add(this.labelNumeracionResultadoNumeracionPreguntas);
            this.groupBoxNumeracionPreguntas.Controls.Add(this.buttonMantenerOriginalNumeracionPreguntas);
            this.groupBoxNumeracionPreguntas.Controls.Add(this.labelMantenerOriginalNumeracionPreguntas);
            this.groupBoxNumeracionPreguntas.Controls.Add(this.textBoxDespuesNumeracionPreguntas);
            this.groupBoxNumeracionPreguntas.Controls.Add(this.textBoxAntesNumeracionPreguntas);
            this.groupBoxNumeracionPreguntas.Controls.Add(this.labelDespuesNumeracionPreguntas);
            this.groupBoxNumeracionPreguntas.Controls.Add(this.labelNumeroNumeracionPreguntas);
            this.groupBoxNumeracionPreguntas.Controls.Add(this.labelAntesNumeracionPreguntas);
            this.groupBoxNumeracionPreguntas.Location = new System.Drawing.Point(10, 20);
            this.groupBoxNumeracionPreguntas.Name = "groupBoxNumeracionPreguntas";
            this.groupBoxNumeracionPreguntas.Size = new System.Drawing.Size(165, 100);
            this.groupBoxNumeracionPreguntas.TabIndex = 0;
            this.groupBoxNumeracionPreguntas.TabStop = false;
            this.groupBoxNumeracionPreguntas.Text = "Numeración";
            // 
            // labelAntesNumeracionPreguntas
            // 
            this.labelAntesNumeracionPreguntas.AutoSize = true;
            this.labelAntesNumeracionPreguntas.Location = new System.Drawing.Point(10, 20);
            this.labelAntesNumeracionPreguntas.Name = "labelAntesNumeracionPreguntas";
            this.labelAntesNumeracionPreguntas.Size = new System.Drawing.Size(34, 13);
            this.labelAntesNumeracionPreguntas.TabIndex = 0;
            this.labelAntesNumeracionPreguntas.Text = "Antes";
            // 
            // labelNumeroNumeracionPreguntas
            // 
            this.labelNumeroNumeracionPreguntas.AutoSize = true;
            this.labelNumeroNumeracionPreguntas.Location = new System.Drawing.Point(50, 20);
            this.labelNumeroNumeracionPreguntas.Name = "labelNumeroNumeracionPreguntas";
            this.labelNumeroNumeracionPreguntas.Size = new System.Drawing.Size(24, 13);
            this.labelNumeroNumeracionPreguntas.TabIndex = 1;
            this.labelNumeroNumeracionPreguntas.Text = "No.";
            // 
            // labelDespuesNumeracionPreguntas
            // 
            this.labelDespuesNumeracionPreguntas.AutoSize = true;
            this.labelDespuesNumeracionPreguntas.Location = new System.Drawing.Point(90, 20);
            this.labelDespuesNumeracionPreguntas.Name = "labelDespuesNumeracionPreguntas";
            this.labelDespuesNumeracionPreguntas.Size = new System.Drawing.Size(49, 13);
            this.labelDespuesNumeracionPreguntas.TabIndex = 2;
            this.labelDespuesNumeracionPreguntas.Text = "Después";
            // 
            // textBoxAntesNumeracionPreguntas
            // 
            this.textBoxAntesNumeracionPreguntas.Location = new System.Drawing.Point(13, 36);
            this.textBoxAntesNumeracionPreguntas.Name = "textBoxAntesNumeracionPreguntas";
            this.textBoxAntesNumeracionPreguntas.Size = new System.Drawing.Size(35, 20);
            this.textBoxAntesNumeracionPreguntas.TabIndex = 3;
            // 
            // textBoxDespuesNumeracionPreguntas
            // 
            this.textBoxDespuesNumeracionPreguntas.Location = new System.Drawing.Point(93, 36);
            this.textBoxDespuesNumeracionPreguntas.Name = "textBoxDespuesNumeracionPreguntas";
            this.textBoxDespuesNumeracionPreguntas.Size = new System.Drawing.Size(35, 20);
            this.textBoxDespuesNumeracionPreguntas.TabIndex = 5;
            // 
            // labelMantenerOriginalNumeracionPreguntas
            // 
            this.labelMantenerOriginalNumeracionPreguntas.AutoSize = true;
            this.labelMantenerOriginalNumeracionPreguntas.Location = new System.Drawing.Point(10, 70);
            this.labelMantenerOriginalNumeracionPreguntas.Name = "labelMantenerOriginalNumeracionPreguntas";
            this.labelMantenerOriginalNumeracionPreguntas.Size = new System.Drawing.Size(88, 13);
            this.labelMantenerOriginalNumeracionPreguntas.TabIndex = 6;
            this.labelMantenerOriginalNumeracionPreguntas.Text = "Mantener original";
            // 
            // buttonMantenerOriginalNumeracionPreguntas
            // 
            this.buttonMantenerOriginalNumeracionPreguntas.Location = new System.Drawing.Point(104, 65);
            this.buttonMantenerOriginalNumeracionPreguntas.Name = "buttonMantenerOriginalNumeracionPreguntas";
            this.buttonMantenerOriginalNumeracionPreguntas.Size = new System.Drawing.Size(35, 23);
            this.buttonMantenerOriginalNumeracionPreguntas.TabIndex = 7;
            this.buttonMantenerOriginalNumeracionPreguntas.Text = "SI";
            this.buttonMantenerOriginalNumeracionPreguntas.UseVisualStyleBackColor = true;
            // 
            // labelNumeracionResultadoNumeracionPreguntas
            // 
            this.labelNumeracionResultadoNumeracionPreguntas.AutoSize = true;
            this.labelNumeracionResultadoNumeracionPreguntas.Location = new System.Drawing.Point(134, 39);
            this.labelNumeracionResultadoNumeracionPreguntas.Name = "labelNumeracionResultadoNumeracionPreguntas";
            this.labelNumeracionResultadoNumeracionPreguntas.Size = new System.Drawing.Size(16, 13);
            this.labelNumeracionResultadoNumeracionPreguntas.TabIndex = 8;
            this.labelNumeracionResultadoNumeracionPreguntas.Text = "1)";
            // 
            // groupBoxColumnasPreguntas
            // 
            this.groupBoxColumnasPreguntas.Controls.Add(this.radioButtonMantenerOriginalColumnasPreguntas);
            this.groupBoxColumnasPreguntas.Controls.Add(this.radioButtonDosColumnasPreguntas);
            this.groupBoxColumnasPreguntas.Controls.Add(this.radioButtonUnaColumnasPreguntas);
            this.groupBoxColumnasPreguntas.Location = new System.Drawing.Point(185, 20);
            this.groupBoxColumnasPreguntas.Name = "groupBoxColumnasPreguntas";
            this.groupBoxColumnasPreguntas.Size = new System.Drawing.Size(120, 100);
            this.groupBoxColumnasPreguntas.TabIndex = 1;
            this.groupBoxColumnasPreguntas.TabStop = false;
            this.groupBoxColumnasPreguntas.Text = "Columnas";
            // 
            // radioButtonUnaColumnasPreguntas
            // 
            this.radioButtonUnaColumnasPreguntas.AutoSize = true;
            this.radioButtonUnaColumnasPreguntas.Location = new System.Drawing.Point(10, 25);
            this.radioButtonUnaColumnasPreguntas.Name = "radioButtonUnaColumnasPreguntas";
            this.radioButtonUnaColumnasPreguntas.Size = new System.Drawing.Size(45, 17);
            this.radioButtonUnaColumnasPreguntas.TabIndex = 0;
            this.radioButtonUnaColumnasPreguntas.TabStop = true;
            this.radioButtonUnaColumnasPreguntas.Text = "Una";
            this.radioButtonUnaColumnasPreguntas.UseVisualStyleBackColor = true;
            // 
            // radioButtonDosColumnasPreguntas
            // 
            this.radioButtonDosColumnasPreguntas.AutoSize = true;
            this.radioButtonDosColumnasPreguntas.Location = new System.Drawing.Point(61, 25);
            this.radioButtonDosColumnasPreguntas.Name = "radioButtonDosColumnasPreguntas";
            this.radioButtonDosColumnasPreguntas.Size = new System.Drawing.Size(44, 17);
            this.radioButtonDosColumnasPreguntas.TabIndex = 1;
            this.radioButtonDosColumnasPreguntas.TabStop = true;
            this.radioButtonDosColumnasPreguntas.Text = "Dos";
            this.radioButtonDosColumnasPreguntas.UseVisualStyleBackColor = true;
            // 
            // radioButtonMantenerOriginalColumnasPreguntas
            // 
            this.radioButtonMantenerOriginalColumnasPreguntas.AutoSize = true;
            this.radioButtonMantenerOriginalColumnasPreguntas.Location = new System.Drawing.Point(10, 50);
            this.radioButtonMantenerOriginalColumnasPreguntas.Name = "radioButtonMantenerOriginalColumnasPreguntas";
            this.radioButtonMantenerOriginalColumnasPreguntas.Size = new System.Drawing.Size(106, 17);
            this.radioButtonMantenerOriginalColumnasPreguntas.TabIndex = 2;
            this.radioButtonMantenerOriginalColumnasPreguntas.TabStop = true;
            this.radioButtonMantenerOriginalColumnasPreguntas.Text = "Mantener original";
            this.radioButtonMantenerOriginalColumnasPreguntas.UseVisualStyleBackColor = true;
            // 
            // groupBoxEspaciadoPreguntas
            // 
            this.groupBoxEspaciadoPreguntas.Controls.Add(this.labelInterlineadoEspaciadoPreguntas);
            this.groupBoxEspaciadoPreguntas.Controls.Add(this.buttonMantenerOriginalEspaciadoPreguntas);
            this.groupBoxEspaciadoPreguntas.Controls.Add(this.labelMantenerOriginalEspaciadoPreguntas);
            this.groupBoxEspaciadoPreguntas.Controls.Add(this.comboBoxInterlineadoEspaciadoPreguntas);
            this.groupBoxEspaciadoPreguntas.Controls.Add(this.numericUpDownDespuesEspaciadoPreguntas);
            this.groupBoxEspaciadoPreguntas.Controls.Add(this.labelDespuesEspaciadoPreguntas);
            this.groupBoxEspaciadoPreguntas.Controls.Add(this.numericUpDownAntesEspaciadoPreguntas);
            this.groupBoxEspaciadoPreguntas.Controls.Add(this.labelAntesEspaciadoPreguntas);
            this.groupBoxEspaciadoPreguntas.Location = new System.Drawing.Point(10, 140);
            this.groupBoxEspaciadoPreguntas.Name = "groupBoxEspaciadoPreguntas";
            this.groupBoxEspaciadoPreguntas.Size = new System.Drawing.Size(295, 150);
            this.groupBoxEspaciadoPreguntas.TabIndex = 2;
            this.groupBoxEspaciadoPreguntas.TabStop = false;
            this.groupBoxEspaciadoPreguntas.Text = "Espaciado";
            // 
            // labelAntesEspaciadoPreguntas
            // 
            this.labelAntesEspaciadoPreguntas.AutoSize = true;
            this.labelAntesEspaciadoPreguntas.Location = new System.Drawing.Point(10, 25);
            this.labelAntesEspaciadoPreguntas.Name = "labelAntesEspaciadoPreguntas";
            this.labelAntesEspaciadoPreguntas.Size = new System.Drawing.Size(34, 13);
            this.labelAntesEspaciadoPreguntas.TabIndex = 1;
            this.labelAntesEspaciadoPreguntas.Text = "Antes";
            // 
            // numericUpDownAntesEspaciadoPreguntas
            // 
            this.numericUpDownAntesEspaciadoPreguntas.Location = new System.Drawing.Point(80, 23);
            this.numericUpDownAntesEspaciadoPreguntas.Name = "numericUpDownAntesEspaciadoPreguntas";
            this.numericUpDownAntesEspaciadoPreguntas.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownAntesEspaciadoPreguntas.TabIndex = 5;
            // 
            // labelDespuesEspaciadoPreguntas
            // 
            this.labelDespuesEspaciadoPreguntas.AutoSize = true;
            this.labelDespuesEspaciadoPreguntas.Location = new System.Drawing.Point(10, 51);
            this.labelDespuesEspaciadoPreguntas.Name = "labelDespuesEspaciadoPreguntas";
            this.labelDespuesEspaciadoPreguntas.Size = new System.Drawing.Size(49, 13);
            this.labelDespuesEspaciadoPreguntas.TabIndex = 6;
            this.labelDespuesEspaciadoPreguntas.Text = "Después";
            // 
            // numericUpDownDespuesEspaciadoPreguntas
            // 
            this.numericUpDownDespuesEspaciadoPreguntas.Location = new System.Drawing.Point(80, 49);
            this.numericUpDownDespuesEspaciadoPreguntas.Name = "numericUpDownDespuesEspaciadoPreguntas";
            this.numericUpDownDespuesEspaciadoPreguntas.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownDespuesEspaciadoPreguntas.TabIndex = 7;
            // 
            // comboBoxInterlineadoEspaciadoPreguntas
            // 
            this.comboBoxInterlineadoEspaciadoPreguntas.FormattingEnabled = true;
            this.comboBoxInterlineadoEspaciadoPreguntas.Location = new System.Drawing.Point(80, 75);
            this.comboBoxInterlineadoEspaciadoPreguntas.Name = "comboBoxInterlineadoEspaciadoPreguntas";
            this.comboBoxInterlineadoEspaciadoPreguntas.Size = new System.Drawing.Size(85, 21);
            this.comboBoxInterlineadoEspaciadoPreguntas.TabIndex = 8;
            // 
            // buttonMantenerOriginalEspaciadoPreguntas
            // 
            this.buttonMantenerOriginalEspaciadoPreguntas.Location = new System.Drawing.Point(104, 102);
            this.buttonMantenerOriginalEspaciadoPreguntas.Name = "buttonMantenerOriginalEspaciadoPreguntas";
            this.buttonMantenerOriginalEspaciadoPreguntas.Size = new System.Drawing.Size(35, 23);
            this.buttonMantenerOriginalEspaciadoPreguntas.TabIndex = 10;
            this.buttonMantenerOriginalEspaciadoPreguntas.Text = "SI";
            this.buttonMantenerOriginalEspaciadoPreguntas.UseVisualStyleBackColor = true;
            // 
            // labelMantenerOriginalEspaciadoPreguntas
            // 
            this.labelMantenerOriginalEspaciadoPreguntas.AutoSize = true;
            this.labelMantenerOriginalEspaciadoPreguntas.Location = new System.Drawing.Point(10, 107);
            this.labelMantenerOriginalEspaciadoPreguntas.Name = "labelMantenerOriginalEspaciadoPreguntas";
            this.labelMantenerOriginalEspaciadoPreguntas.Size = new System.Drawing.Size(88, 13);
            this.labelMantenerOriginalEspaciadoPreguntas.TabIndex = 9;
            this.labelMantenerOriginalEspaciadoPreguntas.Text = "Mantener original";
            // 
            // labelInterlineadoEspaciadoPreguntas
            // 
            this.labelInterlineadoEspaciadoPreguntas.AutoSize = true;
            this.labelInterlineadoEspaciadoPreguntas.Location = new System.Drawing.Point(10, 78);
            this.labelInterlineadoEspaciadoPreguntas.Name = "labelInterlineadoEspaciadoPreguntas";
            this.labelInterlineadoEspaciadoPreguntas.Size = new System.Drawing.Size(62, 13);
            this.labelInterlineadoEspaciadoPreguntas.TabIndex = 11;
            this.labelInterlineadoEspaciadoPreguntas.Text = "Interlineado";
            // 
            // groupBoxNumeracionRespuestas
            // 
            this.groupBoxNumeracionRespuestas.Controls.Add(this.comboBoxNumeroNumeracionRespuestas);
            this.groupBoxNumeracionRespuestas.Controls.Add(this.labelNumeracionResultadoNumeracionRespuestas);
            this.groupBoxNumeracionRespuestas.Controls.Add(this.buttonMantenerOriginalNumeracionRespuestas);
            this.groupBoxNumeracionRespuestas.Controls.Add(this.labelMantenerOriginalNumeracionRespuestas);
            this.groupBoxNumeracionRespuestas.Controls.Add(this.textBoxDespuesNumeracionRespuestas);
            this.groupBoxNumeracionRespuestas.Controls.Add(this.textBoxAntesNumeracionRespuestas);
            this.groupBoxNumeracionRespuestas.Controls.Add(this.labelDespuesNumeracionRespuestas);
            this.groupBoxNumeracionRespuestas.Controls.Add(this.labelNumeroNumeracionRespuestas);
            this.groupBoxNumeracionRespuestas.Controls.Add(this.labelAntesNumeracionRespuestas);
            this.groupBoxNumeracionRespuestas.Location = new System.Drawing.Point(10, 20);
            this.groupBoxNumeracionRespuestas.Name = "groupBoxNumeracionRespuestas";
            this.groupBoxNumeracionRespuestas.Size = new System.Drawing.Size(200, 100);
            this.groupBoxNumeracionRespuestas.TabIndex = 1;
            this.groupBoxNumeracionRespuestas.TabStop = false;
            this.groupBoxNumeracionRespuestas.Text = "Numeración";
            // 
            // labelNumeracionResultadoNumeracionRespuestas
            // 
            this.labelNumeracionResultadoNumeracionRespuestas.AutoSize = true;
            this.labelNumeracionResultadoNumeracionRespuestas.Location = new System.Drawing.Point(134, 39);
            this.labelNumeracionResultadoNumeracionRespuestas.Name = "labelNumeracionResultadoNumeracionRespuestas";
            this.labelNumeracionResultadoNumeracionRespuestas.Size = new System.Drawing.Size(16, 13);
            this.labelNumeracionResultadoNumeracionRespuestas.TabIndex = 8;
            this.labelNumeracionResultadoNumeracionRespuestas.Text = "a)";
            // 
            // buttonMantenerOriginalNumeracionRespuestas
            // 
            this.buttonMantenerOriginalNumeracionRespuestas.Location = new System.Drawing.Point(104, 65);
            this.buttonMantenerOriginalNumeracionRespuestas.Name = "buttonMantenerOriginalNumeracionRespuestas";
            this.buttonMantenerOriginalNumeracionRespuestas.Size = new System.Drawing.Size(35, 23);
            this.buttonMantenerOriginalNumeracionRespuestas.TabIndex = 7;
            this.buttonMantenerOriginalNumeracionRespuestas.Text = "SI";
            this.buttonMantenerOriginalNumeracionRespuestas.UseVisualStyleBackColor = true;
            // 
            // labelMantenerOriginalNumeracionRespuestas
            // 
            this.labelMantenerOriginalNumeracionRespuestas.AutoSize = true;
            this.labelMantenerOriginalNumeracionRespuestas.Location = new System.Drawing.Point(10, 70);
            this.labelMantenerOriginalNumeracionRespuestas.Name = "labelMantenerOriginalNumeracionRespuestas";
            this.labelMantenerOriginalNumeracionRespuestas.Size = new System.Drawing.Size(88, 13);
            this.labelMantenerOriginalNumeracionRespuestas.TabIndex = 6;
            this.labelMantenerOriginalNumeracionRespuestas.Text = "Mantener original";
            // 
            // textBoxDespuesNumeracionRespuestas
            // 
            this.textBoxDespuesNumeracionRespuestas.Location = new System.Drawing.Point(93, 36);
            this.textBoxDespuesNumeracionRespuestas.Name = "textBoxDespuesNumeracionRespuestas";
            this.textBoxDespuesNumeracionRespuestas.Size = new System.Drawing.Size(35, 20);
            this.textBoxDespuesNumeracionRespuestas.TabIndex = 5;
            // 
            // textBoxAntesNumeracionRespuestas
            // 
            this.textBoxAntesNumeracionRespuestas.Location = new System.Drawing.Point(13, 36);
            this.textBoxAntesNumeracionRespuestas.Name = "textBoxAntesNumeracionRespuestas";
            this.textBoxAntesNumeracionRespuestas.Size = new System.Drawing.Size(35, 20);
            this.textBoxAntesNumeracionRespuestas.TabIndex = 3;
            // 
            // labelDespuesNumeracionRespuestas
            // 
            this.labelDespuesNumeracionRespuestas.AutoSize = true;
            this.labelDespuesNumeracionRespuestas.Location = new System.Drawing.Point(90, 20);
            this.labelDespuesNumeracionRespuestas.Name = "labelDespuesNumeracionRespuestas";
            this.labelDespuesNumeracionRespuestas.Size = new System.Drawing.Size(49, 13);
            this.labelDespuesNumeracionRespuestas.TabIndex = 2;
            this.labelDespuesNumeracionRespuestas.Text = "Después";
            // 
            // labelNumeroNumeracionRespuestas
            // 
            this.labelNumeroNumeracionRespuestas.AutoSize = true;
            this.labelNumeroNumeracionRespuestas.Location = new System.Drawing.Point(50, 20);
            this.labelNumeroNumeracionRespuestas.Name = "labelNumeroNumeracionRespuestas";
            this.labelNumeroNumeracionRespuestas.Size = new System.Drawing.Size(24, 13);
            this.labelNumeroNumeracionRespuestas.TabIndex = 1;
            this.labelNumeroNumeracionRespuestas.Text = "No.";
            // 
            // labelAntesNumeracionRespuestas
            // 
            this.labelAntesNumeracionRespuestas.AutoSize = true;
            this.labelAntesNumeracionRespuestas.Location = new System.Drawing.Point(10, 20);
            this.labelAntesNumeracionRespuestas.Name = "labelAntesNumeracionRespuestas";
            this.labelAntesNumeracionRespuestas.Size = new System.Drawing.Size(34, 13);
            this.labelAntesNumeracionRespuestas.TabIndex = 0;
            this.labelAntesNumeracionRespuestas.Text = "Antes";
            // 
            // groupBoxEspaciadoRespuestas
            // 
            this.groupBoxEspaciadoRespuestas.Controls.Add(this.numericUpDownSangriaIzquierdaEspaciadoRespuestas);
            this.groupBoxEspaciadoRespuestas.Controls.Add(this.labelSangriaIzquierdaEspaciadoRespuestas);
            this.groupBoxEspaciadoRespuestas.Controls.Add(this.labelInterlineadoEspaciadoRespuestas);
            this.groupBoxEspaciadoRespuestas.Controls.Add(this.buttonMantenerOriginalEspaciadoRespuestas);
            this.groupBoxEspaciadoRespuestas.Controls.Add(this.labelMantenerOriginalEspaciadoRespuestas);
            this.groupBoxEspaciadoRespuestas.Controls.Add(this.comboBoxInterlineadoEspaciadoRespuestas);
            this.groupBoxEspaciadoRespuestas.Controls.Add(this.numericUpDownDespuesEspaciadoRespuestas);
            this.groupBoxEspaciadoRespuestas.Controls.Add(this.labelDespuesEspaciadoRespuestas);
            this.groupBoxEspaciadoRespuestas.Controls.Add(this.numericUpDownAntesEspaciadoRespuestas);
            this.groupBoxEspaciadoRespuestas.Controls.Add(this.labelAntesEspaciadoRespuestas);
            this.groupBoxEspaciadoRespuestas.Location = new System.Drawing.Point(10, 140);
            this.groupBoxEspaciadoRespuestas.Name = "groupBoxEspaciadoRespuestas";
            this.groupBoxEspaciadoRespuestas.Size = new System.Drawing.Size(200, 188);
            this.groupBoxEspaciadoRespuestas.TabIndex = 3;
            this.groupBoxEspaciadoRespuestas.TabStop = false;
            this.groupBoxEspaciadoRespuestas.Text = "Espaciado";
            // 
            // labelInterlineadoEspaciadoRespuestas
            // 
            this.labelInterlineadoEspaciadoRespuestas.AutoSize = true;
            this.labelInterlineadoEspaciadoRespuestas.Location = new System.Drawing.Point(10, 78);
            this.labelInterlineadoEspaciadoRespuestas.Name = "labelInterlineadoEspaciadoRespuestas";
            this.labelInterlineadoEspaciadoRespuestas.Size = new System.Drawing.Size(62, 13);
            this.labelInterlineadoEspaciadoRespuestas.TabIndex = 11;
            this.labelInterlineadoEspaciadoRespuestas.Text = "Interlineado";
            // 
            // buttonMantenerOriginalEspaciadoRespuestas
            // 
            this.buttonMantenerOriginalEspaciadoRespuestas.Location = new System.Drawing.Point(104, 128);
            this.buttonMantenerOriginalEspaciadoRespuestas.Name = "buttonMantenerOriginalEspaciadoRespuestas";
            this.buttonMantenerOriginalEspaciadoRespuestas.Size = new System.Drawing.Size(35, 23);
            this.buttonMantenerOriginalEspaciadoRespuestas.TabIndex = 10;
            this.buttonMantenerOriginalEspaciadoRespuestas.Text = "SI";
            this.buttonMantenerOriginalEspaciadoRespuestas.UseVisualStyleBackColor = true;
            // 
            // labelMantenerOriginalEspaciadoRespuestas
            // 
            this.labelMantenerOriginalEspaciadoRespuestas.AutoSize = true;
            this.labelMantenerOriginalEspaciadoRespuestas.Location = new System.Drawing.Point(10, 133);
            this.labelMantenerOriginalEspaciadoRespuestas.Name = "labelMantenerOriginalEspaciadoRespuestas";
            this.labelMantenerOriginalEspaciadoRespuestas.Size = new System.Drawing.Size(88, 13);
            this.labelMantenerOriginalEspaciadoRespuestas.TabIndex = 9;
            this.labelMantenerOriginalEspaciadoRespuestas.Text = "Mantener original";
            // 
            // comboBoxInterlineadoEspaciadoRespuestas
            // 
            this.comboBoxInterlineadoEspaciadoRespuestas.FormattingEnabled = true;
            this.comboBoxInterlineadoEspaciadoRespuestas.Location = new System.Drawing.Point(105, 75);
            this.comboBoxInterlineadoEspaciadoRespuestas.Name = "comboBoxInterlineadoEspaciadoRespuestas";
            this.comboBoxInterlineadoEspaciadoRespuestas.Size = new System.Drawing.Size(85, 21);
            this.comboBoxInterlineadoEspaciadoRespuestas.TabIndex = 8;
            // 
            // numericUpDownDespuesEspaciadoRespuestas
            // 
            this.numericUpDownDespuesEspaciadoRespuestas.Location = new System.Drawing.Point(105, 49);
            this.numericUpDownDespuesEspaciadoRespuestas.Name = "numericUpDownDespuesEspaciadoRespuestas";
            this.numericUpDownDespuesEspaciadoRespuestas.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownDespuesEspaciadoRespuestas.TabIndex = 7;
            // 
            // labelDespuesEspaciadoRespuestas
            // 
            this.labelDespuesEspaciadoRespuestas.AutoSize = true;
            this.labelDespuesEspaciadoRespuestas.Location = new System.Drawing.Point(10, 51);
            this.labelDespuesEspaciadoRespuestas.Name = "labelDespuesEspaciadoRespuestas";
            this.labelDespuesEspaciadoRespuestas.Size = new System.Drawing.Size(49, 13);
            this.labelDespuesEspaciadoRespuestas.TabIndex = 6;
            this.labelDespuesEspaciadoRespuestas.Text = "Después";
            // 
            // numericUpDownAntesEspaciadoRespuestas
            // 
            this.numericUpDownAntesEspaciadoRespuestas.Location = new System.Drawing.Point(105, 23);
            this.numericUpDownAntesEspaciadoRespuestas.Name = "numericUpDownAntesEspaciadoRespuestas";
            this.numericUpDownAntesEspaciadoRespuestas.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownAntesEspaciadoRespuestas.TabIndex = 5;
            // 
            // labelAntesEspaciadoRespuestas
            // 
            this.labelAntesEspaciadoRespuestas.AutoSize = true;
            this.labelAntesEspaciadoRespuestas.Location = new System.Drawing.Point(10, 25);
            this.labelAntesEspaciadoRespuestas.Name = "labelAntesEspaciadoRespuestas";
            this.labelAntesEspaciadoRespuestas.Size = new System.Drawing.Size(34, 13);
            this.labelAntesEspaciadoRespuestas.TabIndex = 1;
            this.labelAntesEspaciadoRespuestas.Text = "Antes";
            // 
            // numericUpDownSangriaIzquierdaEspaciadoRespuestas
            // 
            this.numericUpDownSangriaIzquierdaEspaciadoRespuestas.Location = new System.Drawing.Point(105, 102);
            this.numericUpDownSangriaIzquierdaEspaciadoRespuestas.Name = "numericUpDownSangriaIzquierdaEspaciadoRespuestas";
            this.numericUpDownSangriaIzquierdaEspaciadoRespuestas.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownSangriaIzquierdaEspaciadoRespuestas.TabIndex = 13;
            // 
            // labelSangriaIzquierdaEspaciadoRespuestas
            // 
            this.labelSangriaIzquierdaEspaciadoRespuestas.AutoSize = true;
            this.labelSangriaIzquierdaEspaciadoRespuestas.Location = new System.Drawing.Point(10, 104);
            this.labelSangriaIzquierdaEspaciadoRespuestas.Name = "labelSangriaIzquierdaEspaciadoRespuestas";
            this.labelSangriaIzquierdaEspaciadoRespuestas.Size = new System.Drawing.Size(90, 13);
            this.labelSangriaIzquierdaEspaciadoRespuestas.TabIndex = 12;
            this.labelSangriaIzquierdaEspaciadoRespuestas.Text = "Sangría izquierda";
            // 
            // comboBoxNumeroNumeracionPreguntas
            // 
            this.comboBoxNumeroNumeracionPreguntas.FormattingEnabled = true;
            this.comboBoxNumeroNumeracionPreguntas.Location = new System.Drawing.Point(53, 36);
            this.comboBoxNumeroNumeracionPreguntas.Name = "comboBoxNumeroNumeracionPreguntas";
            this.comboBoxNumeroNumeracionPreguntas.Size = new System.Drawing.Size(35, 21);
            this.comboBoxNumeroNumeracionPreguntas.TabIndex = 9;
            // 
            // comboBoxNumeroNumeracionRespuestas
            // 
            this.comboBoxNumeroNumeracionRespuestas.FormattingEnabled = true;
            this.comboBoxNumeroNumeracionRespuestas.Location = new System.Drawing.Point(53, 36);
            this.comboBoxNumeroNumeracionRespuestas.Name = "comboBoxNumeroNumeracionRespuestas";
            this.comboBoxNumeroNumeracionRespuestas.Size = new System.Drawing.Size(35, 21);
            this.comboBoxNumeroNumeracionRespuestas.TabIndex = 10;
            // 
            // groupBoxColumnasRespuestas
            // 
            this.groupBoxColumnasRespuestas.Controls.Add(this.labelColumnaDColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.labelColumnaCColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.labelColumnaBColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.labelColumnaAColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.buttonMantenerOriginalColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.labelMantenerOriginalColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.numericUpDownEspaciadoColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.numericUpDownAnchoColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.labelEspaciadoColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.labelAnchoColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.numericUpDownNumeroColumnasColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.radioButtonNumeroColumnasColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.textBoxSeguidoComodinColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.labelSeguidoBColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.labelSeguidoAColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.radioButtonSeguidoColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.textBoxListaHorizontalComodinColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.labelListaHorizontalBColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.labelListaHorizontalAColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.radioButtonListaHorizontalColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.labelListaVerticalBColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.labelListaVerticalAColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Controls.Add(this.radioButtonListaVerticalColumnasRespuestas);
            this.groupBoxColumnasRespuestas.Location = new System.Drawing.Point(216, 20);
            this.groupBoxColumnasRespuestas.Name = "groupBoxColumnasRespuestas";
            this.groupBoxColumnasRespuestas.Size = new System.Drawing.Size(180, 308);
            this.groupBoxColumnasRespuestas.TabIndex = 4;
            this.groupBoxColumnasRespuestas.TabStop = false;
            this.groupBoxColumnasRespuestas.Text = "Columnas";
            // 
            // radioButtonListaVerticalColumnasRespuestas
            // 
            this.radioButtonListaVerticalColumnasRespuestas.AutoSize = true;
            this.radioButtonListaVerticalColumnasRespuestas.Location = new System.Drawing.Point(10, 25);
            this.radioButtonListaVerticalColumnasRespuestas.Name = "radioButtonListaVerticalColumnasRespuestas";
            this.radioButtonListaVerticalColumnasRespuestas.Size = new System.Drawing.Size(84, 17);
            this.radioButtonListaVerticalColumnasRespuestas.TabIndex = 0;
            this.radioButtonListaVerticalColumnasRespuestas.TabStop = true;
            this.radioButtonListaVerticalColumnasRespuestas.Text = "Lista vertical";
            this.radioButtonListaVerticalColumnasRespuestas.UseVisualStyleBackColor = true;
            // 
            // labelListaVerticalAColumnasRespuestas
            // 
            this.labelListaVerticalAColumnasRespuestas.AutoSize = true;
            this.labelListaVerticalAColumnasRespuestas.Location = new System.Drawing.Point(30, 45);
            this.labelListaVerticalAColumnasRespuestas.Name = "labelListaVerticalAColumnasRespuestas";
            this.labelListaVerticalAColumnasRespuestas.Size = new System.Drawing.Size(16, 13);
            this.labelListaVerticalAColumnasRespuestas.TabIndex = 1;
            this.labelListaVerticalAColumnasRespuestas.Text = "a)";
            // 
            // labelListaVerticalBColumnasRespuestas
            // 
            this.labelListaVerticalBColumnasRespuestas.AutoSize = true;
            this.labelListaVerticalBColumnasRespuestas.Location = new System.Drawing.Point(30, 62);
            this.labelListaVerticalBColumnasRespuestas.Name = "labelListaVerticalBColumnasRespuestas";
            this.labelListaVerticalBColumnasRespuestas.Size = new System.Drawing.Size(16, 13);
            this.labelListaVerticalBColumnasRespuestas.TabIndex = 2;
            this.labelListaVerticalBColumnasRespuestas.Text = "b)";
            // 
            // labelListaHorizontalBColumnasRespuestas
            // 
            this.labelListaHorizontalBColumnasRespuestas.AutoSize = true;
            this.labelListaHorizontalBColumnasRespuestas.Location = new System.Drawing.Point(80, 103);
            this.labelListaHorizontalBColumnasRespuestas.Name = "labelListaHorizontalBColumnasRespuestas";
            this.labelListaHorizontalBColumnasRespuestas.Size = new System.Drawing.Size(16, 13);
            this.labelListaHorizontalBColumnasRespuestas.TabIndex = 5;
            this.labelListaHorizontalBColumnasRespuestas.Text = "b)";
            // 
            // labelListaHorizontalAColumnasRespuestas
            // 
            this.labelListaHorizontalAColumnasRespuestas.AutoSize = true;
            this.labelListaHorizontalAColumnasRespuestas.Location = new System.Drawing.Point(30, 103);
            this.labelListaHorizontalAColumnasRespuestas.Name = "labelListaHorizontalAColumnasRespuestas";
            this.labelListaHorizontalAColumnasRespuestas.Size = new System.Drawing.Size(16, 13);
            this.labelListaHorizontalAColumnasRespuestas.TabIndex = 4;
            this.labelListaHorizontalAColumnasRespuestas.Text = "a)";
            // 
            // radioButtonListaHorizontalColumnasRespuestas
            // 
            this.radioButtonListaHorizontalColumnasRespuestas.AutoSize = true;
            this.radioButtonListaHorizontalColumnasRespuestas.Location = new System.Drawing.Point(10, 83);
            this.radioButtonListaHorizontalColumnasRespuestas.Name = "radioButtonListaHorizontalColumnasRespuestas";
            this.radioButtonListaHorizontalColumnasRespuestas.Size = new System.Drawing.Size(95, 17);
            this.radioButtonListaHorizontalColumnasRespuestas.TabIndex = 3;
            this.radioButtonListaHorizontalColumnasRespuestas.TabStop = true;
            this.radioButtonListaHorizontalColumnasRespuestas.Text = "Lista horizontal";
            this.radioButtonListaHorizontalColumnasRespuestas.UseVisualStyleBackColor = true;
            // 
            // textBoxListaHorizontalComodinColumnasRespuestas
            // 
            this.textBoxListaHorizontalComodinColumnasRespuestas.Location = new System.Drawing.Point(48, 100);
            this.textBoxListaHorizontalComodinColumnasRespuestas.Name = "textBoxListaHorizontalComodinColumnasRespuestas";
            this.textBoxListaHorizontalComodinColumnasRespuestas.Size = new System.Drawing.Size(25, 20);
            this.textBoxListaHorizontalComodinColumnasRespuestas.TabIndex = 6;
            // 
            // radioButtonSeguidoColumnasRespuestas
            // 
            this.radioButtonSeguidoColumnasRespuestas.AutoSize = true;
            this.radioButtonSeguidoColumnasRespuestas.Location = new System.Drawing.Point(10, 128);
            this.radioButtonSeguidoColumnasRespuestas.Name = "radioButtonSeguidoColumnasRespuestas";
            this.radioButtonSeguidoColumnasRespuestas.Size = new System.Drawing.Size(64, 17);
            this.radioButtonSeguidoColumnasRespuestas.TabIndex = 7;
            this.radioButtonSeguidoColumnasRespuestas.TabStop = true;
            this.radioButtonSeguidoColumnasRespuestas.Text = "Seguido";
            this.radioButtonSeguidoColumnasRespuestas.UseVisualStyleBackColor = true;
            // 
            // textBoxSeguidoComodinColumnasRespuestas
            // 
            this.textBoxSeguidoComodinColumnasRespuestas.Location = new System.Drawing.Point(88, 127);
            this.textBoxSeguidoComodinColumnasRespuestas.Name = "textBoxSeguidoComodinColumnasRespuestas";
            this.textBoxSeguidoComodinColumnasRespuestas.Size = new System.Drawing.Size(25, 20);
            this.textBoxSeguidoComodinColumnasRespuestas.TabIndex = 10;
            // 
            // labelSeguidoBColumnasRespuestas
            // 
            this.labelSeguidoBColumnasRespuestas.AutoSize = true;
            this.labelSeguidoBColumnasRespuestas.Location = new System.Drawing.Point(120, 130);
            this.labelSeguidoBColumnasRespuestas.Name = "labelSeguidoBColumnasRespuestas";
            this.labelSeguidoBColumnasRespuestas.Size = new System.Drawing.Size(16, 13);
            this.labelSeguidoBColumnasRespuestas.TabIndex = 9;
            this.labelSeguidoBColumnasRespuestas.Text = "b)";
            // 
            // labelSeguidoAColumnasRespuestas
            // 
            this.labelSeguidoAColumnasRespuestas.AutoSize = true;
            this.labelSeguidoAColumnasRespuestas.Location = new System.Drawing.Point(70, 130);
            this.labelSeguidoAColumnasRespuestas.Name = "labelSeguidoAColumnasRespuestas";
            this.labelSeguidoAColumnasRespuestas.Size = new System.Drawing.Size(16, 13);
            this.labelSeguidoAColumnasRespuestas.TabIndex = 8;
            this.labelSeguidoAColumnasRespuestas.Text = "a)";
            // 
            // radioButtonNumeroColumnasColumnasRespuestas
            // 
            this.radioButtonNumeroColumnasColumnasRespuestas.AutoSize = true;
            this.radioButtonNumeroColumnasColumnasRespuestas.Location = new System.Drawing.Point(10, 153);
            this.radioButtonNumeroColumnasColumnasRespuestas.Name = "radioButtonNumeroColumnasColumnasRespuestas";
            this.radioButtonNumeroColumnasColumnasRespuestas.Size = new System.Drawing.Size(71, 17);
            this.radioButtonNumeroColumnasColumnasRespuestas.TabIndex = 11;
            this.radioButtonNumeroColumnasColumnasRespuestas.TabStop = true;
            this.radioButtonNumeroColumnasColumnasRespuestas.Text = "Columnas";
            this.radioButtonNumeroColumnasColumnasRespuestas.UseVisualStyleBackColor = true;
            // 
            // numericUpDownNumeroColumnasColumnasRespuestas
            // 
            this.numericUpDownNumeroColumnasColumnasRespuestas.Location = new System.Drawing.Point(83, 153);
            this.numericUpDownNumeroColumnasColumnasRespuestas.Name = "numericUpDownNumeroColumnasColumnasRespuestas";
            this.numericUpDownNumeroColumnasColumnasRespuestas.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownNumeroColumnasColumnasRespuestas.TabIndex = 12;
            // 
            // labelAnchoColumnasRespuestas
            // 
            this.labelAnchoColumnasRespuestas.AutoSize = true;
            this.labelAnchoColumnasRespuestas.Location = new System.Drawing.Point(32, 181);
            this.labelAnchoColumnasRespuestas.Name = "labelAnchoColumnasRespuestas";
            this.labelAnchoColumnasRespuestas.Size = new System.Drawing.Size(38, 13);
            this.labelAnchoColumnasRespuestas.TabIndex = 13;
            this.labelAnchoColumnasRespuestas.Text = "Ancho";
            // 
            // labelEspaciadoColumnasRespuestas
            // 
            this.labelEspaciadoColumnasRespuestas.AutoSize = true;
            this.labelEspaciadoColumnasRespuestas.Location = new System.Drawing.Point(105, 181);
            this.labelEspaciadoColumnasRespuestas.Name = "labelEspaciadoColumnasRespuestas";
            this.labelEspaciadoColumnasRespuestas.Size = new System.Drawing.Size(57, 13);
            this.labelEspaciadoColumnasRespuestas.TabIndex = 14;
            this.labelEspaciadoColumnasRespuestas.Text = "Espaciado";
            // 
            // numericUpDownAnchoColumnasRespuestas
            // 
            this.numericUpDownAnchoColumnasRespuestas.Location = new System.Drawing.Point(33, 198);
            this.numericUpDownAnchoColumnasRespuestas.Name = "numericUpDownAnchoColumnasRespuestas";
            this.numericUpDownAnchoColumnasRespuestas.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownAnchoColumnasRespuestas.TabIndex = 15;
            // 
            // numericUpDownEspaciadoColumnasRespuestas
            // 
            this.numericUpDownEspaciadoColumnasRespuestas.Location = new System.Drawing.Point(108, 198);
            this.numericUpDownEspaciadoColumnasRespuestas.Name = "numericUpDownEspaciadoColumnasRespuestas";
            this.numericUpDownEspaciadoColumnasRespuestas.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownEspaciadoColumnasRespuestas.TabIndex = 16;
            // 
            // buttonMantenerOriginalColumnasRespuestas
            // 
            this.buttonMantenerOriginalColumnasRespuestas.Location = new System.Drawing.Point(108, 269);
            this.buttonMantenerOriginalColumnasRespuestas.Name = "buttonMantenerOriginalColumnasRespuestas";
            this.buttonMantenerOriginalColumnasRespuestas.Size = new System.Drawing.Size(35, 23);
            this.buttonMantenerOriginalColumnasRespuestas.TabIndex = 18;
            this.buttonMantenerOriginalColumnasRespuestas.Text = "SI";
            this.buttonMantenerOriginalColumnasRespuestas.UseVisualStyleBackColor = true;
            // 
            // labelMantenerOriginalColumnasRespuestas
            // 
            this.labelMantenerOriginalColumnasRespuestas.AutoSize = true;
            this.labelMantenerOriginalColumnasRespuestas.Location = new System.Drawing.Point(14, 274);
            this.labelMantenerOriginalColumnasRespuestas.Name = "labelMantenerOriginalColumnasRespuestas";
            this.labelMantenerOriginalColumnasRespuestas.Size = new System.Drawing.Size(88, 13);
            this.labelMantenerOriginalColumnasRespuestas.TabIndex = 17;
            this.labelMantenerOriginalColumnasRespuestas.Text = "Mantener original";
            // 
            // labelColumnaBColumnasRespuestas
            // 
            this.labelColumnaBColumnasRespuestas.AutoSize = true;
            this.labelColumnaBColumnasRespuestas.Location = new System.Drawing.Point(32, 244);
            this.labelColumnaBColumnasRespuestas.Name = "labelColumnaBColumnasRespuestas";
            this.labelColumnaBColumnasRespuestas.Size = new System.Drawing.Size(16, 13);
            this.labelColumnaBColumnasRespuestas.TabIndex = 20;
            this.labelColumnaBColumnasRespuestas.Text = "b)";
            // 
            // labelColumnaAColumnasRespuestas
            // 
            this.labelColumnaAColumnasRespuestas.AutoSize = true;
            this.labelColumnaAColumnasRespuestas.Location = new System.Drawing.Point(32, 227);
            this.labelColumnaAColumnasRespuestas.Name = "labelColumnaAColumnasRespuestas";
            this.labelColumnaAColumnasRespuestas.Size = new System.Drawing.Size(16, 13);
            this.labelColumnaAColumnasRespuestas.TabIndex = 19;
            this.labelColumnaAColumnasRespuestas.Text = "a)";
            // 
            // labelColumnaDColumnasRespuestas
            // 
            this.labelColumnaDColumnasRespuestas.AutoSize = true;
            this.labelColumnaDColumnasRespuestas.Location = new System.Drawing.Point(70, 244);
            this.labelColumnaDColumnasRespuestas.Name = "labelColumnaDColumnasRespuestas";
            this.labelColumnaDColumnasRespuestas.Size = new System.Drawing.Size(16, 13);
            this.labelColumnaDColumnasRespuestas.TabIndex = 22;
            this.labelColumnaDColumnasRespuestas.Text = "d)";
            // 
            // labelColumnaCColumnasRespuestas
            // 
            this.labelColumnaCColumnasRespuestas.AutoSize = true;
            this.labelColumnaCColumnasRespuestas.Location = new System.Drawing.Point(70, 227);
            this.labelColumnaCColumnasRespuestas.Name = "labelColumnaCColumnasRespuestas";
            this.labelColumnaCColumnasRespuestas.Size = new System.Drawing.Size(16, 13);
            this.labelColumnaCColumnasRespuestas.TabIndex = 21;
            this.labelColumnaCColumnasRespuestas.Text = "c)";
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
            this.tabNumeracion.ResumeLayout(false);
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
            this.groupBoxNumeracionDePreguntasGeneral.ResumeLayout(false);
            this.groupBoxNumeracionDeRespuestasGeneral.ResumeLayout(false);
            this.groupBoxNumeracionPreguntas.ResumeLayout(false);
            this.groupBoxNumeracionPreguntas.PerformLayout();
            this.groupBoxColumnasPreguntas.ResumeLayout(false);
            this.groupBoxColumnasPreguntas.PerformLayout();
            this.groupBoxEspaciadoPreguntas.ResumeLayout(false);
            this.groupBoxEspaciadoPreguntas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAntesEspaciadoPreguntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDespuesEspaciadoPreguntas)).EndInit();
            this.groupBoxNumeracionRespuestas.ResumeLayout(false);
            this.groupBoxNumeracionRespuestas.PerformLayout();
            this.groupBoxEspaciadoRespuestas.ResumeLayout(false);
            this.groupBoxEspaciadoRespuestas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDespuesEspaciadoRespuestas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAntesEspaciadoRespuestas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSangriaIzquierdaEspaciadoRespuestas)).EndInit();
            this.groupBoxColumnasRespuestas.ResumeLayout(false);
            this.groupBoxColumnasRespuestas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroColumnasColumnasRespuestas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnchoColumnasRespuestas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEspaciadoColumnasRespuestas)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxNumeracionDeRespuestasGeneral;
        private System.Windows.Forms.GroupBox groupBoxNumeracionDePreguntasGeneral;
        private System.Windows.Forms.GroupBox groupBoxNumeracionPreguntas;
        private System.Windows.Forms.TextBox textBoxDespuesNumeracionPreguntas;
        private System.Windows.Forms.TextBox textBoxAntesNumeracionPreguntas;
        private System.Windows.Forms.Label labelDespuesNumeracionPreguntas;
        private System.Windows.Forms.Label labelNumeroNumeracionPreguntas;
        private System.Windows.Forms.Label labelAntesNumeracionPreguntas;
        private System.Windows.Forms.Button buttonMantenerOriginalNumeracionPreguntas;
        private System.Windows.Forms.Label labelMantenerOriginalNumeracionPreguntas;
        private System.Windows.Forms.GroupBox groupBoxColumnasPreguntas;
        private System.Windows.Forms.RadioButton radioButtonMantenerOriginalColumnasPreguntas;
        private System.Windows.Forms.RadioButton radioButtonDosColumnasPreguntas;
        private System.Windows.Forms.RadioButton radioButtonUnaColumnasPreguntas;
        private System.Windows.Forms.Label labelNumeracionResultadoNumeracionPreguntas;
        private System.Windows.Forms.GroupBox groupBoxEspaciadoPreguntas;
        private System.Windows.Forms.Label labelInterlineadoEspaciadoPreguntas;
        private System.Windows.Forms.Button buttonMantenerOriginalEspaciadoPreguntas;
        private System.Windows.Forms.Label labelMantenerOriginalEspaciadoPreguntas;
        private System.Windows.Forms.ComboBox comboBoxInterlineadoEspaciadoPreguntas;
        private System.Windows.Forms.NumericUpDown numericUpDownDespuesEspaciadoPreguntas;
        private System.Windows.Forms.Label labelDespuesEspaciadoPreguntas;
        private System.Windows.Forms.NumericUpDown numericUpDownAntesEspaciadoPreguntas;
        private System.Windows.Forms.Label labelAntesEspaciadoPreguntas;
        private System.Windows.Forms.GroupBox groupBoxEspaciadoRespuestas;
        private System.Windows.Forms.NumericUpDown numericUpDownSangriaIzquierdaEspaciadoRespuestas;
        private System.Windows.Forms.Label labelSangriaIzquierdaEspaciadoRespuestas;
        private System.Windows.Forms.Label labelInterlineadoEspaciadoRespuestas;
        private System.Windows.Forms.Button buttonMantenerOriginalEspaciadoRespuestas;
        private System.Windows.Forms.Label labelMantenerOriginalEspaciadoRespuestas;
        private System.Windows.Forms.ComboBox comboBoxInterlineadoEspaciadoRespuestas;
        private System.Windows.Forms.NumericUpDown numericUpDownDespuesEspaciadoRespuestas;
        private System.Windows.Forms.Label labelDespuesEspaciadoRespuestas;
        private System.Windows.Forms.NumericUpDown numericUpDownAntesEspaciadoRespuestas;
        private System.Windows.Forms.Label labelAntesEspaciadoRespuestas;
        private System.Windows.Forms.GroupBox groupBoxNumeracionRespuestas;
        private System.Windows.Forms.Label labelNumeracionResultadoNumeracionRespuestas;
        private System.Windows.Forms.Button buttonMantenerOriginalNumeracionRespuestas;
        private System.Windows.Forms.Label labelMantenerOriginalNumeracionRespuestas;
        private System.Windows.Forms.TextBox textBoxDespuesNumeracionRespuestas;
        private System.Windows.Forms.TextBox textBoxAntesNumeracionRespuestas;
        private System.Windows.Forms.Label labelDespuesNumeracionRespuestas;
        private System.Windows.Forms.Label labelNumeroNumeracionRespuestas;
        private System.Windows.Forms.Label labelAntesNumeracionRespuestas;
        private System.Windows.Forms.ComboBox comboBoxNumeroNumeracionRespuestas;
        private System.Windows.Forms.ComboBox comboBoxNumeroNumeracionPreguntas;
        private System.Windows.Forms.GroupBox groupBoxColumnasRespuestas;
        private System.Windows.Forms.Label labelColumnaDColumnasRespuestas;
        private System.Windows.Forms.Label labelColumnaCColumnasRespuestas;
        private System.Windows.Forms.Label labelColumnaBColumnasRespuestas;
        private System.Windows.Forms.Label labelColumnaAColumnasRespuestas;
        private System.Windows.Forms.Button buttonMantenerOriginalColumnasRespuestas;
        private System.Windows.Forms.Label labelMantenerOriginalColumnasRespuestas;
        private System.Windows.Forms.NumericUpDown numericUpDownEspaciadoColumnasRespuestas;
        private System.Windows.Forms.NumericUpDown numericUpDownAnchoColumnasRespuestas;
        private System.Windows.Forms.Label labelEspaciadoColumnasRespuestas;
        private System.Windows.Forms.Label labelAnchoColumnasRespuestas;
        private System.Windows.Forms.NumericUpDown numericUpDownNumeroColumnasColumnasRespuestas;
        private System.Windows.Forms.RadioButton radioButtonNumeroColumnasColumnasRespuestas;
        private System.Windows.Forms.TextBox textBoxSeguidoComodinColumnasRespuestas;
        private System.Windows.Forms.Label labelSeguidoBColumnasRespuestas;
        private System.Windows.Forms.Label labelSeguidoAColumnasRespuestas;
        private System.Windows.Forms.RadioButton radioButtonSeguidoColumnasRespuestas;
        private System.Windows.Forms.TextBox textBoxListaHorizontalComodinColumnasRespuestas;
        private System.Windows.Forms.Label labelListaHorizontalBColumnasRespuestas;
        private System.Windows.Forms.Label labelListaHorizontalAColumnasRespuestas;
        private System.Windows.Forms.RadioButton radioButtonListaHorizontalColumnasRespuestas;
        private System.Windows.Forms.Label labelListaVerticalBColumnasRespuestas;
        private System.Windows.Forms.Label labelListaVerticalAColumnasRespuestas;
        private System.Windows.Forms.RadioButton radioButtonListaVerticalColumnasRespuestas;
    }
}

