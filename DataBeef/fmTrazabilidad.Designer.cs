namespace DataBeef
{
    partial class fmTrazabilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTrazabilidad));
            this.tablaGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.panelResumen = new HartUI.Controls.cuiPanel();
            this.tablaInternaResumen = new System.Windows.Forms.TableLayoutPanel();
            this.labelCodigo = new HartUI.Controls.cuiLabel();
            this.labelProducto = new HartUI.Controls.cuiLabel();
            this.labelProveedor = new HartUI.Controls.cuiLabel();
            this.labelFechas = new HartUI.Controls.cuiLabel();
            this.labelEstado = new HartUI.Controls.cuiLabel();
            this.cuiLabel6 = new HartUI.Controls.cuiLabel();
            this.cuiLabel7 = new HartUI.Controls.cuiLabel();
            this.cuiLabel8 = new HartUI.Controls.cuiLabel();
            this.cuiLabel9 = new HartUI.Controls.cuiLabel();
            this.cuiLabel10 = new HartUI.Controls.cuiLabel();
            this.tablaInternaBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.checkSoloVigentes = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnBuscar = new HartUI.Controls.cuiButton();
            this.labelCodigoLote = new HartUI.Controls.cuiLabel();
            this.textoBoxCodigoLote = new HartUI.Controls.cuiTextBox();
            this.panelBusqueda = new HartUI.Controls.cuiPanel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHistorial = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cuiButton1 = new HartUI.Controls.cuiButton();
            this.cuiButton3 = new HartUI.Controls.cuiButton();
            this.cuiButton2 = new HartUI.Controls.cuiButton();
            this.tablaGeneral.SuspendLayout();
            this.panelResumen.SuspendLayout();
            this.tablaInternaResumen.SuspendLayout();
            this.tablaInternaBusqueda.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabHistorial.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaGeneral
            // 
            this.tablaGeneral.ColumnCount = 1;
            this.tablaGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablaGeneral.Controls.Add(this.panelBusqueda, 0, 0);
            this.tablaGeneral.Controls.Add(this.panelResumen, 0, 1);
            this.tablaGeneral.Controls.Add(this.tabHistorial, 0, 2);
            this.tablaGeneral.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tablaGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaGeneral.Location = new System.Drawing.Point(0, 0);
            this.tablaGeneral.Name = "tablaGeneral";
            this.tablaGeneral.RowCount = 4;
            this.tablaGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tablaGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tablaGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tablaGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tablaGeneral.Size = new System.Drawing.Size(944, 501);
            this.tablaGeneral.TabIndex = 0;
            // 
            // panelResumen
            // 
            this.panelResumen.Controls.Add(this.tablaInternaResumen);
            this.panelResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResumen.Location = new System.Drawing.Point(3, 58);
            this.panelResumen.Name = "panelResumen";
            this.panelResumen.OutlineThickness = 1F;
            this.panelResumen.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelResumen.PanelColor = System.Drawing.Color.White;
            this.panelResumen.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelResumen.Rounding = new System.Windows.Forms.Padding(8);
            this.panelResumen.Size = new System.Drawing.Size(938, 114);
            this.panelResumen.TabIndex = 1;
            // 
            // tablaInternaResumen
            // 
            this.tablaInternaResumen.ColumnCount = 2;
            this.tablaInternaResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.22467F));
            this.tablaInternaResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.77533F));
            this.tablaInternaResumen.Controls.Add(this.labelCodigo, 0, 0);
            this.tablaInternaResumen.Controls.Add(this.labelProducto, 0, 1);
            this.tablaInternaResumen.Controls.Add(this.labelProveedor, 0, 2);
            this.tablaInternaResumen.Controls.Add(this.labelFechas, 0, 3);
            this.tablaInternaResumen.Controls.Add(this.labelEstado, 0, 4);
            this.tablaInternaResumen.Controls.Add(this.cuiLabel6, 1, 0);
            this.tablaInternaResumen.Controls.Add(this.cuiLabel7, 1, 1);
            this.tablaInternaResumen.Controls.Add(this.cuiLabel8, 1, 2);
            this.tablaInternaResumen.Controls.Add(this.cuiLabel9, 1, 3);
            this.tablaInternaResumen.Controls.Add(this.cuiLabel10, 1, 4);
            this.tablaInternaResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaInternaResumen.Location = new System.Drawing.Point(15, 10);
            this.tablaInternaResumen.Name = "tablaInternaResumen";
            this.tablaInternaResumen.RowCount = 5;
            this.tablaInternaResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablaInternaResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablaInternaResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablaInternaResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablaInternaResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablaInternaResumen.Size = new System.Drawing.Size(908, 94);
            this.tablaInternaResumen.TabIndex = 0;
            // 
            // labelCodigo
            // 
            this.labelCodigo.Content = "Código:";
            this.labelCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(3, 3);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(105, 12);
            this.labelCodigo.TabIndex = 0;
            // 
            // labelProducto
            // 
            this.labelProducto.Content = "Producto:";
            this.labelProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.Location = new System.Drawing.Point(3, 21);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(105, 12);
            this.labelProducto.TabIndex = 1;
            // 
            // labelProveedor
            // 
            this.labelProveedor.Content = "Proveedor:";
            this.labelProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.Location = new System.Drawing.Point(3, 39);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(105, 12);
            this.labelProveedor.TabIndex = 2;
            // 
            // labelFechas
            // 
            this.labelFechas.Content = "Fechas:";
            this.labelFechas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechas.Location = new System.Drawing.Point(3, 57);
            this.labelFechas.Name = "labelFechas";
            this.labelFechas.Size = new System.Drawing.Size(105, 12);
            this.labelFechas.TabIndex = 3;
            // 
            // labelEstado
            // 
            this.labelEstado.Content = "Estado:";
            this.labelEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(3, 75);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(105, 16);
            this.labelEstado.TabIndex = 4;
            // 
            // cuiLabel6
            // 
            this.cuiLabel6.Content = "Your text here!";
            this.cuiLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiLabel6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel6.Location = new System.Drawing.Point(114, 3);
            this.cuiLabel6.Name = "cuiLabel6";
            this.cuiLabel6.Size = new System.Drawing.Size(791, 12);
            this.cuiLabel6.TabIndex = 5;
            this.cuiLabel6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel7
            // 
            this.cuiLabel7.Content = "Your text here!";
            this.cuiLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiLabel7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel7.Location = new System.Drawing.Point(114, 21);
            this.cuiLabel7.Name = "cuiLabel7";
            this.cuiLabel7.Size = new System.Drawing.Size(791, 12);
            this.cuiLabel7.TabIndex = 6;
            this.cuiLabel7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel8
            // 
            this.cuiLabel8.Content = "Your text here!";
            this.cuiLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiLabel8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel8.Location = new System.Drawing.Point(114, 39);
            this.cuiLabel8.Name = "cuiLabel8";
            this.cuiLabel8.Size = new System.Drawing.Size(791, 12);
            this.cuiLabel8.TabIndex = 7;
            this.cuiLabel8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel9
            // 
            this.cuiLabel9.Content = "Your text here!";
            this.cuiLabel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiLabel9.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel9.Location = new System.Drawing.Point(114, 57);
            this.cuiLabel9.Name = "cuiLabel9";
            this.cuiLabel9.Size = new System.Drawing.Size(791, 12);
            this.cuiLabel9.TabIndex = 8;
            this.cuiLabel9.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel10
            // 
            this.cuiLabel10.Content = "Your text here!";
            this.cuiLabel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiLabel10.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel10.Location = new System.Drawing.Point(114, 75);
            this.cuiLabel10.Name = "cuiLabel10";
            this.cuiLabel10.Size = new System.Drawing.Size(791, 16);
            this.cuiLabel10.TabIndex = 9;
            this.cuiLabel10.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tablaInternaBusqueda
            // 
            this.tablaInternaBusqueda.ColumnCount = 5;
            this.tablaInternaBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaInternaBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaInternaBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaInternaBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaInternaBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaInternaBusqueda.Controls.Add(this.textoBoxCodigoLote, 1, 0);
            this.tablaInternaBusqueda.Controls.Add(this.labelCodigoLote, 0, 0);
            this.tablaInternaBusqueda.Controls.Add(this.btnBuscar, 2, 0);
            this.tablaInternaBusqueda.Controls.Add(this.checkSoloVigentes, 4, 0);
            this.tablaInternaBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaInternaBusqueda.Location = new System.Drawing.Point(10, 8);
            this.tablaInternaBusqueda.Name = "tablaInternaBusqueda";
            this.tablaInternaBusqueda.RowCount = 1;
            this.tablaInternaBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablaInternaBusqueda.Size = new System.Drawing.Size(918, 33);
            this.tablaInternaBusqueda.TabIndex = 0;
            this.tablaInternaBusqueda.Paint += new System.Windows.Forms.PaintEventHandler(this.tablaInternaBusqueda_Paint);
            // 
            // checkSoloVigentes
            // 
            this.checkSoloVigentes.AutoSize = true;
            this.checkSoloVigentes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkSoloVigentes.CheckedState.BorderRadius = 0;
            this.checkSoloVigentes.CheckedState.BorderThickness = 0;
            this.checkSoloVigentes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkSoloVigentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkSoloVigentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkSoloVigentes.Location = new System.Drawing.Point(690, 3);
            this.checkSoloVigentes.Name = "checkSoloVigentes";
            this.checkSoloVigentes.Size = new System.Drawing.Size(225, 27);
            this.checkSoloVigentes.TabIndex = 5;
            this.checkSoloVigentes.Text = "  Mostrar solo vigentes";
            this.checkSoloVigentes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkSoloVigentes.UncheckedState.BorderRadius = 0;
            this.checkSoloVigentes.UncheckedState.BorderThickness = 0;
            this.checkSoloVigentes.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // btnBuscar
            // 
            this.btnBuscar.CheckButton = false;
            this.btnBuscar.Checked = false;
            this.btnBuscar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBuscar.CheckedForeColor = System.Drawing.Color.White;
            this.btnBuscar.CheckedImageTint = System.Drawing.Color.White;
            this.btnBuscar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBuscar.Content = "Buscar";
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.HoverBackground = System.Drawing.Color.White;
            this.btnBuscar.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnBuscar.HoverImageTint = System.Drawing.Color.Red;
            this.btnBuscar.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscar.Image = global::DataBeef.Properties.Resources.search;
            this.btnBuscar.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnBuscar.Location = new System.Drawing.Point(461, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NormalBackground = System.Drawing.Color.White;
            this.btnBuscar.NormalForeColor = System.Drawing.Color.Black;
            this.btnBuscar.NormalImageTint = System.Drawing.Color.Red;
            this.btnBuscar.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscar.OutlineThickness = 1F;
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(12);
            this.btnBuscar.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBuscar.PressedImageTint = System.Drawing.Color.Red;
            this.btnBuscar.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscar.Rounding = new System.Windows.Forms.Padding(8);
            this.btnBuscar.Size = new System.Drawing.Size(223, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBuscar.TextPadding = 12;
            this.btnBuscar.TextSpacing = 2;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelCodigoLote
            // 
            this.labelCodigoLote.Content = "Código de Lote:";
            this.labelCodigoLote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCodigoLote.Location = new System.Drawing.Point(3, 3);
            this.labelCodigoLote.Name = "labelCodigoLote";
            this.labelCodigoLote.Size = new System.Drawing.Size(223, 27);
            this.labelCodigoLote.TabIndex = 3;
            this.labelCodigoLote.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // textoBoxCodigoLote
            // 
            this.textoBoxCodigoLote.BackgroundColor = System.Drawing.Color.White;
            this.textoBoxCodigoLote.Content = "";
            this.textoBoxCodigoLote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textoBoxCodigoLote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textoBoxCodigoLote.FocusBackgroundColor = System.Drawing.Color.White;
            this.textoBoxCodigoLote.FocusImageTint = System.Drawing.Color.White;
            this.textoBoxCodigoLote.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.textoBoxCodigoLote.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoBoxCodigoLote.ForeColor = System.Drawing.Color.Gray;
            this.textoBoxCodigoLote.Image = null;
            this.textoBoxCodigoLote.ImageExpand = new System.Drawing.Point(0, 0);
            this.textoBoxCodigoLote.ImageOffset = new System.Drawing.Point(0, 0);
            this.textoBoxCodigoLote.Location = new System.Drawing.Point(233, 4);
            this.textoBoxCodigoLote.Margin = new System.Windows.Forms.Padding(4);
            this.textoBoxCodigoLote.Multiline = false;
            this.textoBoxCodigoLote.Name = "textoBoxCodigoLote";
            this.textoBoxCodigoLote.NormalImageTint = System.Drawing.Color.White;
            this.textoBoxCodigoLote.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textoBoxCodigoLote.Padding = new System.Windows.Forms.Padding(16, 4, 16, 0);
            this.textoBoxCodigoLote.PasswordChar = false;
            this.textoBoxCodigoLote.PlaceholderColor = System.Drawing.Color.LightGray;
            this.textoBoxCodigoLote.PlaceholderText = "Código";
            this.textoBoxCodigoLote.Rounding = new System.Windows.Forms.Padding(8);
            this.textoBoxCodigoLote.Size = new System.Drawing.Size(221, 25);
            this.textoBoxCodigoLote.TabIndex = 4;
            this.textoBoxCodigoLote.TextOffset = new System.Drawing.Size(0, 0);
            this.textoBoxCodigoLote.UnderlinedStyle = true;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.tablaInternaBusqueda);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusqueda.Location = new System.Drawing.Point(3, 3);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.OutlineThickness = 1F;
            this.panelBusqueda.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panelBusqueda.PanelColor = System.Drawing.Color.White;
            this.panelBusqueda.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelBusqueda.Rounding = new System.Windows.Forms.Padding(8);
            this.panelBusqueda.Size = new System.Drawing.Size(938, 49);
            this.panelBusqueda.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(916, 244);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "VENTAS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.Size = new System.Drawing.Size(910, 238);
            this.dataGridView4.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Responsable";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Cantidad (KG)";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Etapa";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(916, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PRODUCCIÓN";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Etapa,
            this.Detalle,
            this.Cantidad,
            this.Responsable});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(910, 238);
            this.dataGridView1.TabIndex = 1;
            // 
            // Responsable
            // 
            this.Responsable.HeaderText = "Responsable";
            this.Responsable.Name = "Responsable";
            this.Responsable.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad (KG)";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // Etapa
            // 
            this.Etapa.HeaderText = "Etapa";
            this.Etapa.Name = "Etapa";
            this.Etapa.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(916, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "COMPRAS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Proveedor,
            this.Producto,
            this.dataGridViewTextBoxColumn4,
            this.CostoTotal});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(910, 238);
            this.dataGridView2.TabIndex = 1;
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "Costo Total";
            this.CostoTotal.Name = "CostoTotal";
            this.CostoTotal.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad (KG)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tabHistorial
            // 
            this.tabHistorial.Controls.Add(this.tabPage1);
            this.tabHistorial.Controls.Add(this.tabPage2);
            this.tabHistorial.Controls.Add(this.tabPage4);
            this.tabHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHistorial.Location = new System.Drawing.Point(10, 180);
            this.tabHistorial.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.SelectedIndex = 0;
            this.tabHistorial.Size = new System.Drawing.Size(924, 270);
            this.tabHistorial.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.cuiButton2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cuiButton1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cuiButton3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 458);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(938, 40);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // cuiButton1
            // 
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.Content = "IMPRIMIR HISTORIAL";
            this.cuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton1.ForeColor = System.Drawing.Color.Black;
            this.cuiButton1.HoverBackground = System.Drawing.Color.White;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton1.HoverImageTint = System.Drawing.Color.Red;
            this.cuiButton1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Image = global::DataBeef.Properties.Resources.printer;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.Location = new System.Drawing.Point(471, 3);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.White;
            this.cuiButton1.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton1.NormalImageTint = System.Drawing.Color.Red;
            this.cuiButton1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.OutlineThickness = 1F;
            this.cuiButton1.Padding = new System.Windows.Forms.Padding(12);
            this.cuiButton1.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton1.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton1.PressedImageTint = System.Drawing.Color.Red;
            this.cuiButton1.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton1.Size = new System.Drawing.Size(228, 34);
            this.cuiButton1.TabIndex = 3;
            this.cuiButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton1.TextPadding = 12;
            this.cuiButton1.TextSpacing = 2;
            // 
            // cuiButton3
            // 
            this.cuiButton3.CheckButton = false;
            this.cuiButton3.Checked = false;
            this.cuiButton3.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton3.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton3.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton3.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton3.Content = "EXPORTAR A EXCEL";
            this.cuiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton3.ForeColor = System.Drawing.Color.Black;
            this.cuiButton3.HoverBackground = System.Drawing.Color.White;
            this.cuiButton3.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton3.HoverImageTint = System.Drawing.Color.Red;
            this.cuiButton3.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton3.Image")));
            this.cuiButton3.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton3.Location = new System.Drawing.Point(237, 3);
            this.cuiButton3.Name = "cuiButton3";
            this.cuiButton3.NormalBackground = System.Drawing.Color.White;
            this.cuiButton3.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton3.NormalImageTint = System.Drawing.Color.Red;
            this.cuiButton3.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.OutlineThickness = 1F;
            this.cuiButton3.Padding = new System.Windows.Forms.Padding(12);
            this.cuiButton3.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton3.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton3.PressedImageTint = System.Drawing.Color.Red;
            this.cuiButton3.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton3.Size = new System.Drawing.Size(228, 34);
            this.cuiButton3.TabIndex = 5;
            this.cuiButton3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton3.TextPadding = 12;
            this.cuiButton3.TextSpacing = 2;
            // 
            // cuiButton2
            // 
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton2.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton2.Content = "VER CÓDIGO QR";
            this.cuiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton2.ForeColor = System.Drawing.Color.Black;
            this.cuiButton2.HoverBackground = System.Drawing.Color.White;
            this.cuiButton2.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton2.HoverImageTint = System.Drawing.Color.DimGray;
            this.cuiButton2.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.Image = global::DataBeef.Properties.Resources.qr_code;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton2.Location = new System.Drawing.Point(705, 3);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.White;
            this.cuiButton2.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton2.NormalImageTint = System.Drawing.Color.Red;
            this.cuiButton2.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.OutlineThickness = 1F;
            this.cuiButton2.Padding = new System.Windows.Forms.Padding(12);
            this.cuiButton2.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton2.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton2.PressedImageTint = System.Drawing.Color.Red;
            this.cuiButton2.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton2.Size = new System.Drawing.Size(230, 34);
            this.cuiButton2.TabIndex = 9;
            this.cuiButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton2.TextPadding = 12;
            this.cuiButton2.TextSpacing = 2;
            // 
            // fmTrazabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tablaGeneral);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "fmTrazabilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión - Trazabilidad";
            this.tablaGeneral.ResumeLayout(false);
            this.panelResumen.ResumeLayout(false);
            this.tablaInternaResumen.ResumeLayout(false);
            this.tablaInternaBusqueda.ResumeLayout(false);
            this.tablaInternaBusqueda.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabHistorial.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablaGeneral;
        private HartUI.Controls.cuiPanel panelResumen;
        private System.Windows.Forms.TableLayoutPanel tablaInternaResumen;
        private HartUI.Controls.cuiLabel labelCodigo;
        private HartUI.Controls.cuiLabel labelProducto;
        private HartUI.Controls.cuiLabel labelProveedor;
        private HartUI.Controls.cuiLabel labelFechas;
        private HartUI.Controls.cuiLabel labelEstado;
        private HartUI.Controls.cuiLabel cuiLabel6;
        private HartUI.Controls.cuiLabel cuiLabel7;
        private HartUI.Controls.cuiLabel cuiLabel8;
        private HartUI.Controls.cuiLabel cuiLabel9;
        private HartUI.Controls.cuiLabel cuiLabel10;
        private HartUI.Controls.cuiPanel panelBusqueda;
        private System.Windows.Forms.TableLayoutPanel tablaInternaBusqueda;
        private HartUI.Controls.cuiTextBox textoBoxCodigoLote;
        private HartUI.Controls.cuiLabel labelCodigoLote;
        private HartUI.Controls.cuiButton btnBuscar;
        private Guna.UI2.WinForms.Guna2CheckBox checkSoloVigentes;
        private System.Windows.Forms.TabControl tabHistorial;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private HartUI.Controls.cuiButton cuiButton2;
        private HartUI.Controls.cuiButton cuiButton1;
        private HartUI.Controls.cuiButton cuiButton3;
    }
}

