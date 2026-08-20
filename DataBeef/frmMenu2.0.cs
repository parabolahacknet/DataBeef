using DataBeef;
using InventarioLospulpos;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Menú
{
    public partial class frmMenu2 : Form
    {
        

        LlamarForm llamada = new LlamarForm();

        public frmMenu2()
        {
            InitializeComponent();
            AbrirFormulario(new frmGestionProovedores());
        }

        //metodo para reusar codigo en cambiar color de los lbl de los modulos
        static void CambiaColorfondo(Label uno, Label dos, Label tres, Label cuatro, Label cinco, Label seis)
        { 
            uno.ForeColor = Color.FromArgb(200, 0, 0);
            uno.BackColor = Color.FromArgb(248, 222, 222);
            dos.ForeColor = Color.Black;
            dos.BackColor = Color.White;
            tres.ForeColor = Color.Black;
            tres.BackColor = Color.White;
            cuatro.ForeColor = Color.Black;
            cuatro.BackColor = Color.White;
            cinco.ForeColor = Color.Black;
            cinco.BackColor = Color.White;
            seis.ForeColor = Color.Black;
            seis.BackColor = Color.White;
            
        }


        static void MostrarRaya(Label uno, Label dos, Label tres, Label cuatro, Label cinco, Label seis)
        {
            uno.Visible = true;
            dos.Visible = false;
            tres.Visible = false;
            cuatro.Visible = false;
            cinco.Visible = false;
            seis.Visible = false;
        }

        private void lblCompras_Click(object sender, EventArgs e)
        {
            CambiaColorfondo(lblCompras, lblInventario, lblVentas, lblTrazabilidad, lblReportes, lblEmpleados);
            MostrarRaya(lblRayaCom, lblRayaInv, lblRayaVen, lblRayaTra, lblRayaRep, lblRayaEmp);
            AbrirFormulario(new frmGestionProovedores());
        }

        private void lblInventario_Click(object sender, EventArgs e)
        {
            CambiaColorfondo(lblInventario, lblCompras, lblVentas, lblTrazabilidad, lblReportes, lblEmpleados);
            MostrarRaya(lblRayaInv, lblRayaCom, lblRayaVen, lblRayaTra, lblRayaRep, lblRayaEmp);
            AbrirFormulario(new Faenamiento());
        }

        private void lblVentas_Click(object sender, EventArgs e)
        {
            CambiaColorfondo(lblVentas, lblCompras, lblInventario, lblTrazabilidad, lblReportes, lblEmpleados);
            MostrarRaya(lblRayaVen, lblRayaCom, lblRayaInv, lblRayaTra, lblRayaRep, lblRayaEmp);
            AbrirFormulario(new frmRegistrarVenta());

        }

        private void lblTrazabilidad_Click(object sender, EventArgs e)
        {
            CambiaColorfondo(lblTrazabilidad, lblCompras, lblInventario, lblVentas, lblReportes, lblEmpleados);
            MostrarRaya(lblRayaTra, lblRayaCom, lblRayaInv, lblRayaVen, lblRayaRep, lblRayaEmp);
            AbrirFormulario(new fmTrazabilidad());
        }

        private void lblReportes_Click(object sender, EventArgs e)
        {
            CambiaColorfondo(lblReportes, lblCompras, lblInventario, lblVentas, lblTrazabilidad, lblEmpleados);
            MostrarRaya(lblRayaRep, lblRayaCom, lblRayaInv, lblRayaVen, lblRayaTra, lblRayaEmp);
            AbrirFormulario(new frmReportes());
        }

        private void lblEmpleados_Click(object sender, EventArgs e)
        {
            CambiaColorfondo(lblEmpleados, lblCompras, lblInventario, lblVentas, lblTrazabilidad, lblReportes);
            MostrarRaya(lblRayaEmp, lblRayaCom, lblRayaInv, lblRayaVen, lblRayaTra, lblRayaRep);
            AbrirFormulario(new frmGestionEmpleados());
        }


        private Form formularioActivo = null;

        public void AbrirFormulario(Form formularioHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formularioHijo;

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            formularioHijo.MinimumSize = System.Drawing.Size.Empty;
            formularioHijo.MaximumSize = System.Drawing.Size.Empty;

            pnlContenido.Controls.Clear();
            pnlContenido.Controls.Add(formularioHijo);
            pnlContenido.Tag = formularioHijo;

            formularioHijo.Show();
        }

        private void frmMenu2_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = UsuarioActual.Nombre;
        }

        // Matar el proceso del prograna
        private bool exiting = false;
        private void frmMenu2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exiting)
            {
                exiting = true;
                // Intentamos cerrar de forma segura todos los formularios abiertos (incluido InicioSesion oculto
                // y los formularios embebidos en el panel). Usamos ToArray() para evitar InvalidOperationException
                // por modificación de la colección mientras la recorremos.
                this.BeginInvoke((MethodInvoker)(() =>
                {
                    try
                    {
                        var abiertos = Application.OpenForms.Cast<Form>().ToArray();
                        foreach (var f in abiertos)
                        {
                            // Saltar este formulario porque ya se está cerrando
                            if (object.ReferenceEquals(f, this))
                                continue;

                            try
                            {
                                f.Close();
                            }
                            catch
                            {
                                // ignorar excepciones al cerrar formularios individuales
                            }
                        }
                    }
                    finally
                    {
                        // Forzamos la salida como fallback
                        try { Application.Exit(); } catch { Environment.Exit(0); }
                    }
                }));
            }

        }

        private void frmMenu2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Terminación forzada del proceso como último recurso para asegurar que la aplicación no quede viva
            try
            {
                Environment.Exit(0);
            }
            catch
            {
                // ignorar cualquier error en la terminación
            }
        }
    }
}
