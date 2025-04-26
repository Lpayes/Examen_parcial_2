using System.ComponentModel;

namespace MinecraftManager.UI
{
    partial class MainForm
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
            labelIdJugador = new Label();
            textBoxId = new TextBox();
            textBoxNombre = new TextBox();
            label2NombreJugador = new Label();
            labelNivelJugador = new Label();
            numericUpDownNivel = new NumericUpDown();
            labelCreadoJugador = new Label();
            textBoxFechaCreacion = new TextBox();
            buttonRegistrar = new Button();
            buttonActualizar = new Button();
            buttonBuscar = new Button();
            buttonEliminar = new Button();
            buttonListar = new Button();
            buttonGuardar = new Button();
            dataGridViewJugadores = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            dataGridViewBloques = new DataGridView();
            buttonGuardarBloque = new Button();
            pictureBoxBloque = new PictureBox();
            buttonListarBloques = new Button();
            buttonEliminarBloque = new Button();
            buttonActualizarBloque = new Button();
            buttonBuscarRarezaBloque = new Button();
            buttonBuscarTipoBloque = new Button();
            buttonBuscarIdBloque = new Button();
            buttonRegistrarBloque = new Button();
            comboBoxRarezaBloque = new ComboBox();
            comboBoxTipoBloque = new ComboBox();
            textBoxNombreBloque = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBoxIdBloque = new TextBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            buttonGuardarInventario = new Button();
            buttonExportarInventario = new Button();
            buttonEliminarInventario = new Button();
            buttonActualizarInventario = new Button();
            buttonVerInventarioJugador = new Button();
            buttonListarInventario = new Button();
            buttonAgregarInventario = new Button();
            dataGridViewInventario = new DataGridView();
            label12 = new Label();
            numericUpDownCantidadInventario = new NumericUpDown();
            label11 = new Label();
            comboBoxBloqueInventario = new ComboBox();
            comboBoxJugadorInventario = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            textBoxIdInventario = new TextBox();
            ((ISupportInitialize)numericUpDownNivel).BeginInit();
            ((ISupportInitialize)dataGridViewJugadores).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((ISupportInitialize)dataGridViewBloques).BeginInit();
            ((ISupportInitialize)pictureBoxBloque).BeginInit();
            groupBox3.SuspendLayout();
            ((ISupportInitialize)dataGridViewInventario).BeginInit();
            ((ISupportInitialize)numericUpDownCantidadInventario).BeginInit();
            SuspendLayout();
            // 
            // labelIdJugador
            // 
            labelIdJugador.AutoSize = true;
            labelIdJugador.BackColor = SystemColors.ActiveCaption;
            labelIdJugador.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            labelIdJugador.Location = new Point(28, 67);
            labelIdJugador.Name = "labelIdJugador";
            labelIdJugador.Size = new Size(25, 19);
            labelIdJugador.TabIndex = 2;
            labelIdJugador.Text = "ID";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(58, 65);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(59, 27);
            textBoxId.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(200, 65);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(157, 27);
            textBoxNombre.TabIndex = 6;
            // 
            // label2NombreJugador
            // 
            label2NombreJugador.AutoSize = true;
            label2NombreJugador.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label2NombreJugador.Location = new Point(123, 66);
            label2NombreJugador.Name = "label2NombreJugador";
            label2NombreJugador.Size = new Size(71, 19);
            label2NombreJugador.TabIndex = 7;
            label2NombreJugador.Text = "Nombre";
            // 
            // labelNivelJugador
            // 
            labelNivelJugador.AutoSize = true;
            labelNivelJugador.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            labelNivelJugador.Location = new Point(363, 65);
            labelNivelJugador.Name = "labelNivelJugador";
            labelNivelJugador.Size = new Size(47, 19);
            labelNivelJugador.TabIndex = 8;
            labelNivelJugador.Text = "Nivel";
            // 
            // numericUpDownNivel
            // 
            numericUpDownNivel.Location = new Point(415, 63);
            numericUpDownNivel.Name = "numericUpDownNivel";
            numericUpDownNivel.Size = new Size(50, 27);
            numericUpDownNivel.TabIndex = 9;
            // 
            // labelCreadoJugador
            // 
            labelCreadoJugador.AutoSize = true;
            labelCreadoJugador.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            labelCreadoJugador.Location = new Point(471, 63);
            labelCreadoJugador.Name = "labelCreadoJugador";
            labelCreadoJugador.Size = new Size(66, 19);
            labelCreadoJugador.TabIndex = 10;
            labelCreadoJugador.Text = "Creado";
            // 
            // textBoxFechaCreacion
            // 
            textBoxFechaCreacion.Location = new Point(547, 62);
            textBoxFechaCreacion.Name = "textBoxFechaCreacion";
            textBoxFechaCreacion.Size = new Size(144, 27);
            textBoxFechaCreacion.TabIndex = 11;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = SystemColors.HotTrack;
            buttonRegistrar.Font = new Font("Arial", 10.2F);
            buttonRegistrar.Location = new Point(15, 135);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(132, 57);
            buttonRegistrar.TabIndex = 12;
            buttonRegistrar.Text = "RegistrarJugador";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = SystemColors.HotTrack;
            buttonActualizar.Font = new Font("Arial", 10.2F);
            buttonActualizar.Location = new Point(291, 135);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(132, 57);
            buttonActualizar.TabIndex = 13;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = SystemColors.HotTrack;
            buttonBuscar.Font = new Font("Arial", 10.2F);
            buttonBuscar.Location = new Point(153, 135);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(132, 57);
            buttonBuscar.TabIndex = 14;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = SystemColors.HotTrack;
            buttonEliminar.Font = new Font("Arial", 10.2F);
            buttonEliminar.Location = new Point(429, 135);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(132, 57);
            buttonEliminar.TabIndex = 15;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonListar
            // 
            buttonListar.BackColor = SystemColors.HotTrack;
            buttonListar.Font = new Font("Arial", 10.2F);
            buttonListar.Location = new Point(567, 135);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(124, 57);
            buttonListar.TabIndex = 16;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = false;
            buttonListar.Click += buttonListar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = SystemColors.HotTrack;
            buttonGuardar.Font = new Font("Arial", 10.2F);
            buttonGuardar.Location = new Point(304, 376);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(132, 57);
            buttonGuardar.TabIndex = 17;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // dataGridViewJugadores
            // 
            dataGridViewJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJugadores.Location = new Point(93, 208);
            dataGridViewJugadores.Name = "dataGridViewJugadores";
            dataGridViewJugadores.RowHeadersWidth = 51;
            dataGridViewJugadores.Size = new Size(575, 150);
            dataGridViewJugadores.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.BackgroundImage = Properties.Resources.Menu1;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelIdJugador);
            groupBox1.Controls.Add(dataGridViewJugadores);
            groupBox1.Controls.Add(buttonGuardar);
            groupBox1.Controls.Add(textBoxId);
            groupBox1.Controls.Add(label2NombreJugador);
            groupBox1.Controls.Add(buttonListar);
            groupBox1.Controls.Add(textBoxNombre);
            groupBox1.Controls.Add(buttonEliminar);
            groupBox1.Controls.Add(labelNivelJugador);
            groupBox1.Controls.Add(buttonActualizar);
            groupBox1.Controls.Add(buttonBuscar);
            groupBox1.Controls.Add(numericUpDownNivel);
            groupBox1.Controls.Add(textBoxFechaCreacion);
            groupBox1.Controls.Add(buttonRegistrar);
            groupBox1.Controls.Add(labelCreadoJugador);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(28, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(749, 446);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jugador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(257, 23);
            label1.Name = "label1";
            label1.Size = new Size(200, 35);
            label1.TabIndex = 19;
            label1.Text = "Menu Jugador";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.BackgroundImage = Properties.Resources.Menu2;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dataGridViewBloques);
            groupBox2.Controls.Add(buttonGuardarBloque);
            groupBox2.Controls.Add(pictureBoxBloque);
            groupBox2.Controls.Add(buttonListarBloques);
            groupBox2.Controls.Add(buttonEliminarBloque);
            groupBox2.Controls.Add(buttonActualizarBloque);
            groupBox2.Controls.Add(buttonBuscarRarezaBloque);
            groupBox2.Controls.Add(buttonBuscarTipoBloque);
            groupBox2.Controls.Add(buttonBuscarIdBloque);
            groupBox2.Controls.Add(buttonRegistrarBloque);
            groupBox2.Controls.Add(comboBoxRarezaBloque);
            groupBox2.Controls.Add(comboBoxTipoBloque);
            groupBox2.Controls.Add(textBoxNombreBloque);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxIdBloque);
            groupBox2.Location = new Point(849, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(782, 454);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bloque";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(278, 12);
            label2.Name = "label2";
            label2.Size = new Size(186, 35);
            label2.TabIndex = 20;
            label2.Text = "Menu Bloque";
            // 
            // dataGridViewBloques
            // 
            dataGridViewBloques.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBloques.Location = new Point(215, 229);
            dataGridViewBloques.Name = "dataGridViewBloques";
            dataGridViewBloques.RowHeadersWidth = 51;
            dataGridViewBloques.Size = new Size(503, 118);
            dataGridViewBloques.TabIndex = 19;
            // 
            // buttonGuardarBloque
            // 
            buttonGuardarBloque.BackColor = Color.OrangeRed;
            buttonGuardarBloque.Font = new Font("Arial", 10.2F);
            buttonGuardarBloque.Location = new Point(360, 353);
            buttonGuardarBloque.Name = "buttonGuardarBloque";
            buttonGuardarBloque.Size = new Size(132, 53);
            buttonGuardarBloque.TabIndex = 18;
            buttonGuardarBloque.Text = "Guardar";
            buttonGuardarBloque.UseVisualStyleBackColor = false;
            buttonGuardarBloque.Click += buttonGuardarBloque_Click;
            // 
            // pictureBoxBloque
            // 
            pictureBoxBloque.Location = new Point(67, 229);
            pictureBoxBloque.Name = "pictureBoxBloque";
            pictureBoxBloque.Size = new Size(142, 118);
            pictureBoxBloque.TabIndex = 17;
            pictureBoxBloque.TabStop = false;
            // 
            // buttonListarBloques
            // 
            buttonListarBloques.BackColor = Color.OrangeRed;
            buttonListarBloques.Font = new Font("Arial", 10.2F);
            buttonListarBloques.Location = new Point(402, 181);
            buttonListarBloques.Name = "buttonListarBloques";
            buttonListarBloques.Size = new Size(132, 42);
            buttonListarBloques.TabIndex = 16;
            buttonListarBloques.Text = "Listar Bloques";
            buttonListarBloques.UseVisualStyleBackColor = false;
            buttonListarBloques.Click += buttonListarBloques_Click;
            // 
            // buttonEliminarBloque
            // 
            buttonEliminarBloque.BackColor = Color.OrangeRed;
            buttonEliminarBloque.Font = new Font("Arial", 10.2F);
            buttonEliminarBloque.Location = new Point(249, 181);
            buttonEliminarBloque.Name = "buttonEliminarBloque";
            buttonEliminarBloque.Size = new Size(132, 42);
            buttonEliminarBloque.TabIndex = 15;
            buttonEliminarBloque.Text = "Eliminar Bloque";
            buttonEliminarBloque.UseVisualStyleBackColor = false;
            buttonEliminarBloque.Click += buttonEliminarBloque_Click;
            // 
            // buttonActualizarBloque
            // 
            buttonActualizarBloque.BackColor = Color.OrangeRed;
            buttonActualizarBloque.Font = new Font("Arial", 10.2F);
            buttonActualizarBloque.Location = new Point(634, 131);
            buttonActualizarBloque.Name = "buttonActualizarBloque";
            buttonActualizarBloque.Size = new Size(132, 42);
            buttonActualizarBloque.TabIndex = 14;
            buttonActualizarBloque.Text = "Actualizar Bloque";
            buttonActualizarBloque.UseVisualStyleBackColor = false;
            buttonActualizarBloque.Click += buttonActualizarBloque_Click;
            // 
            // buttonBuscarRarezaBloque
            // 
            buttonBuscarRarezaBloque.BackColor = Color.OrangeRed;
            buttonBuscarRarezaBloque.Font = new Font("Arial", 10.2F);
            buttonBuscarRarezaBloque.Location = new Point(470, 129);
            buttonBuscarRarezaBloque.Name = "buttonBuscarRarezaBloque";
            buttonBuscarRarezaBloque.Size = new Size(132, 42);
            buttonBuscarRarezaBloque.TabIndex = 13;
            buttonBuscarRarezaBloque.Text = "Buscar Rareza Bloque";
            buttonBuscarRarezaBloque.UseVisualStyleBackColor = false;
            buttonBuscarRarezaBloque.Click += buttonBuscarRarezaBloque_Click;
            // 
            // buttonBuscarTipoBloque
            // 
            buttonBuscarTipoBloque.BackColor = Color.OrangeRed;
            buttonBuscarTipoBloque.Font = new Font("Arial", 10.2F);
            buttonBuscarTipoBloque.Location = new Point(332, 129);
            buttonBuscarTipoBloque.Name = "buttonBuscarTipoBloque";
            buttonBuscarTipoBloque.Size = new Size(132, 46);
            buttonBuscarTipoBloque.TabIndex = 12;
            buttonBuscarTipoBloque.Text = "Buscar Tipo de Bloque";
            buttonBuscarTipoBloque.UseVisualStyleBackColor = false;
            buttonBuscarTipoBloque.Click += buttonBuscarTipoBloque_Click;
            // 
            // buttonBuscarIdBloque
            // 
            buttonBuscarIdBloque.BackColor = Color.OrangeRed;
            buttonBuscarIdBloque.Font = new Font("Arial", 10.2F);
            buttonBuscarIdBloque.Location = new Point(179, 129);
            buttonBuscarIdBloque.Name = "buttonBuscarIdBloque";
            buttonBuscarIdBloque.Size = new Size(132, 46);
            buttonBuscarIdBloque.TabIndex = 11;
            buttonBuscarIdBloque.Text = "Buscar Bloque";
            buttonBuscarIdBloque.UseVisualStyleBackColor = false;
            buttonBuscarIdBloque.Click += buttonBuscarIdBloque_Click;
            // 
            // buttonRegistrarBloque
            // 
            buttonRegistrarBloque.BackColor = Color.OrangeRed;
            buttonRegistrarBloque.Font = new Font("Arial", 10.2F);
            buttonRegistrarBloque.Location = new Point(41, 127);
            buttonRegistrarBloque.Name = "buttonRegistrarBloque";
            buttonRegistrarBloque.Size = new Size(132, 46);
            buttonRegistrarBloque.TabIndex = 10;
            buttonRegistrarBloque.Text = "Registrar Bloque";
            buttonRegistrarBloque.UseVisualStyleBackColor = false;
            buttonRegistrarBloque.Click += buttonRegistrarBloque_Click;
            // 
            // comboBoxRarezaBloque
            // 
            comboBoxRarezaBloque.FormattingEnabled = true;
            comboBoxRarezaBloque.Location = new Point(649, 51);
            comboBoxRarezaBloque.Name = "comboBoxRarezaBloque";
            comboBoxRarezaBloque.Size = new Size(117, 28);
            comboBoxRarezaBloque.TabIndex = 9;
            // 
            // comboBoxTipoBloque
            // 
            comboBoxTipoBloque.FormattingEnabled = true;
            comboBoxTipoBloque.Location = new Point(431, 53);
            comboBoxTipoBloque.Name = "comboBoxTipoBloque";
            comboBoxTipoBloque.Size = new Size(128, 28);
            comboBoxTipoBloque.TabIndex = 8;
            // 
            // textBoxNombreBloque
            // 
            textBoxNombreBloque.Location = new Point(225, 55);
            textBoxNombreBloque.Name = "textBoxNombreBloque";
            textBoxNombreBloque.Size = new Size(129, 27);
            textBoxNombreBloque.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.MenuHighlight;
            label8.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label8.Location = new Point(589, 53);
            label8.Name = "label8";
            label8.Size = new Size(64, 19);
            label8.TabIndex = 6;
            label8.Text = "Rareza";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.MenuHighlight;
            label7.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label7.Location = new Point(376, 54);
            label7.Name = "label7";
            label7.Size = new Size(43, 19);
            label7.TabIndex = 5;
            label7.Text = "Tipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.MenuHighlight;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label6.Location = new Point(145, 56);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 4;
            label6.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.MenuHighlight;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label5.Location = new Point(23, 57);
            label5.Name = "label5";
            label5.Size = new Size(25, 19);
            label5.TabIndex = 3;
            label5.Text = "ID";
            // 
            // textBoxIdBloque
            // 
            textBoxIdBloque.Location = new Point(67, 56);
            textBoxIdBloque.Name = "textBoxIdBloque";
            textBoxIdBloque.Size = new Size(55, 27);
            textBoxIdBloque.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Info;
            groupBox3.BackgroundImage = Properties.Resources.menu4;
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(buttonGuardarInventario);
            groupBox3.Controls.Add(buttonExportarInventario);
            groupBox3.Controls.Add(buttonEliminarInventario);
            groupBox3.Controls.Add(buttonActualizarInventario);
            groupBox3.Controls.Add(buttonVerInventarioJugador);
            groupBox3.Controls.Add(buttonListarInventario);
            groupBox3.Controls.Add(buttonAgregarInventario);
            groupBox3.Controls.Add(dataGridViewInventario);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(numericUpDownCantidadInventario);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(comboBoxBloqueInventario);
            groupBox3.Controls.Add(comboBoxJugadorInventario);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBoxIdInventario);
            groupBox3.Location = new Point(427, 509);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(733, 398);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Inventario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(254, 23);
            label3.Name = "label3";
            label3.Size = new Size(226, 35);
            label3.TabIndex = 20;
            label3.Text = "Menu Inventario";
            // 
            // buttonGuardarInventario
            // 
            buttonGuardarInventario.BackColor = Color.Yellow;
            buttonGuardarInventario.Font = new Font("Arial", 10.2F);
            buttonGuardarInventario.Location = new Point(401, 327);
            buttonGuardarInventario.Name = "buttonGuardarInventario";
            buttonGuardarInventario.Size = new Size(132, 56);
            buttonGuardarInventario.TabIndex = 15;
            buttonGuardarInventario.Text = "Guardar";
            buttonGuardarInventario.UseVisualStyleBackColor = false;
            buttonGuardarInventario.Click += buttonGuardarInventario_Click;
            // 
            // buttonExportarInventario
            // 
            buttonExportarInventario.BackColor = Color.Yellow;
            buttonExportarInventario.Font = new Font("Arial", 10.2F);
            buttonExportarInventario.Location = new Point(184, 327);
            buttonExportarInventario.Name = "buttonExportarInventario";
            buttonExportarInventario.Size = new Size(211, 56);
            buttonExportarInventario.TabIndex = 14;
            buttonExportarInventario.Text = "Exportar inventario a CSV/Excel";
            buttonExportarInventario.UseVisualStyleBackColor = false;
            buttonExportarInventario.Click += buttonExportarInventario_Click;
            // 
            // buttonEliminarInventario
            // 
            buttonEliminarInventario.BackColor = Color.Yellow;
            buttonEliminarInventario.Font = new Font("Arial", 10.2F);
            buttonEliminarInventario.Location = new Point(572, 128);
            buttonEliminarInventario.Name = "buttonEliminarInventario";
            buttonEliminarInventario.Size = new Size(132, 56);
            buttonEliminarInventario.TabIndex = 13;
            buttonEliminarInventario.Text = "Eliminar Elemento del Inventario";
            buttonEliminarInventario.UseVisualStyleBackColor = false;
            buttonEliminarInventario.Click += buttonEliminarInventario_Click;
            // 
            // buttonActualizarInventario
            // 
            buttonActualizarInventario.BackColor = Color.Yellow;
            buttonActualizarInventario.Font = new Font("Arial", 10.2F);
            buttonActualizarInventario.Location = new Point(434, 128);
            buttonActualizarInventario.Name = "buttonActualizarInventario";
            buttonActualizarInventario.Size = new Size(132, 56);
            buttonActualizarInventario.TabIndex = 12;
            buttonActualizarInventario.Text = "Actualizar Cantidad en Inventario";
            buttonActualizarInventario.UseVisualStyleBackColor = false;
            buttonActualizarInventario.Click += buttonActualizarInventario_Click;
            // 
            // buttonVerInventarioJugador
            // 
            buttonVerInventarioJugador.BackColor = Color.Yellow;
            buttonVerInventarioJugador.Font = new Font("Arial", 10.2F);
            buttonVerInventarioJugador.Location = new Point(296, 128);
            buttonVerInventarioJugador.Name = "buttonVerInventarioJugador";
            buttonVerInventarioJugador.Size = new Size(132, 56);
            buttonVerInventarioJugador.TabIndex = 11;
            buttonVerInventarioJugador.Text = "Ver Inventario de un Jugador";
            buttonVerInventarioJugador.UseVisualStyleBackColor = false;
            buttonVerInventarioJugador.Click += buttonVerInventarioJugador_Click;
            // 
            // buttonListarInventario
            // 
            buttonListarInventario.BackColor = Color.Yellow;
            buttonListarInventario.Font = new Font("Arial", 10.2F);
            buttonListarInventario.Location = new Point(158, 128);
            buttonListarInventario.Name = "buttonListarInventario";
            buttonListarInventario.Size = new Size(132, 56);
            buttonListarInventario.TabIndex = 10;
            buttonListarInventario.Text = "Listar Todo el Inventario";
            buttonListarInventario.UseVisualStyleBackColor = false;
            buttonListarInventario.Click += buttonListarInventario_Click;
            // 
            // buttonAgregarInventario
            // 
            buttonAgregarInventario.BackColor = Color.Yellow;
            buttonAgregarInventario.Font = new Font("Arial", 10.2F);
            buttonAgregarInventario.Location = new Point(20, 128);
            buttonAgregarInventario.Name = "buttonAgregarInventario";
            buttonAgregarInventario.Size = new Size(132, 56);
            buttonAgregarInventario.TabIndex = 9;
            buttonAgregarInventario.Text = "Agregar Bloques al Inventario";
            buttonAgregarInventario.UseVisualStyleBackColor = false;
            buttonAgregarInventario.Click += buttonAgregarInventario_Click;
            // 
            // dataGridViewInventario
            // 
            dataGridViewInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventario.Location = new Point(102, 190);
            dataGridViewInventario.Name = "dataGridViewInventario";
            dataGridViewInventario.RowHeadersWidth = 51;
            dataGridViewInventario.Size = new Size(529, 131);
            dataGridViewInventario.TabIndex = 8;
            dataGridViewInventario.CellContentClick += dataGridViewInventario_CellContentClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.Info;
            label12.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label12.Location = new Point(516, 66);
            label12.Name = "label12";
            label12.Size = new Size(79, 19);
            label12.TabIndex = 7;
            label12.Text = "Cantidad";
            // 
            // numericUpDownCantidadInventario
            // 
            numericUpDownCantidadInventario.Location = new Point(601, 64);
            numericUpDownCantidadInventario.Name = "numericUpDownCantidadInventario";
            numericUpDownCantidadInventario.Size = new Size(51, 27);
            numericUpDownCantidadInventario.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Info;
            label11.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label11.Location = new Point(375, 67);
            label11.Name = "label11";
            label11.Size = new Size(64, 19);
            label11.TabIndex = 5;
            label11.Text = "Bloque";
            // 
            // comboBoxBloqueInventario
            // 
            comboBoxBloqueInventario.FormattingEnabled = true;
            comboBoxBloqueInventario.Location = new Point(445, 66);
            comboBoxBloqueInventario.Name = "comboBoxBloqueInventario";
            comboBoxBloqueInventario.Size = new Size(67, 28);
            comboBoxBloqueInventario.TabIndex = 4;
            // 
            // comboBoxJugadorInventario
            // 
            comboBoxJugadorInventario.FormattingEnabled = true;
            comboBoxJugadorInventario.Location = new Point(302, 67);
            comboBoxJugadorInventario.Name = "comboBoxJugadorInventario";
            comboBoxJugadorInventario.Size = new Size(67, 28);
            comboBoxJugadorInventario.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Info;
            label10.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label10.Location = new Point(222, 70);
            label10.Name = "label10";
            label10.Size = new Size(74, 19);
            label10.TabIndex = 2;
            label10.Text = "Jugador";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Info;
            label9.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label9.Location = new Point(33, 67);
            label9.Name = "label9";
            label9.Size = new Size(25, 19);
            label9.TabIndex = 1;
            label9.Text = "ID";
            // 
            // textBoxIdInventario
            // 
            textBoxIdInventario.Location = new Point(72, 67);
            textBoxIdInventario.Name = "textBoxIdInventario";
            textBoxIdInventario.Size = new Size(144, 27);
            textBoxIdInventario.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(1665, 933);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "JugadorForm1";
            Load += JugadorForm_Load;
            ((ISupportInitialize)numericUpDownNivel).EndInit();
            ((ISupportInitialize)dataGridViewJugadores).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((ISupportInitialize)dataGridViewBloques).EndInit();
            ((ISupportInitialize)pictureBoxBloque).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((ISupportInitialize)dataGridViewInventario).EndInit();
            ((ISupportInitialize)numericUpDownCantidadInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelIdJugador;
        private TextBox textBoxId;
        private TextBox textBoxNombre;
        private Label label2NombreJugador;
        private Label labelNivelJugador;
        private NumericUpDown numericUpDownNivel;
        private Label labelCreadoJugador;
        private TextBox textBoxFechaCreacion;
        private Button buttonRegistrar;
        private Button buttonActualizar;
        private Button buttonBuscar;
        private Button buttonEliminar;
        private Button buttonListar;
        private Button buttonGuardar;
        private DataGridView dataGridViewJugadores;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBoxIdBloque;
        private ComboBox comboBoxRarezaBloque;
        private ComboBox comboBoxTipoBloque;
        private TextBox textBoxNombreBloque;
        private Button buttonRegistrarBloque;
        private Button buttonBuscarIdBloque;
        private Button buttonBuscarTipoBloque;
        private Button buttonBuscarRarezaBloque;
        private Button buttonActualizarBloque;
        private Button buttonEliminarBloque;
        private Button buttonListarBloques;
        private PictureBox pictureBoxBloque;
        private Button buttonGuardarBloque;
        private DataGridView dataGridViewBloques;
        private GroupBox groupBox3;
        private Button buttonExportarInventario;
        private Button buttonEliminarInventario;
        private Button buttonActualizarInventario;
        private Button buttonVerInventarioJugador;
        private Button buttonListarInventario;
        private Button buttonAgregarInventario;
        private DataGridView dataGridViewInventario;
        private Label label12;
        private NumericUpDown numericUpDownCantidadInventario;
        private Label label11;
        private ComboBox comboBoxBloqueInventario;
        private ComboBox comboBoxJugadorInventario;
        private Label label10;
        private Label label9;
        private TextBox textBoxIdInventario;
        private Button buttonGuardarInventario;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}