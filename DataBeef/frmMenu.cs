using Control_de_inventario;
using ModuloVentas;
using DataBeef;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MenuPrincipal
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        this.Resize += FrmMenu_Resize;
        this.FormClosed += FrmMenu_FormClosed;
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
            btnCompras.BackColor = Color.White;
            bntCrtInventario.BackColor = Color.White;
            btnReportes.BackColor = Color.White;
        }

        private void btnTrazabilidad_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new fmTrazabilidad());

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

            btnCompras.BackColor = Color.White;
            bntCrtInventario.BackColor = Color.White;
            btnVentas.BackColor = Color.White;
            btnReportes.BackColor = Color.White;
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            if (formularioActivo == null) return;

            if (this.WindowState == FormWindowState.Minimized)
            {
                // Ocultar el panel de contenido para evitar que el formulario hijo quede "recortado"
                pnlContenido.Visible = false;
            }
            else
            {
                // Restaurar y forzar re-ajuste del formulario hijo dentro del panel
                pnlContenido.Visible = true;

                try
                {
                    // Asegurar que el formulario hijo esté correctamente anclado al panel
                    formularioActivo.TopLevel = false;
                    formularioActivo.FormBorderStyle = FormBorderStyle.None;
                    formularioActivo.Dock = DockStyle.Fill;

                    if (!pnlContenido.Controls.Contains(formularioActivo))
                    {
                        pnlContenido.Controls.Clear();
                        pnlContenido.Controls.Add(formularioActivo);
                    }

                    formularioActivo.Show();
                    formularioActivo.BringToFront();
                    // Forzar tamaño del formulario hijo al tamaño cliente del panel
                    formularioActivo.Size = pnlContenido.ClientSize;
                    pnlContenido.PerformLayout();
                    formularioActivo.Refresh();
                }
                catch
                {
                    // No propagar excepciones de UI aquí; en caso de fallo, intentar una reconstrucción mínima
                    pnlContenido.Controls.Clear();
                }
            }
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Posponer la salida para evitar modificar colecciones mientras se enumeran
            // Usar Environment.Exit para garantizar la terminación completa del proceso
            this.BeginInvoke((MethodInvoker)(() => Environment.Exit(0)));
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new fmReportes());

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

                btnCompras.BackColor = Color.White;
                bntCrtInventario.BackColor = Color.White;
                btnVentas.BackColor = Color.White;
                btnTrazabilidad.BackColor = Color.White;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnCompras.BackColor = Color.White;
            bntCrtInventario.BackColor = Color.White;
            btnVentas.BackColor = Color.White;
            btnTrazabilidad.BackColor = Color.White;
            btnReportes.BackColor = Color.White;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProveedores());
            pnlOpCompras.Visible = true;
            btnCompras.BackColor = Color.FromArgb(255, 200, 200);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmClientes());
        }

        private Form formularioActivo = null;

        private void AbrirFormulario(Form formularioHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formularioHijo;

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Evitar que mínimas restricciones del formulario hijo impidan el ajuste en el panel
            formularioHijo.MinimumSize = System.Drawing.Size.Empty;
            formularioHijo.MaximumSize = System.Drawing.Size.Empty;
            formularioHijo.Size = pnlContenido.ClientSize;

            pnlContenido.Controls.Clear();
            pnlContenido.Controls.Add(formularioHijo);
            pnlContenido.Tag = formularioHijo;

            formularioHijo.Show();
        }

        private void btnFaenamiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmFaenamiento());

        }
        private void btnDesposte_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDesposte());

        }
        private void btnEmpaque_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEmpaque());

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmFacturacion());

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProveedores());

        }

        private void btnCompraGanado_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRecepcionCompras());

        }

        private void btnRegVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRegistroVentas());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioSesion login = new InicioSesion();
            login.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRegistrarCuenta());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new fmReportes());
        }
    }
}
