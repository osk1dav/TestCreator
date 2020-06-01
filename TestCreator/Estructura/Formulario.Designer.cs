namespace TestCreator.Estructura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataEstructura = new System.Windows.Forms.DataGridView();
            this.columntextOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columntextPreguntas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columntextTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columntextElegir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columncomboPreguntas = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columncomboRespuestas = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonClasificacionItemElegirTodo = new System.Windows.Forms.Button();
            this.buttonClasificacionItemQuitarTodo = new System.Windows.Forms.Button();
            this.pictureLimpiarRuta = new System.Windows.Forms.PictureBox();
            this.labelEstructurarTitulo = new System.Windows.Forms.Label();
            this.buttonEstructurarPreguntasElegidas = new System.Windows.Forms.Button();
            this.buttonNivelesBajar = new System.Windows.Forms.Button();
            this.buttonNivelesSubir = new System.Windows.Forms.Button();
            this.buttonNivelesIncluir = new System.Windows.Forms.Button();
            this.buttonNivelesExcluir = new System.Windows.Forms.Button();
            this.listExcluir = new System.Windows.Forms.ListBox();
            this.labelExcluir = new System.Windows.Forms.Label();
            this.listNiveles = new System.Windows.Forms.ListBox();
            this.labelNiveles = new System.Windows.Forms.Label();
            this.listElegir = new System.Windows.Forms.ListBox();
            this.labelElegir = new System.Windows.Forms.Label();
            this.buttonClasificacionItemQuitar = new System.Windows.Forms.Button();
            this.buttonClasificacionItemElegir = new System.Windows.Forms.Button();
            this.listClasificacion = new System.Windows.Forms.ListBox();
            this.labelClasificacion = new System.Windows.Forms.Label();
            this.comboRuta = new System.Windows.Forms.ComboBox();
            this.buttonAbrirBancoPreguntas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstructura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLimpiarRuta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEstructura
            // 
            this.dataEstructura.AllowUserToAddRows = false;
            this.dataEstructura.AllowUserToDeleteRows = false;
            this.dataEstructura.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEstructura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataEstructura.ColumnHeadersHeight = 30;
            this.dataEstructura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataEstructura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columntextOrden,
            this.columntextPreguntas,
            this.columntextTotal,
            this.columntextElegir,
            this.columncomboPreguntas,
            this.columncomboRespuestas});
            this.dataEstructura.Location = new System.Drawing.Point(15, 238);
            this.dataEstructura.Name = "dataEstructura";
            this.dataEstructura.RowHeadersVisible = false;
            this.dataEstructura.Size = new System.Drawing.Size(727, 174);
            this.dataEstructura.TabIndex = 46;
            this.dataEstructura.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataEstructura_CellEndEdit);
            this.dataEstructura.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataEstructura_ColumnHeaderMouseClick);
            this.dataEstructura.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataEstructura_ColumnHeaderMouseDoubleClick);
            this.dataEstructura.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataEstructura_EditingControlShowing);
            this.dataEstructura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataEstructura_KeyPress);
            // 
            // columntextOrden
            // 
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.columntextOrden.DefaultCellStyle = dataGridViewCellStyle2;
            this.columntextOrden.Frozen = true;
            this.columntextOrden.HeaderText = "Orden";
            this.columntextOrden.Name = "columntextOrden";
            this.columntextOrden.ReadOnly = true;
            this.columntextOrden.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columntextOrden.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columntextOrden.Width = 50;
            // 
            // columntextPreguntas
            // 
            this.columntextPreguntas.Frozen = true;
            this.columntextPreguntas.HeaderText = "Preguntas";
            this.columntextPreguntas.Name = "columntextPreguntas";
            this.columntextPreguntas.ReadOnly = true;
            this.columntextPreguntas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columntextPreguntas.Width = 300;
            // 
            // columntextTotal
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columntextTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.columntextTotal.Frozen = true;
            this.columntextTotal.HeaderText = "Total";
            this.columntextTotal.Name = "columntextTotal";
            this.columntextTotal.ReadOnly = true;
            this.columntextTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columntextTotal.Width = 75;
            // 
            // columntextElegir
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columntextElegir.DefaultCellStyle = dataGridViewCellStyle4;
            this.columntextElegir.Frozen = true;
            this.columntextElegir.HeaderText = "Elegir";
            this.columntextElegir.Name = "columntextElegir";
            this.columntextElegir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columntextElegir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columntextElegir.Width = 78;
            // 
            // columncomboPreguntas
            // 
            this.columncomboPreguntas.Frozen = true;
            this.columncomboPreguntas.HeaderText = "Preguntas     ^";
            this.columncomboPreguntas.Items.AddRange(new object[] {
            "Azar",
            "Ascendente",
            "Descendente",
            "Orden original"});
            this.columncomboPreguntas.Name = "columncomboPreguntas";
            this.columncomboPreguntas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // columncomboRespuestas
            // 
            this.columncomboRespuestas.Frozen = true;
            this.columncomboRespuestas.HeaderText = "Respuestas   ^";
            this.columncomboRespuestas.Items.AddRange(new object[] {
            "Azar",
            "Ascendente",
            "Descendente",
            "Orden original"});
            this.columncomboRespuestas.Name = "columncomboRespuestas";
            this.columncomboRespuestas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columncomboRespuestas.Width = 102;
            // 
            // buttonClasificacionItemElegirTodo
            // 
            this.buttonClasificacionItemElegirTodo.BackgroundImage = global::TestCreator.Properties.Resources.icons8_doble_derecha_en_cuadrado_96;
            this.buttonClasificacionItemElegirTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClasificacionItemElegirTodo.FlatAppearance.BorderSize = 0;
            this.buttonClasificacionItemElegirTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonClasificacionItemElegirTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClasificacionItemElegirTodo.Location = new System.Drawing.Point(136, 55);
            this.buttonClasificacionItemElegirTodo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClasificacionItemElegirTodo.Name = "buttonClasificacionItemElegirTodo";
            this.buttonClasificacionItemElegirTodo.Size = new System.Drawing.Size(27, 26);
            this.buttonClasificacionItemElegirTodo.TabIndex = 45;
            this.buttonClasificacionItemElegirTodo.UseVisualStyleBackColor = true;
            this.buttonClasificacionItemElegirTodo.Click += new System.EventHandler(this.ButtonClasificacionItemElegirTodo_Click);
            // 
            // buttonClasificacionItemQuitarTodo
            // 
            this.buttonClasificacionItemQuitarTodo.BackgroundImage = global::TestCreator.Properties.Resources.icons8_doble_izquierda_en_cuadrado_96;
            this.buttonClasificacionItemQuitarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClasificacionItemQuitarTodo.FlatAppearance.BorderSize = 0;
            this.buttonClasificacionItemQuitarTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonClasificacionItemQuitarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClasificacionItemQuitarTodo.Location = new System.Drawing.Point(136, 145);
            this.buttonClasificacionItemQuitarTodo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClasificacionItemQuitarTodo.Name = "buttonClasificacionItemQuitarTodo";
            this.buttonClasificacionItemQuitarTodo.Size = new System.Drawing.Size(27, 26);
            this.buttonClasificacionItemQuitarTodo.TabIndex = 44;
            this.buttonClasificacionItemQuitarTodo.UseVisualStyleBackColor = true;
            this.buttonClasificacionItemQuitarTodo.Click += new System.EventHandler(this.ButtonClasificacionItemQuitarTodo_Click);
            // 
            // pictureLimpiarRuta
            // 
            this.pictureLimpiarRuta.Image = global::TestCreator.Properties.Resources.icons8_eliminar_columna_500_cian;
            this.pictureLimpiarRuta.InitialImage = null;
            this.pictureLimpiarRuta.Location = new System.Drawing.Point(727, 10);
            this.pictureLimpiarRuta.Name = "pictureLimpiarRuta";
            this.pictureLimpiarRuta.Size = new System.Drawing.Size(22, 22);
            this.pictureLimpiarRuta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLimpiarRuta.TabIndex = 43;
            this.pictureLimpiarRuta.TabStop = false;
            this.pictureLimpiarRuta.Click += new System.EventHandler(this.PictureLimpiarRuta_Click);
            this.pictureLimpiarRuta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureLimpiarRuta_MouseDown);
            this.pictureLimpiarRuta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureLimpiarRuta_MouseUp);
            // 
            // labelEstructurarTitulo
            // 
            this.labelEstructurarTitulo.AutoSize = true;
            this.labelEstructurarTitulo.Location = new System.Drawing.Point(12, 221);
            this.labelEstructurarTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEstructurarTitulo.Name = "labelEstructurarTitulo";
            this.labelEstructurarTitulo.Size = new System.Drawing.Size(214, 13);
            this.labelEstructurarTitulo.TabIndex = 42;
            this.labelEstructurarTitulo.Text = "Estructura de las preguntas para el examen.";
            // 
            // buttonEstructurarPreguntasElegidas
            // 
            this.buttonEstructurarPreguntasElegidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEstructurarPreguntasElegidas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonEstructurarPreguntasElegidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonEstructurarPreguntasElegidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEstructurarPreguntasElegidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEstructurarPreguntasElegidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEstructurarPreguntasElegidas.Image = global::TestCreator.Properties.Resources.icons8_estructura_de_árbol_30;
            this.buttonEstructurarPreguntasElegidas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEstructurarPreguntasElegidas.Location = new System.Drawing.Point(300, 188);
            this.buttonEstructurarPreguntasElegidas.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEstructurarPreguntasElegidas.Name = "buttonEstructurarPreguntasElegidas";
            this.buttonEstructurarPreguntasElegidas.Size = new System.Drawing.Size(200, 35);
            this.buttonEstructurarPreguntasElegidas.TabIndex = 41;
            this.buttonEstructurarPreguntasElegidas.Text = "Estructurar preguntas elegidas";
            this.buttonEstructurarPreguntasElegidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEstructurarPreguntasElegidas.UseVisualStyleBackColor = true;
            this.buttonEstructurarPreguntasElegidas.Click += new System.EventHandler(this.ButtonEstructurarPreguntasElegidas_Click);
            // 
            // buttonNivelesBajar
            // 
            this.buttonNivelesBajar.BackgroundImage = global::TestCreator.Properties.Resources.icons8_abajo_en_cuadrado_96;
            this.buttonNivelesBajar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNivelesBajar.FlatAppearance.BorderSize = 0;
            this.buttonNivelesBajar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonNivelesBajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNivelesBajar.Location = new System.Drawing.Point(505, 145);
            this.buttonNivelesBajar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNivelesBajar.Name = "buttonNivelesBajar";
            this.buttonNivelesBajar.Size = new System.Drawing.Size(27, 26);
            this.buttonNivelesBajar.TabIndex = 40;
            this.buttonNivelesBajar.UseVisualStyleBackColor = true;
            this.buttonNivelesBajar.Click += new System.EventHandler(this.ButtonNivelesBajar_Click);
            // 
            // buttonNivelesSubir
            // 
            this.buttonNivelesSubir.BackgroundImage = global::TestCreator.Properties.Resources.icons8_arriba_en_cuadrado_96;
            this.buttonNivelesSubir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNivelesSubir.FlatAppearance.BorderSize = 0;
            this.buttonNivelesSubir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonNivelesSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNivelesSubir.Location = new System.Drawing.Point(505, 115);
            this.buttonNivelesSubir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNivelesSubir.Name = "buttonNivelesSubir";
            this.buttonNivelesSubir.Size = new System.Drawing.Size(27, 26);
            this.buttonNivelesSubir.TabIndex = 39;
            this.buttonNivelesSubir.UseVisualStyleBackColor = true;
            this.buttonNivelesSubir.Click += new System.EventHandler(this.ButtonNivelesSubir_Click);
            // 
            // buttonNivelesIncluir
            // 
            this.buttonNivelesIncluir.BackgroundImage = global::TestCreator.Properties.Resources.icons8_izquierda_en_cuadrado_96;
            this.buttonNivelesIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNivelesIncluir.FlatAppearance.BorderSize = 0;
            this.buttonNivelesIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonNivelesIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNivelesIncluir.Location = new System.Drawing.Point(505, 85);
            this.buttonNivelesIncluir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNivelesIncluir.Name = "buttonNivelesIncluir";
            this.buttonNivelesIncluir.Size = new System.Drawing.Size(27, 26);
            this.buttonNivelesIncluir.TabIndex = 38;
            this.buttonNivelesIncluir.UseVisualStyleBackColor = true;
            this.buttonNivelesIncluir.Click += new System.EventHandler(this.ButtonNivelesIncluir_Click);
            // 
            // buttonNivelesExcluir
            // 
            this.buttonNivelesExcluir.BackgroundImage = global::TestCreator.Properties.Resources.icons8_derecha_en_cuadrado_96;
            this.buttonNivelesExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNivelesExcluir.FlatAppearance.BorderSize = 0;
            this.buttonNivelesExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonNivelesExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNivelesExcluir.Location = new System.Drawing.Point(505, 55);
            this.buttonNivelesExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNivelesExcluir.Name = "buttonNivelesExcluir";
            this.buttonNivelesExcluir.Size = new System.Drawing.Size(27, 26);
            this.buttonNivelesExcluir.TabIndex = 37;
            this.buttonNivelesExcluir.UseVisualStyleBackColor = true;
            this.buttonNivelesExcluir.Click += new System.EventHandler(this.ButtonNivelesExcluir_Click);
            // 
            // listExcluir
            // 
            this.listExcluir.FormattingEnabled = true;
            this.listExcluir.HorizontalScrollbar = true;
            this.listExcluir.Location = new System.Drawing.Point(536, 55);
            this.listExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.listExcluir.Name = "listExcluir";
            this.listExcluir.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listExcluir.Size = new System.Drawing.Size(200, 121);
            this.listExcluir.TabIndex = 36;
            this.listExcluir.DoubleClick += new System.EventHandler(this.ListExcluir_DoubleClick);
            // 
            // labelExcluir
            // 
            this.labelExcluir.AutoSize = true;
            this.labelExcluir.Location = new System.Drawing.Point(533, 39);
            this.labelExcluir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExcluir.Name = "labelExcluir";
            this.labelExcluir.Size = new System.Drawing.Size(38, 13);
            this.labelExcluir.TabIndex = 35;
            this.labelExcluir.Text = "Excluir";
            // 
            // listNiveles
            // 
            this.listNiveles.FormattingEnabled = true;
            this.listNiveles.HorizontalScrollbar = true;
            this.listNiveles.Location = new System.Drawing.Point(300, 55);
            this.listNiveles.Margin = new System.Windows.Forms.Padding(2);
            this.listNiveles.Name = "listNiveles";
            this.listNiveles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listNiveles.Size = new System.Drawing.Size(200, 121);
            this.listNiveles.TabIndex = 34;
            this.listNiveles.DoubleClick += new System.EventHandler(this.ListNiveles_DoubleClick);
            // 
            // labelNiveles
            // 
            this.labelNiveles.AutoSize = true;
            this.labelNiveles.Location = new System.Drawing.Point(298, 39);
            this.labelNiveles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNiveles.Name = "labelNiveles";
            this.labelNiveles.Size = new System.Drawing.Size(42, 13);
            this.labelNiveles.TabIndex = 33;
            this.labelNiveles.Text = "Niveles";
            // 
            // listElegir
            // 
            this.listElegir.FormattingEnabled = true;
            this.listElegir.HorizontalScrollbar = true;
            this.listElegir.Location = new System.Drawing.Point(167, 55);
            this.listElegir.Margin = new System.Windows.Forms.Padding(2);
            this.listElegir.Name = "listElegir";
            this.listElegir.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listElegir.Size = new System.Drawing.Size(120, 121);
            this.listElegir.TabIndex = 32;
            this.listElegir.DoubleClick += new System.EventHandler(this.ListElegir_DoubleClick);
            // 
            // labelElegir
            // 
            this.labelElegir.AutoSize = true;
            this.labelElegir.Location = new System.Drawing.Point(164, 39);
            this.labelElegir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelElegir.Name = "labelElegir";
            this.labelElegir.Size = new System.Drawing.Size(33, 13);
            this.labelElegir.TabIndex = 31;
            this.labelElegir.Text = "Elegir";
            // 
            // buttonClasificacionItemQuitar
            // 
            this.buttonClasificacionItemQuitar.BackgroundImage = global::TestCreator.Properties.Resources.icons8_izquierda_en_cuadrado_96;
            this.buttonClasificacionItemQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClasificacionItemQuitar.FlatAppearance.BorderSize = 0;
            this.buttonClasificacionItemQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonClasificacionItemQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClasificacionItemQuitar.Location = new System.Drawing.Point(136, 115);
            this.buttonClasificacionItemQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClasificacionItemQuitar.Name = "buttonClasificacionItemQuitar";
            this.buttonClasificacionItemQuitar.Size = new System.Drawing.Size(27, 26);
            this.buttonClasificacionItemQuitar.TabIndex = 30;
            this.buttonClasificacionItemQuitar.UseVisualStyleBackColor = true;
            this.buttonClasificacionItemQuitar.Click += new System.EventHandler(this.ButtonClasificacionItemQuitar_Click);
            // 
            // buttonClasificacionItemElegir
            // 
            this.buttonClasificacionItemElegir.BackgroundImage = global::TestCreator.Properties.Resources.icons8_derecha_en_cuadrado_96;
            this.buttonClasificacionItemElegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClasificacionItemElegir.FlatAppearance.BorderSize = 0;
            this.buttonClasificacionItemElegir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonClasificacionItemElegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClasificacionItemElegir.Location = new System.Drawing.Point(136, 85);
            this.buttonClasificacionItemElegir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClasificacionItemElegir.Name = "buttonClasificacionItemElegir";
            this.buttonClasificacionItemElegir.Size = new System.Drawing.Size(27, 26);
            this.buttonClasificacionItemElegir.TabIndex = 29;
            this.buttonClasificacionItemElegir.UseVisualStyleBackColor = true;
            this.buttonClasificacionItemElegir.Click += new System.EventHandler(this.ButtonClasificacionItemElegir_Click);
            // 
            // listClasificacion
            // 
            this.listClasificacion.FormattingEnabled = true;
            this.listClasificacion.HorizontalScrollbar = true;
            this.listClasificacion.Location = new System.Drawing.Point(12, 55);
            this.listClasificacion.Margin = new System.Windows.Forms.Padding(2);
            this.listClasificacion.Name = "listClasificacion";
            this.listClasificacion.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listClasificacion.Size = new System.Drawing.Size(120, 121);
            this.listClasificacion.TabIndex = 28;
            this.listClasificacion.DoubleClick += new System.EventHandler(this.ListClasificacion_DoubleClick);
            // 
            // labelClasificacion
            // 
            this.labelClasificacion.AutoSize = true;
            this.labelClasificacion.Location = new System.Drawing.Point(12, 39);
            this.labelClasificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClasificacion.Name = "labelClasificacion";
            this.labelClasificacion.Size = new System.Drawing.Size(66, 13);
            this.labelClasificacion.TabIndex = 27;
            this.labelClasificacion.Text = "Clasificación";
            // 
            // comboRuta
            // 
            this.comboRuta.FormattingEnabled = true;
            this.comboRuta.Location = new System.Drawing.Point(194, 11);
            this.comboRuta.Margin = new System.Windows.Forms.Padding(2);
            this.comboRuta.Name = "comboRuta";
            this.comboRuta.Size = new System.Drawing.Size(532, 21);
            this.comboRuta.TabIndex = 26;
            this.comboRuta.SelectedIndexChanged += new System.EventHandler(this.ComboRuta_SelectedIndexChanged);
            // 
            // buttonAbrirBancoPreguntas
            // 
            this.buttonAbrirBancoPreguntas.Location = new System.Drawing.Point(20, 10);
            this.buttonAbrirBancoPreguntas.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAbrirBancoPreguntas.Name = "buttonAbrirBancoPreguntas";
            this.buttonAbrirBancoPreguntas.Size = new System.Drawing.Size(170, 23);
            this.buttonAbrirBancoPreguntas.TabIndex = 25;
            this.buttonAbrirBancoPreguntas.Text = "Abrir banco de preguntas";
            this.buttonAbrirBancoPreguntas.UseVisualStyleBackColor = true;
            this.buttonAbrirBancoPreguntas.Click += new System.EventHandler(this.ButtonAbrirBancoPreguntas_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 430);
            this.Controls.Add(this.dataEstructura);
            this.Controls.Add(this.buttonClasificacionItemElegirTodo);
            this.Controls.Add(this.buttonClasificacionItemQuitarTodo);
            this.Controls.Add(this.pictureLimpiarRuta);
            this.Controls.Add(this.labelEstructurarTitulo);
            this.Controls.Add(this.buttonEstructurarPreguntasElegidas);
            this.Controls.Add(this.buttonNivelesBajar);
            this.Controls.Add(this.buttonNivelesSubir);
            this.Controls.Add(this.buttonNivelesIncluir);
            this.Controls.Add(this.buttonNivelesExcluir);
            this.Controls.Add(this.listExcluir);
            this.Controls.Add(this.labelExcluir);
            this.Controls.Add(this.listNiveles);
            this.Controls.Add(this.labelNiveles);
            this.Controls.Add(this.listElegir);
            this.Controls.Add(this.labelElegir);
            this.Controls.Add(this.buttonClasificacionItemQuitar);
            this.Controls.Add(this.buttonClasificacionItemElegir);
            this.Controls.Add(this.listClasificacion);
            this.Controls.Add(this.labelClasificacion);
            this.Controls.Add(this.comboRuta);
            this.Controls.Add(this.buttonAbrirBancoPreguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario";
            this.Text = "Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.dataEstructura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLimpiarRuta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEstructura;
        private System.Windows.Forms.Button buttonClasificacionItemElegirTodo;
        private System.Windows.Forms.Button buttonClasificacionItemQuitarTodo;
        private System.Windows.Forms.PictureBox pictureLimpiarRuta;
        private System.Windows.Forms.Label labelEstructurarTitulo;
        private System.Windows.Forms.Button buttonEstructurarPreguntasElegidas;
        private System.Windows.Forms.Button buttonNivelesBajar;
        private System.Windows.Forms.Button buttonNivelesSubir;
        private System.Windows.Forms.Button buttonNivelesIncluir;
        private System.Windows.Forms.Button buttonNivelesExcluir;
        private System.Windows.Forms.ListBox listExcluir;
        private System.Windows.Forms.Label labelExcluir;
        private System.Windows.Forms.ListBox listNiveles;
        private System.Windows.Forms.Label labelNiveles;
        private System.Windows.Forms.ListBox listElegir;
        private System.Windows.Forms.Label labelElegir;
        private System.Windows.Forms.Button buttonClasificacionItemQuitar;
        private System.Windows.Forms.Button buttonClasificacionItemElegir;
        private System.Windows.Forms.ListBox listClasificacion;
        private System.Windows.Forms.Label labelClasificacion;
        private System.Windows.Forms.ComboBox comboRuta;
        private System.Windows.Forms.Button buttonAbrirBancoPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columntextOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn columntextPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columntextTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn columntextElegir;
        private System.Windows.Forms.DataGridViewComboBoxColumn columncomboPreguntas;
        private System.Windows.Forms.DataGridViewComboBoxColumn columncomboRespuestas;
    }
}