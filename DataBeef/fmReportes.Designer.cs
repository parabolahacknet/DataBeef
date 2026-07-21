namespace DataBeef
{
    partial class fmReportes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel lineaRoja;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlFiltros;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFiltroDesde;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFiltroHasta;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFiltroTipo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaDesde;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaHasta;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoReporte;
        private Guna.UI2.WinForms.Guna2Button btnGenerarReporte;
        private Guna.UI2.WinForms.Guna2Button btnExportarPdf;
        private Guna.UI2.WinForms.Guna2Button btnExportarExcel;
        private Guna.UI2.WinForms.Guna2Panel pnlCompras;
        private Guna.UI2.WinForms.Guna2Panel pnlVentas;
        private Guna.UI2.WinForms.Guna2Panel pnlGanancia;
        private Guna.UI2.WinForms.Guna2Panel pnlInventario;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblComprasIcono;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVentasIcono;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGananciaIcono;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInventarioIcono;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblComprasNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVentasNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGananciaNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInventarioNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblComprasValor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVentasValor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGananciaValor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInventarioValor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblComprasPeriodo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVentasPeriodo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGananciaPeriodo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInventarioPeriodo;
        private Guna.UI2.WinForms.Guna2Panel pnlGraficoVentas;
        private Guna.UI2.WinForms.Guna2Panel pnlGraficoInventario;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGraficoVentas;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGraficoInventario;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInventario;
        private Guna.UI2.WinForms.Guna2Panel pnlDetalle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDetalleTitulo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetalleReporte;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalRegistros;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblValorTotal;
        private Guna.UI2.WinForms.Guna2MessageDialog dlgMensajes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.lineaRoja = new System.Windows.Forms.Panel();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSubtitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlFiltros = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFiltroDesde = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFiltroHasta = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFiltroTipo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpFechaDesde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFechaHasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbTipoReporte = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnGenerarReporte = new Guna.UI2.WinForms.Guna2Button();
            this.btnExportarPdf = new Guna.UI2.WinForms.Guna2Button();
            this.btnExportarExcel = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCompras = new Guna.UI2.WinForms.Guna2Panel();
            this.lblComprasIcono = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblComprasNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblComprasValor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblComprasPeriodo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlVentas = new Guna.UI2.WinForms.Guna2Panel();
            this.lblVentasIcono = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblVentasNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblVentasValor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblVentasPeriodo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlGanancia = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGananciaIcono = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGananciaNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGananciaValor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGananciaPeriodo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlInventario = new Guna.UI2.WinForms.Guna2Panel();
            this.lblInventarioIcono = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblInventarioNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblInventarioValor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblInventarioPeriodo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlGraficoVentas = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGraficoVentas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlGraficoInventario = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGraficoInventario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chartInventario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlDetalle = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDetalleTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvDetalleReporte = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTotalRegistros = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblValorTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dlgMensajes = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.pnlContenido.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.pnlCompras.SuspendLayout();
            this.pnlVentas.SuspendLayout();
            this.pnlGanancia.SuspendLayout();
            this.pnlInventario.SuspendLayout();
            this.pnlGraficoVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            this.pnlGraficoInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInventario)).BeginInit();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.AutoScroll = true;
            this.pnlContenido.AutoScrollMinSize = new System.Drawing.Size(0, 850);
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlContenido.Controls.Add(this.lineaRoja);
            this.pnlContenido.Controls.Add(this.lblTitulo);
            this.pnlContenido.Controls.Add(this.lblSubtitulo);
            this.pnlContenido.Controls.Add(this.pnlFiltros);
            this.pnlContenido.Controls.Add(this.pnlCompras);
            this.pnlContenido.Controls.Add(this.pnlVentas);
            this.pnlContenido.Controls.Add(this.pnlGanancia);
            this.pnlContenido.Controls.Add(this.pnlInventario);
            this.pnlContenido.Controls.Add(this.pnlGraficoVentas);
            this.pnlContenido.Controls.Add(this.pnlGraficoInventario);
            this.pnlContenido.Controls.Add(this.pnlDetalle);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 0);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1370, 749);
            this.pnlContenido.TabIndex = 0;
            // 
            // lineaRoja
            // 
            this.lineaRoja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(6)))), ((int)(((byte)(0)))));
            this.lineaRoja.Location = new System.Drawing.Point(24, 22);
            this.lineaRoja.Name = "lineaRoja";
            this.lineaRoja.Size = new System.Drawing.Size(6, 48);
            this.lineaRoja.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblTitulo.Location = new System.Drawing.Point(43, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(363, 40);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "REPORTES Y ESTADÍSTICAS";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(45, 54);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(180, 19);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Módulo de análisis e informes";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiltros.BorderRadius = 7;
            this.pnlFiltros.Controls.Add(this.lblFiltroDesde);
            this.pnlFiltros.Controls.Add(this.lblFiltroHasta);
            this.pnlFiltros.Controls.Add(this.lblFiltroTipo);
            this.pnlFiltros.Controls.Add(this.dtpFechaDesde);
            this.pnlFiltros.Controls.Add(this.dtpFechaHasta);
            this.pnlFiltros.Controls.Add(this.cmbTipoReporte);
            this.pnlFiltros.Controls.Add(this.btnGenerarReporte);
            this.pnlFiltros.Controls.Add(this.btnExportarPdf);
            this.pnlFiltros.Controls.Add(this.btnExportarExcel);
            this.pnlFiltros.FillColor = System.Drawing.Color.White;
            this.pnlFiltros.Location = new System.Drawing.Point(24, 98);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1326, 88);
            this.pnlFiltros.TabIndex = 3;
            // 
            // lblFiltroDesde
            // 
            this.lblFiltroDesde.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroDesde.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFiltroDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblFiltroDesde.Location = new System.Drawing.Point(16, 9);
            this.lblFiltroDesde.Name = "lblFiltroDesde";
            this.lblFiltroDesde.Size = new System.Drawing.Size(67, 15);
            this.lblFiltroDesde.TabIndex = 0;
            this.lblFiltroDesde.Text = "Fecha desde";
            // 
            // lblFiltroHasta
            // 
            this.lblFiltroHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroHasta.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFiltroHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblFiltroHasta.Location = new System.Drawing.Point(190, 9);
            this.lblFiltroHasta.Name = "lblFiltroHasta";
            this.lblFiltroHasta.Size = new System.Drawing.Size(64, 15);
            this.lblFiltroHasta.TabIndex = 1;
            this.lblFiltroHasta.Text = "Fecha hasta";
            // 
            // lblFiltroTipo
            // 
            this.lblFiltroTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroTipo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFiltroTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblFiltroTipo.Location = new System.Drawing.Point(364, 9);
            this.lblFiltroTipo.Name = "lblFiltroTipo";
            this.lblFiltroTipo.Size = new System.Drawing.Size(82, 15);
            this.lblFiltroTipo.TabIndex = 2;
            this.lblFiltroTipo.Text = "Tipo de reporte";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.BorderRadius = 5;
            this.dtpFechaDesde.Checked = true;
            this.dtpFechaDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDesde.FillColor = System.Drawing.Color.White;
            this.dtpFechaDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesde.Location = new System.Drawing.Point(16, 31);
            this.dtpFechaDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaDesde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(160, 42);
            this.dtpFechaDesde.TabIndex = 3;
            this.dtpFechaDesde.Value = new System.DateTime(2026, 7, 15, 22, 39, 51, 265);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.BorderRadius = 5;
            this.dtpFechaHasta.Checked = true;
            this.dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaHasta.FillColor = System.Drawing.Color.White;
            this.dtpFechaHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(190, 31);
            this.dtpFechaHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaHasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(160, 42);
            this.dtpFechaHasta.TabIndex = 4;
            this.dtpFechaHasta.Value = new System.DateTime(2026, 7, 15, 22, 39, 51, 288);
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoReporte.BorderRadius = 5;
            this.cmbTipoReporte.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoReporte.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTipoReporte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTipoReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTipoReporte.ItemHeight = 30;
            this.cmbTipoReporte.Location = new System.Drawing.Point(364, 31);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(225, 36);
            this.cmbTipoReporte.TabIndex = 5;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarReporte.BorderRadius = 5;
            this.btnGenerarReporte.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(6)))), ((int)(((byte)(0)))));
            this.btnGenerarReporte.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(718, 31);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(202, 42);
            this.btnGenerarReporte.TabIndex = 6;
            this.btnGenerarReporte.Text = "GENERAR REPORTE";
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // btnExportarPdf
            // 
            this.btnExportarPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarPdf.BorderRadius = 5;
            this.btnExportarPdf.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnExportarPdf.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.btnExportarPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportarPdf.Location = new System.Drawing.Point(936, 31);
            this.btnExportarPdf.Name = "btnExportarPdf";
            this.btnExportarPdf.Size = new System.Drawing.Size(176, 42);
            this.btnExportarPdf.TabIndex = 7;
            this.btnExportarPdf.Text = "EXPORTAR PDF";
            this.btnExportarPdf.Click += new System.EventHandler(this.btnExportarPdf_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.BorderRadius = 5;
            this.btnExportarExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnExportarExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.btnExportarExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarExcel.Location = new System.Drawing.Point(1126, 31);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(184, 42);
            this.btnExportarExcel.TabIndex = 8;
            this.btnExportarExcel.Text = "EXPORTAR EXCEL";
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // pnlCompras
            // 
            this.pnlCompras.BorderRadius = 7;
            this.pnlCompras.Controls.Add(this.lblComprasIcono);
            this.pnlCompras.Controls.Add(this.lblComprasNombre);
            this.pnlCompras.Controls.Add(this.lblComprasValor);
            this.pnlCompras.Controls.Add(this.lblComprasPeriodo);
            this.pnlCompras.FillColor = System.Drawing.Color.White;
            this.pnlCompras.Location = new System.Drawing.Point(24, 192);
            this.pnlCompras.Name = "pnlCompras";
            this.pnlCompras.Size = new System.Drawing.Size(294, 112);
            this.pnlCompras.TabIndex = 4;
            // 
            // lblComprasIcono
            // 
            this.lblComprasIcono.BackColor = System.Drawing.Color.Transparent;
            this.lblComprasIcono.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblComprasIcono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(6)))), ((int)(((byte)(0)))));
            this.lblComprasIcono.Location = new System.Drawing.Point(16, 34);
            this.lblComprasIcono.Name = "lblComprasIcono";
            this.lblComprasIcono.Size = new System.Drawing.Size(18, 34);
            this.lblComprasIcono.TabIndex = 0;
            this.lblComprasIcono.Text = "●";
            // 
            // lblComprasNombre
            // 
            this.lblComprasNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblComprasNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblComprasNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblComprasNombre.Location = new System.Drawing.Point(60, 14);
            this.lblComprasNombre.Name = "lblComprasNombre";
            this.lblComprasNombre.Size = new System.Drawing.Size(111, 15);
            this.lblComprasNombre.TabIndex = 1;
            this.lblComprasNombre.Text = "TOTAL DE COMPRAS";
            // 
            // lblComprasValor
            // 
            this.lblComprasValor.BackColor = System.Drawing.Color.Transparent;
            this.lblComprasValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblComprasValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblComprasValor.Location = new System.Drawing.Point(60, 37);
            this.lblComprasValor.Name = "lblComprasValor";
            this.lblComprasValor.Size = new System.Drawing.Size(66, 34);
            this.lblComprasValor.TabIndex = 2;
            this.lblComprasValor.Text = "$0,00";
            // 
            // lblComprasPeriodo
            // 
            this.lblComprasPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblComprasPeriodo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblComprasPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblComprasPeriodo.Location = new System.Drawing.Point(60, 80);
            this.lblComprasPeriodo.Name = "lblComprasPeriodo";
            this.lblComprasPeriodo.Size = new System.Drawing.Size(133, 15);
            this.lblComprasPeriodo.TabIndex = 3;
            this.lblComprasPeriodo.Text = "Sin periodo seleccionado";
            // 
            // pnlVentas
            // 
            this.pnlVentas.BorderRadius = 7;
            this.pnlVentas.Controls.Add(this.lblVentasIcono);
            this.pnlVentas.Controls.Add(this.lblVentasNombre);
            this.pnlVentas.Controls.Add(this.lblVentasValor);
            this.pnlVentas.Controls.Add(this.lblVentasPeriodo);
            this.pnlVentas.FillColor = System.Drawing.Color.White;
            this.pnlVentas.Location = new System.Drawing.Point(375, 192);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(294, 112);
            this.pnlVentas.TabIndex = 5;
            // 
            // lblVentasIcono
            // 
            this.lblVentasIcono.BackColor = System.Drawing.Color.Transparent;
            this.lblVentasIcono.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblVentasIcono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(6)))), ((int)(((byte)(0)))));
            this.lblVentasIcono.Location = new System.Drawing.Point(16, 34);
            this.lblVentasIcono.Name = "lblVentasIcono";
            this.lblVentasIcono.Size = new System.Drawing.Size(24, 34);
            this.lblVentasIcono.TabIndex = 0;
            this.lblVentasIcono.Text = "▲";
            // 
            // lblVentasNombre
            // 
            this.lblVentasNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblVentasNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblVentasNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblVentasNombre.Location = new System.Drawing.Point(60, 14);
            this.lblVentasNombre.Name = "lblVentasNombre";
            this.lblVentasNombre.Size = new System.Drawing.Size(94, 15);
            this.lblVentasNombre.TabIndex = 1;
            this.lblVentasNombre.Text = "VENTAS TOTALES";
            // 
            // lblVentasValor
            // 
            this.lblVentasValor.BackColor = System.Drawing.Color.Transparent;
            this.lblVentasValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblVentasValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblVentasValor.Location = new System.Drawing.Point(60, 37);
            this.lblVentasValor.Name = "lblVentasValor";
            this.lblVentasValor.Size = new System.Drawing.Size(66, 34);
            this.lblVentasValor.TabIndex = 2;
            this.lblVentasValor.Text = "$0,00";
            // 
            // lblVentasPeriodo
            // 
            this.lblVentasPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblVentasPeriodo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVentasPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblVentasPeriodo.Location = new System.Drawing.Point(60, 80);
            this.lblVentasPeriodo.Name = "lblVentasPeriodo";
            this.lblVentasPeriodo.Size = new System.Drawing.Size(133, 15);
            this.lblVentasPeriodo.TabIndex = 3;
            this.lblVentasPeriodo.Text = "Sin periodo seleccionado";
            // 
            // pnlGanancia
            // 
            this.pnlGanancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGanancia.BorderRadius = 7;
            this.pnlGanancia.Controls.Add(this.lblGananciaIcono);
            this.pnlGanancia.Controls.Add(this.lblGananciaNombre);
            this.pnlGanancia.Controls.Add(this.lblGananciaValor);
            this.pnlGanancia.Controls.Add(this.lblGananciaPeriodo);
            this.pnlGanancia.FillColor = System.Drawing.Color.White;
            this.pnlGanancia.Location = new System.Drawing.Point(716, 192);
            this.pnlGanancia.Name = "pnlGanancia";
            this.pnlGanancia.Size = new System.Drawing.Size(294, 112);
            this.pnlGanancia.TabIndex = 6;
            // 
            // lblGananciaIcono
            // 
            this.lblGananciaIcono.BackColor = System.Drawing.Color.Transparent;
            this.lblGananciaIcono.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblGananciaIcono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(6)))), ((int)(((byte)(0)))));
            this.lblGananciaIcono.Location = new System.Drawing.Point(16, 34);
            this.lblGananciaIcono.Name = "lblGananciaIcono";
            this.lblGananciaIcono.Size = new System.Drawing.Size(17, 34);
            this.lblGananciaIcono.TabIndex = 0;
            this.lblGananciaIcono.Text = "$";
            // 
            // lblGananciaNombre
            // 
            this.lblGananciaNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblGananciaNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblGananciaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblGananciaNombre.Location = new System.Drawing.Point(60, 14);
            this.lblGananciaNombre.Name = "lblGananciaNombre";
            this.lblGananciaNombre.Size = new System.Drawing.Size(122, 15);
            this.lblGananciaNombre.TabIndex = 1;
            this.lblGananciaNombre.Text = "GANANCIA ESTIMADA";
            // 
            // lblGananciaValor
            // 
            this.lblGananciaValor.BackColor = System.Drawing.Color.Transparent;
            this.lblGananciaValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblGananciaValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblGananciaValor.Location = new System.Drawing.Point(60, 37);
            this.lblGananciaValor.Name = "lblGananciaValor";
            this.lblGananciaValor.Size = new System.Drawing.Size(66, 34);
            this.lblGananciaValor.TabIndex = 2;
            this.lblGananciaValor.Text = "$0,00";
            // 
            // lblGananciaPeriodo
            // 
            this.lblGananciaPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblGananciaPeriodo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGananciaPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblGananciaPeriodo.Location = new System.Drawing.Point(60, 80);
            this.lblGananciaPeriodo.Name = "lblGananciaPeriodo";
            this.lblGananciaPeriodo.Size = new System.Drawing.Size(133, 15);
            this.lblGananciaPeriodo.TabIndex = 3;
            this.lblGananciaPeriodo.Text = "Sin periodo seleccionado";
            // 
            // pnlInventario
            // 
            this.pnlInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInventario.BorderRadius = 7;
            this.pnlInventario.Controls.Add(this.lblInventarioIcono);
            this.pnlInventario.Controls.Add(this.lblInventarioNombre);
            this.pnlInventario.Controls.Add(this.lblInventarioValor);
            this.pnlInventario.Controls.Add(this.lblInventarioPeriodo);
            this.pnlInventario.FillColor = System.Drawing.Color.White;
            this.pnlInventario.Location = new System.Drawing.Point(1050, 192);
            this.pnlInventario.Name = "pnlInventario";
            this.pnlInventario.Size = new System.Drawing.Size(294, 112);
            this.pnlInventario.TabIndex = 7;
            // 
            // lblInventarioIcono
            // 
            this.lblInventarioIcono.BackColor = System.Drawing.Color.Transparent;
            this.lblInventarioIcono.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblInventarioIcono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(6)))), ((int)(((byte)(0)))));
            this.lblInventarioIcono.Location = new System.Drawing.Point(16, 34);
            this.lblInventarioIcono.Name = "lblInventarioIcono";
            this.lblInventarioIcono.Size = new System.Drawing.Size(24, 34);
            this.lblInventarioIcono.TabIndex = 0;
            this.lblInventarioIcono.Text = "■";
            // 
            // lblInventarioNombre
            // 
            this.lblInventarioNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblInventarioNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblInventarioNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblInventarioNombre.Location = new System.Drawing.Point(60, 14);
            this.lblInventarioNombre.Name = "lblInventarioNombre";
            this.lblInventarioNombre.Size = new System.Drawing.Size(135, 15);
            this.lblInventarioNombre.TabIndex = 1;
            this.lblInventarioNombre.Text = "INVENTARIO DISPONIBLE";
            // 
            // lblInventarioValor
            // 
            this.lblInventarioValor.BackColor = System.Drawing.Color.Transparent;
            this.lblInventarioValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblInventarioValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblInventarioValor.Location = new System.Drawing.Point(60, 37);
            this.lblInventarioValor.Name = "lblInventarioValor";
            this.lblInventarioValor.Size = new System.Drawing.Size(52, 34);
            this.lblInventarioValor.TabIndex = 2;
            this.lblInventarioValor.Text = "0 kg";
            // 
            // lblInventarioPeriodo
            // 
            this.lblInventarioPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblInventarioPeriodo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblInventarioPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblInventarioPeriodo.Location = new System.Drawing.Point(60, 80);
            this.lblInventarioPeriodo.Name = "lblInventarioPeriodo";
            this.lblInventarioPeriodo.Size = new System.Drawing.Size(133, 15);
            this.lblInventarioPeriodo.TabIndex = 3;
            this.lblInventarioPeriodo.Text = "Sin periodo seleccionado";
            // 
            // pnlGraficoVentas
            // 
            this.pnlGraficoVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraficoVentas.BorderRadius = 7;
            this.pnlGraficoVentas.Controls.Add(this.lblGraficoVentas);
            this.pnlGraficoVentas.Controls.Add(this.chartVentas);
            this.pnlGraficoVentas.FillColor = System.Drawing.Color.White;
            this.pnlGraficoVentas.Location = new System.Drawing.Point(24, 318);
            this.pnlGraficoVentas.Name = "pnlGraficoVentas";
            this.pnlGraficoVentas.Size = new System.Drawing.Size(960, 230);
            this.pnlGraficoVentas.TabIndex = 8;
            // 
            // lblGraficoVentas
            // 
            this.lblGraficoVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblGraficoVentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGraficoVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblGraficoVentas.Location = new System.Drawing.Point(16, 12);
            this.lblGraficoVentas.Name = "lblGraficoVentas";
            this.lblGraficoVentas.Size = new System.Drawing.Size(113, 19);
            this.lblGraficoVentas.TabIndex = 0;
            this.lblGraficoVentas.Text = "VENTAS POR MES";
            // 
            // chartVentas
            // 
            this.chartVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.BackColor = System.Drawing.Color.White;
            chartArea3.Name = "Ventas";
            this.chartVentas.ChartAreas.Add(chartArea3);
            this.chartVentas.Location = new System.Drawing.Point(12, 38);
            this.chartVentas.Name = "chartVentas";
            series3.ChartArea = "Ventas";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(6)))), ((int)(((byte)(0)))));
            series3.Name = "Ventas";
            this.chartVentas.Series.Add(series3);
            this.chartVentas.Size = new System.Drawing.Size(936, 180);
            this.chartVentas.TabIndex = 1;
            // 
            // pnlGraficoInventario
            // 
            this.pnlGraficoInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraficoInventario.BorderRadius = 7;
            this.pnlGraficoInventario.Controls.Add(this.lblGraficoInventario);
            this.pnlGraficoInventario.Controls.Add(this.chartInventario);
            this.pnlGraficoInventario.FillColor = System.Drawing.Color.White;
            this.pnlGraficoInventario.Location = new System.Drawing.Point(1007, 318);
            this.pnlGraficoInventario.Name = "pnlGraficoInventario";
            this.pnlGraficoInventario.Size = new System.Drawing.Size(337, 230);
            this.pnlGraficoInventario.TabIndex = 9;
            // 
            // lblGraficoInventario
            // 
            this.lblGraficoInventario.BackColor = System.Drawing.Color.Transparent;
            this.lblGraficoInventario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGraficoInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblGraficoInventario.Location = new System.Drawing.Point(16, 12);
            this.lblGraficoInventario.Name = "lblGraficoInventario";
            this.lblGraficoInventario.Size = new System.Drawing.Size(204, 19);
            this.lblGraficoInventario.TabIndex = 0;
            this.lblGraficoInventario.Text = "DISTRIBUCIÓN DEL INVENTARIO";
            // 
            // chartInventario
            // 
            this.chartInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.BackColor = System.Drawing.Color.White;
            chartArea4.Name = "Inventario";
            this.chartInventario.ChartAreas.Add(chartArea4);
            legend2.Name = "Leyenda";
            this.chartInventario.Legends.Add(legend2);
            this.chartInventario.Location = new System.Drawing.Point(12, 38);
            this.chartInventario.Name = "chartInventario";
            series4.ChartArea = "Inventario";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Leyenda";
            series4.Name = "Inventario";
            this.chartInventario.Series.Add(series4);
            this.chartInventario.Size = new System.Drawing.Size(313, 180);
            this.chartInventario.TabIndex = 1;
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetalle.BorderRadius = 7;
            this.pnlDetalle.Controls.Add(this.lblDetalleTitulo);
            this.pnlDetalle.Controls.Add(this.dgvDetalleReporte);
            this.pnlDetalle.Controls.Add(this.lblTotalRegistros);
            this.pnlDetalle.Controls.Add(this.lblValorTotal);
            this.pnlDetalle.FillColor = System.Drawing.Color.White;
            this.pnlDetalle.Location = new System.Drawing.Point(24, 568);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(1320, 260);
            this.pnlDetalle.TabIndex = 10;
            // 
            // lblDetalleTitulo
            // 
            this.lblDetalleTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalleTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDetalleTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblDetalleTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblDetalleTitulo.Name = "lblDetalleTitulo";
            this.lblDetalleTitulo.Size = new System.Drawing.Size(281, 22);
            this.lblDetalleTitulo.TabIndex = 0;
            this.lblDetalleTitulo.Text = "DETALLE DEL REPORTE SELECCIONADO";
            // 
            // dgvDetalleReporte
            // 
            this.dgvDetalleReporte.AllowUserToAddRows = false;
            this.dgvDetalleReporte.AllowUserToDeleteRows = false;
            this.dgvDetalleReporte.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvDetalleReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalleReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvDetalleReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetalleReporte.ColumnHeadersHeight = 38;
            this.dgvDetalleReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleReporte.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetalleReporte.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleReporte.Location = new System.Drawing.Point(16, 42);
            this.dgvDetalleReporte.MultiSelect = false;
            this.dgvDetalleReporte.Name = "dgvDetalleReporte";
            this.dgvDetalleReporte.ReadOnly = true;
            this.dgvDetalleReporte.RowHeadersVisible = false;
            this.dgvDetalleReporte.Size = new System.Drawing.Size(1288, 180);
            this.dgvDetalleReporte.TabIndex = 1;
            this.dgvDetalleReporte.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvDetalleReporte.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dgvDetalleReporte.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDetalleReporte.ThemeStyle.HeaderStyle.Height = 38;
            this.dgvDetalleReporte.ThemeStyle.ReadOnly = true;
            this.dgvDetalleReporte.ThemeStyle.RowsStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dgvDetalleReporte.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDetalleReporte.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvDetalleReporte.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.dgvDetalleReporte.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRegistros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblTotalRegistros.Location = new System.Drawing.Point(16, 231);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(106, 17);
            this.lblTotalRegistros.TabIndex = 2;
            this.lblTotalRegistros.Text = "Total de registros: 0";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblValorTotal.Location = new System.Drawing.Point(1167, 231);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(98, 17);
            this.lblValorTotal.TabIndex = 3;
            this.lblValorTotal.Text = "Valor total: $0,00";
            // 
            // dlgMensajes
            // 
            this.dlgMensajes.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dlgMensajes.Caption = null;
            this.dlgMensajes.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.dlgMensajes.Parent = this;
            this.dlgMensajes.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.dlgMensajes.Text = null;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnlContenido);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1050, 720);
            this.Name = "FormReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DATABEEF - Reportes y Estadísticas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlCompras.ResumeLayout(false);
            this.pnlCompras.PerformLayout();
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            this.pnlGanancia.ResumeLayout(false);
            this.pnlGanancia.PerformLayout();
            this.pnlInventario.ResumeLayout(false);
            this.pnlInventario.PerformLayout();
            this.pnlGraficoVentas.ResumeLayout(false);
            this.pnlGraficoVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            this.pnlGraficoInventario.ResumeLayout(false);
            this.pnlGraficoInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInventario)).EndInit();
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReporte)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
