using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBeef
{
    public partial class fmMenu : Form
    {
        private Form formularioActual;

        private void MostrarEnTlp(Form f)
        {
            // Cerrar y eliminar el formulario actual si existe
            if (formularioActual != null)
            {
                try
                {
                    formularioActual.Close();
                    formularioActual.Dispose();
                }
                catch { }
                formularioActual = null;
            }

            formularioActual = f;
            formularioActual.TopLevel = false;
            formularioActual.FormBorderStyle = FormBorderStyle.None;
            formularioActual.Dock = DockStyle.Fill;

            // Limpiar la celda del TableLayoutPanel y añadir el nuevo formulario
            tlpSecundarioDerecho.Controls.Clear();
            tlpSecundarioDerecho.Controls.Add(formularioActual, 0, 0);

            formularioActual.Show();
        }
        public fmMenu()
        {
            InitializeComponent();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            if (!pnlOpCompras.Visible)
            {
                pnlOpCompras.Visible = true;
                btnCompras.BackColor = Color.FromArgb(255, 200, 200);
            }
            else
            { 
                pnlOpCompras.Visible = false;
                btnCompras.BackColor = Color.White;
            }

            bntCrtInventario.BackColor = Color.White;
            btnVentas.BackColor = Color.White;
            btnTrazabilidad.BackColor = Color.White;
            btnDashboard.BackColor = Color.White;
            btnReportes.BackColor = Color.White;
        }

        private void bntCrtInventario_Click(object sender, EventArgs e)
        {
            if (!pnlOpInventario.Visible)
            {
                pnlOpInventario.Visible = true;
                bntCrtInventario.BackColor = Color.FromArgb(255, 200, 200);
            }
            else
            { 
                pnlOpInventario.Visible = false;
                bntCrtInventario.BackColor = Color.White;
            }

            btnVentas.BackColor = Color.White;
            btnTrazabilidad.BackColor = Color.White;
            btnDashboard.BackColor = Color.White;
            btnCompras.BackColor = Color.White;
            btnReportes.BackColor = Color.White;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (!pnlOpVentas.Visible)
            {
                pnlOpVentas.Visible = true;
                btnVentas.BackColor = Color.FromArgb(255, 200, 200);
            }
            else
            { 
                pnlOpVentas.Visible = false;
                btnVentas.BackColor = Color.White;
            }

            btnTrazabilidad.BackColor = Color.White;
            btnDashboard.BackColor = Color.White;
            btnCompras.BackColor = Color.White;
            bntCrtInventario.BackColor = Color.White;
            btnReportes.BackColor = Color.White;
        }

        private void btnTrazabilidad_Click(object sender, EventArgs e)
        {
            if (!pnlOpTrazabilidad.Visible)
            {
                pnlOpTrazabilidad.Visible = true;
                btnTrazabilidad.BackColor = Color.FromArgb(255, 200, 200);
            }
            else
            { 
                pnlOpTrazabilidad.Visible = false;
                btnTrazabilidad.BackColor = Color.White;
            }

            btnDashboard.BackColor = Color.White;
            btnCompras.BackColor = Color.White;
            bntCrtInventario.BackColor = Color.White;
            btnVentas.BackColor = Color.White;
            btnReportes.BackColor = Color.White;
            // Mostrar el formulario de trazabilidad en el panel derecho
            try
            {
                MostrarEnTlp(new fmTrazabilidad());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar fmTrazabilidad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (!pnlOpReportes.Visible)
            { 
                pnlOpReportes.Visible = true;
                btnReportes.BackColor = Color.FromArgb(255, 200, 200);
            }
            else
            { 
                pnlOpReportes.Visible = false;
                btnReportes.BackColor = Color.White;
            }

                btnDashboard.BackColor = Color.White;
                btnCompras.BackColor = Color.White;
                bntCrtInventario.BackColor = Color.White;
                btnVentas.BackColor = Color.White;
                btnTrazabilidad.BackColor = Color.White;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(255, 200, 200);
            btnCompras.BackColor = Color.White;
            bntCrtInventario.BackColor = Color.White;
            btnVentas.BackColor = Color.White;
            btnTrazabilidad.BackColor = Color.White;
            btnReportes.BackColor = Color.White;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(255, 200, 200);
        }
    }
}
