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
            this.tablaGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.panelBusqueda = new HartUI.Controls.cuiPanel();
            this.tablaInternaBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.textoBoxCodigoLote = new HartUI.Controls.cuiTextBox();
            this.labelCodigoLote = new HartUI.Controls.cuiLabel();
            this.btnBuscar = new HartUI.Controls.cuiButton();
            this.checkSoloVigentes = new HartUI.Controls.cuiCheckbox();
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
            this.cuiPanel1 = new HartUI.Controls.cuiPanel();
            this.flowBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.cuiButton1 = new HartUI.Controls.cuiButton();
            this.cuiButton2 = new HartUI.Controls.cuiButton();
            this.cuiButton3 = new HartUI.Controls.cuiButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHistorial = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaGeneral.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.tablaInternaBusqueda.SuspendLayout();
            this.panelResumen.SuspendLayout();
            this.tablaInternaResumen.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.flowBotones.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabHistorial.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaGeneral
            // 
            this.tablaGeneral.ColumnCount = 1;
            this.tablaGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablaGeneral.Controls.Add(this.panelBusqueda, 0, 0);
            this.tablaGeneral.Controls.Add(this.panelResumen, 0, 1);
            this.tablaGeneral.Controls.Add(this.tabHistorial, 0, 2);
            this.tablaGeneral.Controls.Add(this.cuiPanel1, 0, 3);
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
            // tablaInternaBusqueda
            // 
            this.tablaInternaBusqueda.ColumnCount = 4;
            this.tablaInternaBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaInternaBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tablaInternaBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaInternaBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablaInternaBusqueda.Controls.Add(this.textoBoxCodigoLote, 1, 0);
            this.tablaInternaBusqueda.Controls.Add(this.labelCodigoLote, 0, 0);
            this.tablaInternaBusqueda.Controls.Add(this.btnBuscar, 2, 0);
            this.tablaInternaBusqueda.Controls.Add(this.checkSoloVigentes, 3, 0);
            this.tablaInternaBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaInternaBusqueda.Location = new System.Drawing.Point(10, 8);
            this.tablaInternaBusqueda.Name = "tablaInternaBusqueda";
            this.tablaInternaBusqueda.RowCount = 1;
            this.tablaInternaBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablaInternaBusqueda.Size = new System.Drawing.Size(918, 33);
            this.tablaInternaBusqueda.TabIndex = 0;
            this.tablaInternaBusqueda.Paint += new System.Windows.Forms.PaintEventHandler(this.tablaInternaBusqueda_Paint);
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
            this.textoBoxCodigoLote.Location = new System.Drawing.Point(154, 4);
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
            this.textoBoxCodigoLote.Size = new System.Drawing.Size(192, 25);
            this.textoBoxCodigoLote.TabIndex = 4;
            this.textoBoxCodigoLote.TextOffset = new System.Drawing.Size(0, 0);
            this.textoBoxCodigoLote.UnderlinedStyle = true;
            // 
            // labelCodigoLote
            // 
            this.labelCodigoLote.Content = "Código de Lote:";
            this.labelCodigoLote.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.labelCodigoLote.Location = new System.Drawing.Point(3, 3);
            this.labelCodigoLote.Name = "labelCodigoLote";
            this.labelCodigoLote.Size = new System.Drawing.Size(144, 27);
            this.labelCodigoLote.TabIndex = 3;
            this.labelCodigoLote.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.labelCodigoLote.Load += new System.EventHandler(this.cuiLabel1_Load);
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
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.HoverBackground = System.Drawing.Color.White;
            this.btnBuscar.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnBuscar.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnBuscar.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnBuscar.Location = new System.Drawing.Point(353, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NormalBackground = System.Drawing.Color.White;
            this.btnBuscar.NormalForeColor = System.Drawing.Color.Black;
            this.btnBuscar.NormalImageTint = System.Drawing.Color.Black;
            this.btnBuscar.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscar.OutlineThickness = 1F;
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(12);
            this.btnBuscar.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBuscar.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBuscar.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscar.Rounding = new System.Windows.Forms.Padding(8);
            this.btnBuscar.Size = new System.Drawing.Size(153, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBuscar.TextPadding = 12;
            this.btnBuscar.TextSpacing = 2;
            // 
            // checkSoloVigentes
            // 
            this.checkSoloVigentes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkSoloVigentes.BackColor = System.Drawing.Color.White;
            this.checkSoloVigentes.Checked = false;
            this.checkSoloVigentes.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkSoloVigentes.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkSoloVigentes.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkSoloVigentes.Content = "Mostrar solo vigentes";
            this.checkSoloVigentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkSoloVigentes.Location = new System.Drawing.Point(755, 4);
            this.checkSoloVigentes.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkSoloVigentes.Name = "checkSoloVigentes";
            this.checkSoloVigentes.OutlineThickness = 1F;
            this.checkSoloVigentes.Rounding = 4;
            this.checkSoloVigentes.ShowSymbols = true;
            this.checkSoloVigentes.Size = new System.Drawing.Size(160, 25);
            this.checkSoloVigentes.TabIndex = 5;
            this.checkSoloVigentes.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkSoloVigentes.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkSoloVigentes.UncheckedSymbolColor = System.Drawing.Color.Empty;
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
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.labelCodigo.Location = new System.Drawing.Point(3, 3);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(105, 12);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // labelProducto
            // 
            this.labelProducto.Content = "Producto:";
            this.labelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.labelProducto.Location = new System.Drawing.Point(3, 21);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(105, 12);
            this.labelProducto.TabIndex = 1;
            this.labelProducto.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // labelProveedor
            // 
            this.labelProveedor.Content = "Proveedor:";
            this.labelProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.labelProveedor.Location = new System.Drawing.Point(3, 39);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(105, 12);
            this.labelProveedor.TabIndex = 2;
            this.labelProveedor.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // labelFechas
            // 
            this.labelFechas.Content = "Fechas:";
            this.labelFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechas.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.labelFechas.Location = new System.Drawing.Point(3, 57);
            this.labelFechas.Name = "labelFechas";
            this.labelFechas.Size = new System.Drawing.Size(105, 12);
            this.labelFechas.TabIndex = 3;
            this.labelFechas.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // labelEstado
            // 
            this.labelEstado.Content = "Estado:";
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.labelEstado.Location = new System.Drawing.Point(3, 75);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(105, 16);
            this.labelEstado.TabIndex = 4;
            this.labelEstado.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLabel6
            // 
            this.cuiLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiLabel6.Content = "Your text here!";
            this.cuiLabel6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel6.Location = new System.Drawing.Point(114, 3);
            this.cuiLabel6.Name = "cuiLabel6";
            this.cuiLabel6.Size = new System.Drawing.Size(791, 12);
            this.cuiLabel6.TabIndex = 5;
            this.cuiLabel6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel7
            // 
            this.cuiLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiLabel7.Content = "Your text here!";
            this.cuiLabel7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel7.Location = new System.Drawing.Point(114, 21);
            this.cuiLabel7.Name = "cuiLabel7";
            this.cuiLabel7.Size = new System.Drawing.Size(791, 12);
            this.cuiLabel7.TabIndex = 6;
            this.cuiLabel7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel8
            // 
            this.cuiLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiLabel8.Content = "Your text here!";
            this.cuiLabel8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel8.Location = new System.Drawing.Point(114, 39);
            this.cuiLabel8.Name = "cuiLabel8";
            this.cuiLabel8.Size = new System.Drawing.Size(791, 12);
            this.cuiLabel8.TabIndex = 7;
            this.cuiLabel8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel9
            // 
            this.cuiLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiLabel9.Content = "Your text here!";
            this.cuiLabel9.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel9.Location = new System.Drawing.Point(114, 57);
            this.cuiLabel9.Name = "cuiLabel9";
            this.cuiLabel9.Size = new System.Drawing.Size(791, 12);
            this.cuiLabel9.TabIndex = 8;
            this.cuiLabel9.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel10
            // 
            this.cuiLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiLabel10.Content = "Your text here!";
            this.cuiLabel10.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel10.Location = new System.Drawing.Point(114, 75);
            this.cuiLabel10.Name = "cuiLabel10";
            this.cuiLabel10.Size = new System.Drawing.Size(791, 16);
            this.cuiLabel10.TabIndex = 9;
            this.cuiLabel10.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.flowBotones);
            this.cuiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiPanel1.Location = new System.Drawing.Point(3, 458);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.cuiPanel1.PanelColor = System.Drawing.Color.White;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.Size = new System.Drawing.Size(938, 40);
            this.cuiPanel1.TabIndex = 3;
            // 
            // flowBotones
            // 
            this.flowBotones.AutoSize = true;
            this.flowBotones.Controls.Add(this.cuiButton1);
            this.flowBotones.Controls.Add(this.cuiButton3);
            this.flowBotones.Controls.Add(this.cuiButton2);
            this.flowBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowBotones.Location = new System.Drawing.Point(441, 5);
            this.flowBotones.Margin = new System.Windows.Forms.Padding(0);
            this.flowBotones.Name = "flowBotones";
            this.flowBotones.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.flowBotones.Size = new System.Drawing.Size(487, 30);
            this.flowBotones.TabIndex = 0;
            this.flowBotones.WrapContents = false;
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
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton1.ForeColor = System.Drawing.Color.Black;
            this.cuiButton1.HoverBackground = System.Drawing.Color.White;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton1.HoverImageTint = System.Drawing.Color.DimGray;
            this.cuiButton1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Image = null;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.Location = new System.Drawing.Point(8, 3);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.White;
            this.cuiButton1.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton1.NormalImageTint = System.Drawing.Color.Black;
            this.cuiButton1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.OutlineThickness = 1F;
            this.cuiButton1.Padding = new System.Windows.Forms.Padding(12);
            this.cuiButton1.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton1.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton1.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton1.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton1.Size = new System.Drawing.Size(153, 27);
            this.cuiButton1.TabIndex = 0;
            this.cuiButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton1.TextPadding = 12;
            this.cuiButton1.TextSpacing = 2;
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
            this.cuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton2.ForeColor = System.Drawing.Color.Black;
            this.cuiButton2.HoverBackground = System.Drawing.Color.White;
            this.cuiButton2.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton2.HoverImageTint = System.Drawing.Color.DimGray;
            this.cuiButton2.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.Image = null;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton2.Location = new System.Drawing.Point(326, 3);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.White;
            this.cuiButton2.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton2.NormalImageTint = System.Drawing.Color.Black;
            this.cuiButton2.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.OutlineThickness = 1F;
            this.cuiButton2.Padding = new System.Windows.Forms.Padding(12);
            this.cuiButton2.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton2.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton2.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton2.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton2.Size = new System.Drawing.Size(153, 27);
            this.cuiButton2.TabIndex = 1;
            this.cuiButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton2.TextPadding = 12;
            this.cuiButton2.TextSpacing = 2;
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
            this.cuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton3.ForeColor = System.Drawing.Color.Black;
            this.cuiButton3.HoverBackground = System.Drawing.Color.White;
            this.cuiButton3.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton3.HoverImageTint = System.Drawing.Color.DimGray;
            this.cuiButton3.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.Image = null;
            this.cuiButton3.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton3.Location = new System.Drawing.Point(167, 3);
            this.cuiButton3.Name = "cuiButton3";
            this.cuiButton3.NormalBackground = System.Drawing.Color.White;
            this.cuiButton3.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton3.NormalImageTint = System.Drawing.Color.Black;
            this.cuiButton3.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.OutlineThickness = 1F;
            this.cuiButton3.Padding = new System.Windows.Forms.Padding(12);
            this.cuiButton3.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton3.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton3.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton3.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton3.Size = new System.Drawing.Size(153, 27);
            this.cuiButton3.TabIndex = 2;
            this.cuiButton3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton3.TextPadding = 12;
            this.cuiButton3.TextSpacing = 2;
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
            this.tabHistorial.Controls.Add(this.tabPage3);
            this.tabHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHistorial.Location = new System.Drawing.Point(10, 180);
            this.tabHistorial.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.SelectedIndex = 0;
            this.tabHistorial.Size = new System.Drawing.Size(924, 270);
            this.tabHistorial.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(916, 244);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "VENTAS";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Etapa
            // 
            this.Etapa.HeaderText = "Etapa";
            this.Etapa.Name = "Etapa";
            this.Etapa.ReadOnly = true;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad (KG)";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Responsable
            // 
            this.Responsable.HeaderText = "Responsable";
            this.Responsable.Name = "Responsable";
            this.Responsable.ReadOnly = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(916, 244);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Etapa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad (KG)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Responsable";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tablaGeneral);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión - Trazabilidad";
            this.tablaGeneral.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.tablaInternaBusqueda.ResumeLayout(false);
            this.panelResumen.ResumeLayout(false);
            this.tablaInternaResumen.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel1.PerformLayout();
            this.flowBotones.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabHistorial.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablaGeneral;
        private HartUI.Controls.cuiPanel panelBusqueda;
        private System.Windows.Forms.TableLayoutPanel tablaInternaBusqueda;
        private HartUI.Controls.cuiButton btnBuscar;
        private HartUI.Controls.cuiTextBox textoBoxCodigoLote;
        private HartUI.Controls.cuiLabel labelCodigoLote;
        private HartUI.Controls.cuiCheckbox checkSoloVigentes;
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
        private HartUI.Controls.cuiPanel cuiPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowBotones;
        private HartUI.Controls.cuiButton cuiButton1;
        private HartUI.Controls.cuiButton cuiButton3;
        private HartUI.Controls.cuiButton cuiButton2;
        private System.Windows.Forms.TabControl tabHistorial;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

