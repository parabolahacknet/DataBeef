using Reportes_y_estadisticas_DATABEEF.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataBeef
{
    public partial class fmReportes : Form
    {
        private readonly ReporteDatosSimulados servicioDatos = new ReporteDatosSimulados();
        private ResumenReporte reporteActual;

        public fmReportes()
        {
            InitializeComponent();
            ConfigurarInterfaz();
            CargarTiposReporte();
            LimpiarReporte();
        }

        private void ConfigurarInterfaz()
        {
            dtpFechaHasta.Value = DateTime.Today;
            dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            ConfigurarChartVentas();
            ConfigurarChartInventario();
        }

        private void CargarTiposReporte()
        {
            cmbTipoReporte.Items.AddRange(new object[]
            {
                "Ventas", "Compras", "Inventario", "Producción", "Mermas y rendimiento",
                "Trazabilidad por lote", "Productos próximos a vencer"
            });
            cmbTipoReporte.SelectedIndex = -1;
        }

        private bool ValidarFiltros()
        {
            if (dtpFechaDesde.Value.Date > dtpFechaHasta.Value.Date)
            {
                MostrarMensaje("La fecha inicial no puede ser mayor que la fecha final.", "Fechas no válidas", Guna.UI2.WinForms.MessageDialogIcon.Warning);
                dtpFechaDesde.Focus();
                return false;
            }
            if (cmbTipoReporte.SelectedIndex < 0)
            {
                MostrarMensaje("Seleccione un tipo de reporte antes de continuar.", "Tipo de reporte requerido", Guna.UI2.WinForms.MessageDialogIcon.Warning);
                cmbTipoReporte.Focus();
                return false;
            }
            return true;
        }

        private void GenerarReporte()
        {
            if (!ValidarFiltros()) return;
            try
            {
                reporteActual = servicioDatos.Obtener(cmbTipoReporte.Text, dtpFechaDesde.Value.Date, dtpFechaHasta.Value.Date);
                ConfigurarColumnasReporte();
                CargarIndicadores();
                CargarGraficos();
                CargarDetalleReporte();
                btnExportarPdf.Enabled = true;
                btnExportarExcel.Enabled = true;
            }
            catch (Exception ex)
            {
                LimpiarReporte();
                MostrarMensaje("No fue posible generar el reporte. " + ex.Message, "Error", Guna.UI2.WinForms.MessageDialogIcon.Error);
            }
        }

        private void ConfigurarColumnasReporte()
        {
            dgvDetalleReporte.DataSource = null;
            dgvDetalleReporte.Columns.Clear();
        }

        private void CargarIndicadores()
        {
            string periodo = string.Format("{0:dd/MM/yyyy} – {1:dd/MM/yyyy}", dtpFechaDesde.Value, dtpFechaHasta.Value);
            lblComprasValor.Text = reporteActual.Compras.ToString("C2", CultureInfo.GetCultureInfo("es-EC"));
            lblVentasValor.Text = reporteActual.Ventas.ToString("C2", CultureInfo.GetCultureInfo("es-EC"));
            lblGananciaValor.Text = reporteActual.Ganancia.ToString("C2", CultureInfo.GetCultureInfo("es-EC"));
            lblInventarioValor.Text = reporteActual.Inventario.ToString("N0") + " kg";
            lblComprasPeriodo.Text = lblVentasPeriodo.Text = lblGananciaPeriodo.Text = lblInventarioPeriodo.Text = periodo;
        }

        private void CargarGraficos()
        {
            chartVentas.Series[0].Points.Clear();
            foreach (KeyValuePair<string, decimal> item in reporteActual.VentasMensuales)
                chartVentas.Series[0].Points.AddXY(item.Key, item.Value);

            chartInventario.Series[0].Points.Clear();
            foreach (KeyValuePair<string, decimal> item in reporteActual.DistribucionInventario)
                chartInventario.Series[0].Points.AddXY(item.Key, item.Value);
        }

        private void CargarDetalleReporte()
        {
            dgvDetalleReporte.DataSource = reporteActual.Detalle;
            int registros = reporteActual.Detalle == null ? 0 : reporteActual.Detalle.Rows.Count;
            lblTotalRegistros.Text = "Total de registros: " + registros;
            lblValorTotal.Text = reporteActual.Detalle != null && reporteActual.Detalle.Columns.Contains("Total")
                ? "Valor total: " + reporteActual.ValorTotal.ToString("C2", CultureInfo.GetCultureInfo("es-EC"))
                : "Valor total: No aplica";
            if (registros == 0)
                MostrarMensaje("No existen resultados para los filtros seleccionados.", "Sin resultados", Guna.UI2.WinForms.MessageDialogIcon.Information);
        }

        private void ExportarPdf()
        {
            if (reporteActual == null) return;
            using (var dialogo = new SaveFileDialog { Filter = "Documento PDF (*.pdf)|*.pdf", FileName = "Reporte_DATABEEF.pdf" })
            {
                if (dialogo.ShowDialog(this) != DialogResult.OK) return;
                PdfSimple.Escribir(dialogo.FileName, cmbTipoReporte.Text, dtpFechaDesde.Value, dtpFechaHasta.Value, reporteActual.Detalle);
                MostrarMensaje("El reporte PDF se exportó correctamente.", "Exportación completada", Guna.UI2.WinForms.MessageDialogIcon.Information);
            }
        }

        private void ExportarExcel()
        {
            if (reporteActual == null) return;
            using (var dialogo = new SaveFileDialog { Filter = "Archivo CSV compatible con Excel (*.csv)|*.csv", FileName = "Reporte_DATABEEF.csv" })
            {
                if (dialogo.ShowDialog(this) != DialogResult.OK) return;
                var sb = new StringBuilder();
                DataTable tabla = reporteActual.Detalle;
                sb.AppendLine(string.Join(";", tabla.Columns.Cast<DataColumn>().Select(c => Csv(c.ColumnName))));
                foreach (DataRow fila in tabla.Rows)
                    sb.AppendLine(string.Join(";", fila.ItemArray.Select(v => Csv(Convert.ToString(v, CultureInfo.CurrentCulture)))));
                File.WriteAllText(dialogo.FileName, sb.ToString(), new UTF8Encoding(true));
                MostrarMensaje("El archivo compatible con Excel se exportó correctamente.", "Exportación completada", Guna.UI2.WinForms.MessageDialogIcon.Information);
            }
        }

        private static string Csv(string value) { return "\"" + (value ?? string.Empty).Replace("\"", "\"\"") + "\""; }

        private void LimpiarReporte()
        {
            reporteActual = null;
            dgvDetalleReporte.DataSource = null;
            dgvDetalleReporte.Columns.Clear();
            lblTotalRegistros.Text = "Total de registros: 0";
            lblValorTotal.Text = "Valor total: $0,00";
            lblComprasValor.Text = lblVentasValor.Text = lblGananciaValor.Text = "$0,00";
            lblInventarioValor.Text = "0 kg";
            lblComprasPeriodo.Text = lblVentasPeriodo.Text = lblGananciaPeriodo.Text = lblInventarioPeriodo.Text = "Sin periodo seleccionado";
            btnExportarPdf.Enabled = false;
            btnExportarExcel.Enabled = false;
            if (chartVentas.Series.Count > 0) chartVentas.Series[0].Points.Clear();
            if (chartInventario.Series.Count > 0) chartInventario.Series[0].Points.Clear();
        }

        private void ConfigurarChartVentas()
        {
            chartVentas.ChartAreas.Clear(); chartVentas.Series.Clear(); chartVentas.Legends.Clear();
            var area = new ChartArea("Ventas") { BackColor = Color.White };
            area.AxisX.MajorGrid.Enabled = false; area.AxisY.MajorGrid.LineColor = Color.FromArgb(235, 235, 235);
            area.AxisX.LabelStyle.ForeColor = Color.FromArgb(100, 100, 100); area.AxisY.LabelStyle.ForeColor = Color.FromArgb(100, 100, 100);
            chartVentas.ChartAreas.Add(area);
            var serie = new Series("Ventas") { ChartType = SeriesChartType.Column, Color = Color.FromArgb(225, 6, 0), IsValueShownAsLabel = true, Font = new Font("Segoe UI", 8F) };
            chartVentas.Series.Add(serie);
        }

        private void ConfigurarChartInventario()
        {
            chartInventario.ChartAreas.Clear(); chartInventario.Series.Clear(); chartInventario.Legends.Clear();
            chartInventario.ChartAreas.Add(new ChartArea("Inventario") { BackColor = Color.White });
            chartInventario.Legends.Add(new Legend("Leyenda") { Docking = Docking.Right, Font = new Font("Segoe UI", 8F) });
            var serie = new Series("Inventario") { ChartType = SeriesChartType.Doughnut, IsValueShownAsLabel = true, Label = "#PERCENT{P0}", LegendText = "#VALX" };
            serie.Palette = ChartColorPalette.None;
            serie.Points.DataBindXY(new string[0], new decimal[0]);
            chartInventario.Series.Add(serie);
            chartInventario.PaletteCustomColors = new[] { Color.FromArgb(225, 6, 0), Color.FromArgb(55, 55, 55), Color.FromArgb(145, 145, 145), Color.FromArgb(210, 210, 210) };
        }

        private void MostrarMensaje(string mensaje, string titulo, Guna.UI2.WinForms.MessageDialogIcon icono)
        { dlgMensajes.Caption = titulo; dlgMensajes.Text = mensaje; dlgMensajes.Icon = icono; dlgMensajes.Show(); }

        private void btnGenerarReporte_Click(object sender, EventArgs e) { GenerarReporte(); }
        private void btnExportarPdf_Click(object sender, EventArgs e) { ExportarPdf(); }
        private void btnExportarExcel_Click(object sender, EventArgs e) { ExportarExcel(); }
    }

    internal static class PdfSimple
    {
        public static void Escribir(string ruta, string tipo, DateTime desde, DateTime hasta, DataTable tabla)
        {
            var lineas = new List<string> { "DATABEEF - REPORTE DE " + tipo.ToUpperInvariant(), "Periodo: " + desde.ToString("dd/MM/yyyy") + " - " + hasta.ToString("dd/MM/yyyy"), "" };
            lineas.Add(string.Join(" | ", tabla.Columns.Cast<DataColumn>().Select(c => c.ColumnName)));
            foreach (DataRow fila in tabla.Rows) lineas.Add(string.Join(" | ", fila.ItemArray.Select(v => Convert.ToString(v))));
            var contenido = new StringBuilder("BT /F1 9 Tf 40 800 Td 12 TL ");
            foreach (string linea in lineas.Take(48)) contenido.Append("(").Append(Escapar(linea)).Append(") Tj T* ");
            contenido.Append("ET");
            string stream = contenido.ToString();
            string[] objetos = {
                "<< /Type /Catalog /Pages 2 0 R >>",
                "<< /Type /Pages /Kids [3 0 R] /Count 1 >>",
                "<< /Type /Page /Parent 2 0 R /MediaBox [0 0 595 842] /Resources << /Font << /F1 5 0 R >> >> /Contents 4 0 R >>",
                "<< /Length " + Encoding.ASCII.GetByteCount(stream) + " >>\nstream\n" + stream + "\nendstream",
                "<< /Type /Font /Subtype /Type1 /BaseFont /Helvetica >>"
            };
            using (var fs = new FileStream(ruta, FileMode.Create, FileAccess.Write))
            using (var w = new StreamWriter(fs, Encoding.ASCII))
            {
                w.NewLine = "\n"; w.Write("%PDF-1.4\n"); w.Flush(); var offsets = new List<long> { 0 };
                for (int i = 0; i < objetos.Length; i++) { offsets.Add(fs.Position); w.Write((i + 1) + " 0 obj\n" + objetos[i] + "\nendobj\n"); w.Flush(); }
                long xref = fs.Position; w.Write("xref\n0 " + (objetos.Length + 1) + "\n0000000000 65535 f \n");
                for (int i = 1; i < offsets.Count; i++) w.Write(offsets[i].ToString("0000000000") + " 00000 n \n");
                w.Write("trailer << /Size " + (objetos.Length + 1) + " /Root 1 0 R >>\nstartxref\n" + xref + "\n%%EOF");
            }
        }
        private static string Escapar(string value) { return new string((value ?? "").Select(c => c < 128 ? c : '?').ToArray()).Replace("\\", "\\\\").Replace("(", "\\(").Replace(")", "\\)"); }
    }
}
