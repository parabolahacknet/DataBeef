namespace DataBeef
{
    partial class frmGestionClientes
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblLimpiar = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlRegistrar = new System.Windows.Forms.Panel();
            this.lblEditarCliente = new System.Windows.Forms.Label();
            this.pnlEditar = new System.Windows.Forms.Panel();
            this.lblNuevoCliente = new System.Windows.Forms.Label();
            this.lblAcciones = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.pnlGestion = new System.Windows.Forms.Panel();
            this.lblPrecios = new System.Windows.Forms.Label();
            this.lblRecibos = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblArriba = new System.Windows.Forms.Label();
            this.lblBajar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlStock.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlRegistrar.SuspendLayout();
            this.pnlEditar.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(218, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Identificación:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Todos",
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(407, 48);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(160, 25);
            this.cmbEstado.TabIndex = 11;
            this.cmbEstado.TextChanged += new System.EventHandler(this.cmbEstado_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(403, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Estado";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeight = 32;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Location = new System.Drawing.Point(36, 169);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1529, 546);
            this.dgvClientes.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 21);
            this.label2.TabIndex = 52;
            this.label2.Text = "Crea, consulta, actualiza y edita la información de tus clientes.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(96, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 51;
            this.label1.Text = "Gestión de clientes";
            // 
            // pnlStock
            // 
            this.pnlStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.pnlStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStock.Controls.Add(this.pnlFiltros);
            this.pnlStock.Controls.Add(this.panel5);
            this.pnlStock.Controls.Add(this.pnlAcciones);
            this.pnlStock.Controls.Add(this.panel8);
            this.pnlStock.Controls.Add(this.pnlGestion);
            this.pnlStock.Controls.Add(this.lblArriba);
            this.pnlStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStock.Location = new System.Drawing.Point(0, 0);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Size = new System.Drawing.Size(1600, 108);
            this.pnlStock.TabIndex = 61;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.lblLimpiar);
            this.pnlFiltros.Controls.Add(this.txtIdentificacion);
            this.pnlFiltros.Controls.Add(this.txtCliente);
            this.pnlFiltros.Controls.Add(this.label16);
            this.pnlFiltros.Controls.Add(this.label9);
            this.pnlFiltros.Controls.Add(this.cmbEstado);
            this.pnlFiltros.Controls.Add(this.label4);
            this.pnlFiltros.Controls.Add(this.label3);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFiltros.Location = new System.Drawing.Point(556, 0);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(753, 106);
            this.pnlFiltros.TabIndex = 49;
            // 
            // lblLimpiar
            // 
            this.lblLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpiar.ForeColor = System.Drawing.Color.Black;
            this.lblLimpiar.Image = global::DataBeef.Properties.Resources.brush_cleaning;
            this.lblLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLimpiar.Location = new System.Drawing.Point(620, 20);
            this.lblLimpiar.Name = "lblLimpiar";
            this.lblLimpiar.Size = new System.Drawing.Size(63, 52);
            this.lblLimpiar.TabIndex = 66;
            this.lblLimpiar.Text = "Limpiar";
            this.lblLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblLimpiar.Click += new System.EventHandler(this.lblLimpiar_Click);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(21, 48);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(160, 25);
            this.txtIdentificacion.TabIndex = 43;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(222, 47);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(160, 25);
            this.txtCliente.TabIndex = 42;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(255, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "Filtros";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label22);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(555, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 106);
            this.panel5.TabIndex = 48;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.DarkGray;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(0, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1, 90);
            this.label22.TabIndex = 1;
            this.label22.Text = "Gestión";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.panel7);
            this.pnlAcciones.Controls.Add(this.lblAcciones);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAcciones.Location = new System.Drawing.Point(363, 0);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(192, 106);
            this.pnlAcciones.TabIndex = 47;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnlRegistrar);
            this.panel7.Controls.Add(this.pnlEditar);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(192, 72);
            this.panel7.TabIndex = 1;
            // 
            // pnlRegistrar
            // 
            this.pnlRegistrar.Controls.Add(this.lblEditarCliente);
            this.pnlRegistrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRegistrar.Location = new System.Drawing.Point(91, 0);
            this.pnlRegistrar.Name = "pnlRegistrar";
            this.pnlRegistrar.Size = new System.Drawing.Size(100, 72);
            this.pnlRegistrar.TabIndex = 1;
            // 
            // lblEditarCliente
            // 
            this.lblEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarCliente.ForeColor = System.Drawing.Color.Black;
            this.lblEditarCliente.Image = global::DataBeef.Properties.Resources.pencil_line;
            this.lblEditarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEditarCliente.Location = new System.Drawing.Point(18, 19);
            this.lblEditarCliente.Name = "lblEditarCliente";
            this.lblEditarCliente.Size = new System.Drawing.Size(63, 52);
            this.lblEditarCliente.TabIndex = 64;
            this.lblEditarCliente.Text = "Editar";
            this.lblEditarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblEditarCliente.Click += new System.EventHandler(this.lblEditarCliente_Click);
            // 
            // pnlEditar
            // 
            this.pnlEditar.Controls.Add(this.lblNuevoCliente);
            this.pnlEditar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEditar.Location = new System.Drawing.Point(0, 0);
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Size = new System.Drawing.Size(91, 72);
            this.pnlEditar.TabIndex = 0;
            // 
            // lblNuevoCliente
            // 
            this.lblNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNuevoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoCliente.ForeColor = System.Drawing.Color.Black;
            this.lblNuevoCliente.Image = global::DataBeef.Properties.Resources.mas;
            this.lblNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNuevoCliente.Location = new System.Drawing.Point(14, 19);
            this.lblNuevoCliente.Name = "lblNuevoCliente";
            this.lblNuevoCliente.Size = new System.Drawing.Size(63, 52);
            this.lblNuevoCliente.TabIndex = 64;
            this.lblNuevoCliente.Text = "Nuevo";
            this.lblNuevoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblNuevoCliente.Click += new System.EventHandler(this.lblNuevoCliente_Click);
            // 
            // lblAcciones
            // 
            this.lblAcciones.AutoSize = true;
            this.lblAcciones.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAcciones.ForeColor = System.Drawing.Color.DimGray;
            this.lblAcciones.Location = new System.Drawing.Point(54, 83);
            this.lblAcciones.Name = "lblAcciones";
            this.lblAcciones.Size = new System.Drawing.Size(71, 21);
            this.lblAcciones.TabIndex = 0;
            this.lblAcciones.Text = "Acciones";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label24);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(362, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 106);
            this.panel8.TabIndex = 46;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.DarkGray;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(0, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(1, 90);
            this.label24.TabIndex = 1;
            this.label24.Text = "Gestión";
            // 
            // pnlGestion
            // 
            this.pnlGestion.Controls.Add(this.lblPrecios);
            this.pnlGestion.Controls.Add(this.lblRecibos);
            this.pnlGestion.Controls.Add(this.lblVentas);
            this.pnlGestion.Controls.Add(this.lblClientes);
            this.pnlGestion.Controls.Add(this.label25);
            this.pnlGestion.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGestion.Location = new System.Drawing.Point(0, 0);
            this.pnlGestion.Name = "pnlGestion";
            this.pnlGestion.Size = new System.Drawing.Size(362, 106);
            this.pnlGestion.TabIndex = 45;
            // 
            // lblPrecios
            // 
            this.lblPrecios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblPrecios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrecios.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecios.ForeColor = System.Drawing.Color.Black;
            this.lblPrecios.Image = global::DataBeef.Properties.Resources.caja2;
            this.lblPrecios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPrecios.Location = new System.Drawing.Point(275, 23);
            this.lblPrecios.Name = "lblPrecios";
            this.lblPrecios.Size = new System.Drawing.Size(67, 52);
            this.lblPrecios.TabIndex = 67;
            this.lblPrecios.Text = "Precios";
            this.lblPrecios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPrecios.Click += new System.EventHandler(this.lblPrecios_Click);
            // 
            // lblRecibos
            // 
            this.lblRecibos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblRecibos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRecibos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibos.ForeColor = System.Drawing.Color.Black;
            this.lblRecibos.Image = global::DataBeef.Properties.Resources.factura;
            this.lblRecibos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRecibos.Location = new System.Drawing.Point(192, 20);
            this.lblRecibos.Name = "lblRecibos";
            this.lblRecibos.Size = new System.Drawing.Size(67, 52);
            this.lblRecibos.TabIndex = 64;
            this.lblRecibos.Text = "Recibos";
            this.lblRecibos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblRecibos.Click += new System.EventHandler(this.lblRecibos_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVentas.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.Black;
            this.lblVentas.Image = global::DataBeef.Properties.Resources.caja;
            this.lblVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVentas.Location = new System.Drawing.Point(13, 20);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(78, 52);
            this.lblVentas.TabIndex = 63;
            this.lblVentas.Text = "Ventas";
            this.lblVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblVentas.Click += new System.EventHandler(this.lblVentas_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.Black;
            this.lblClientes.Image = global::DataBeef.Properties.Resources.usuario;
            this.lblClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblClientes.Location = new System.Drawing.Point(109, 20);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(63, 52);
            this.lblClientes.TabIndex = 62;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label25.ForeColor = System.Drawing.Color.DimGray;
            this.label25.Location = new System.Drawing.Point(147, 83);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 21);
            this.label25.TabIndex = 0;
            this.label25.Text = "Gestión";
            // 
            // lblArriba
            // 
            this.lblArriba.AutoSize = true;
            this.lblArriba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblArriba.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblArriba.Location = new System.Drawing.Point(1570, 90);
            this.lblArriba.Name = "lblArriba";
            this.lblArriba.Size = new System.Drawing.Size(21, 21);
            this.lblArriba.TabIndex = 43;
            this.lblArriba.Text = "⌃";
            this.lblArriba.Click += new System.EventHandler(this.lblArriba_Click);
            // 
            // lblBajar
            // 
            this.lblBajar.AutoSize = true;
            this.lblBajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBajar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBajar.Location = new System.Drawing.Point(1574, 1);
            this.lblBajar.Name = "lblBajar";
            this.lblBajar.Size = new System.Drawing.Size(18, 21);
            this.lblBajar.TabIndex = 62;
            this.lblBajar.Text = "v";
            this.lblBajar.Visible = false;
            this.lblBajar.Click += new System.EventHandler(this.lblBajar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(32, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 63;
            this.label7.Text = "Lista de Clientes:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataBeef.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(34, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // frmGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1600, 769);
            this.Controls.Add(this.pnlStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblBajar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionClientes";
            this.Text = "frmGestionClientes";
            this.Load += new System.EventHandler(this.frmGestionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlStock.ResumeLayout(false);
            this.pnlStock.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            this.pnlAcciones.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.pnlRegistrar.ResumeLayout(false);
            this.pnlEditar.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnlGestion.ResumeLayout(false);
            this.pnlGestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnlRegistrar;
        private System.Windows.Forms.Panel pnlEditar;
        private System.Windows.Forms.Label lblNuevoCliente;
        private System.Windows.Forms.Label lblAcciones;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel pnlGestion;
        private System.Windows.Forms.Label lblRecibos;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblArriba;
        private System.Windows.Forms.Label lblBajar;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblEditarCliente;
        private System.Windows.Forms.Label lblLimpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrecios;
    }
}