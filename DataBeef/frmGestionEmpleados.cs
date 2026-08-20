using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBeef
{
    public partial class frmGestionEmpleados : Form
    {
        LlamarForm llamada = new LlamarForm();
        public frmGestionEmpleados()
        {
            InitializeComponent();
        }

        private void frmGestionEmpleados_Load(object sender, EventArgs e)
        {
            pnlRegistrar.Visible = false;
            lblEmpleados.BackColor = Color.FromArgb(248, 222, 222);
            lblEmpleados.BorderStyle = BorderStyle.FixedSingle;
            pnlAcciones.Size = new Size(272, 106);
            pnlRegistroEmpleados.Visible = false;
            pnlEditarEmpleados.Visible = false;
            lblAbajo.Visible = false;
            CargarEmpleados();
            cmbRolFiltro.SelectedIndex = 0;
            cmbEstadoFiltro.SelectedIndex = 0;
            FiltrarEmpleados();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            pnlStock.Size = new Size(1600, 1);
            lblAbajo.Visible= true;
        }

        private void lblAbajo_Click(object sender, EventArgs e)
        {
            pnlStock.Size = new Size(1600, 108);
            lblAbajo.Visible = false;

        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            LimpiarFormulariosActivos();
            llamada.AbrirFormulario(new frmRegistrarEmpleado(), pnlRegistroEmpleados);
            pnlRegistroEmpleados.Visible = true;
            pnlEditarEmpleados.Visible = false;
            lblEmpleados.BackColor = Color.FromArgb(240, 240, 240);
            lblEmpleados.BorderStyle = BorderStyle.None;
            pnlRegistrar.Visible = true;
            pnlEditar.Visible = false;
            pnlFiltros.Visible = false;
            pnlGuardar.Visible = false;
            pnlEmpleados.Visible = false;
            pnlAcciones.Size = new Size(192, 110);
            lblNuevoEmpleado.BackColor = Color.FromArgb(248, 222, 222);
            lblNuevoEmpleado.BorderStyle = BorderStyle.FixedSingle;
            lblAcciones.Location = new Point(56, 86);
        }

        private void lblEmpleados_Click(object sender, EventArgs e)
        {
            LimpiarFormulariosActivos();
            pnlEmpleados.Visible = true;
            pnlRegistroEmpleados.Visible = false;
            lblEmpleados.BackColor = Color.FromArgb(248, 222, 222);
            lblEmpleados.BorderStyle = BorderStyle.FixedSingle;
            pnlEditar.Visible = true;
            pnlFiltros.Visible = true;
            pnlGuardar.Visible = true;
            pnlRegistrar.Visible = false; ;
            pnlAcciones.Size = new Size(272, 106);
            lblNuevoEmpleado.BackColor = Color.FromArgb(240, 240, 240);
            lblNuevoEmpleado.BorderStyle = BorderStyle.None;
            lblAcciones.Location = new Point(99, 83);
        }

        private void lblEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un empleado de la lista primero.");
                return;
            }
            pnlRegistroEmpleados.Visible = false;
            pnlEmpleados.Visible = false;
            pnlEditarEmpleados.Visible = true;
            int idEmpleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["IdEmpleado"].Value);

            frmEditarEmpleado frmEditar = new frmEditarEmpleado();
            llamada.AbrirFormulario(frmEditar, pnlEditarEmpleados);
            frmEditar.CargarDatosEmpleado(idEmpleado);
        }

        private void lblEditar_MouseEnter(object sender, EventArgs e)
        {
            lblEditar.BackColor = Color.Gainsboro;
            lblEditar.Size = new Size(63, 57);
            lblEditar.Location = new Point(15, 14);
        }

        private void lblEditar_MouseLeave(object sender, EventArgs e)
        {
            lblEditar.BackColor = Color.FromArgb(240,240,240);
            lblEditar.Size = new Size(63, 52);
            lblEditar.Location = new Point(15, 19);

        }

        //lblRegistrar
        private void lblRegistar_Click(object sender, EventArgs e)
        {
            if (pnlRegistroEmpleados.Tag is frmRegistrarEmpleado frm)
            {
                frm.RegistrarEmpleado();
            }
        }
        private void lblRegistar_MouseEnter(object sender, EventArgs e)
        {
            lblRegistar.BackColor = Color.Gainsboro;
            lblRegistar.Size = new Size(70, 57);
            lblRegistar.Location = new Point(15, 14);
        }

        private void lblRegistar_MouseLeave(object sender, EventArgs e)
        {
            lblRegistar.BackColor = Color.FromArgb(240, 240, 240);
            lblRegistar.Size = new Size(70, 52);
            lblRegistar.Location = new Point(15, 19);
        }

        private void lblGuardar_MouseEnter(object sender, EventArgs e)
        {
            lblGuardar.BackColor = Color.Gainsboro;
            lblGuardar.Size = new Size(63, 57);
            lblGuardar.Location = new Point(15, 14);
        }

        private void lblGuardar_MouseLeave(object sender, EventArgs e)
        {
            lblGuardar.BackColor = Color.FromArgb(240, 240, 240);
            lblGuardar.Size = new Size(63, 52);
            lblGuardar.Location = new Point(15, 19);
        }

        private void lblCancelar_MouseEnter(object sender, EventArgs e)
        {
            lblCancelar.BackColor = Color.Gainsboro;
            lblCancelar.Size = new Size(63, 57);
            lblCancelar.Location = new Point(15, 14);
        }

        private void lblCancelar_MouseLeave(object sender, EventArgs e)
        {
            lblCancelar.BackColor = Color.FromArgb(240, 240, 240);
            lblCancelar.Size = new Size(63, 52);
            lblCancelar.Location = new Point(15, 19);
        }

        private void lblLimpiar_MouseEnter(object sender, EventArgs e)
        {
            lblLimpiar.BackColor = Color.Gainsboro;
            lblLimpiar.Size = new Size(63, 57);
            lblLimpiar.Location = new Point(625, 15);
        }

        private void lblLimpiar_MouseLeave(object sender, EventArgs e)
        {
            lblLimpiar.BackColor = Color.FromArgb(240, 240, 240);
            lblLimpiar.Size = new Size(63, 52);
            lblLimpiar.Location = new Point(625, 20);
        }

        //cargar empleados al datagridview
        private void CargarEmpleados()
        {
            csConectaSQL conexion = new csConectaSQL();

            if (conexion.abrirConexion())
            {
                string query = @"SELECT
                            e.IdEmpleado,
                            e.TipoIdentificacion,
                            e.NumeroIdentificacion,
                            e.Nombre,
                            e.Apellido,
                            e.Email,
                            e.Telefono,
                            r.NombreRol AS Rol,
                            CASE WHEN e.Estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                          FROM Empleados e
                          INNER JOIN Roles r ON e.IdRol = r.IdRol
                          ORDER BY e.Nombre";

                SqlCommand cmd = new SqlCommand(query, conexion.oCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpleados.DataSource = dt;

                conexion.cerrarConexion();
            }
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Text = "";
            cmbRolFiltro.SelectedIndex = 0; 
            cmbEstadoFiltro.SelectedIndex = 0;
        }

        //filtros
        private void FiltrarEmpleados()
        {
            csConectaSQL conexion = new csConectaSQL();

            if (conexion.abrirConexion())
            {
                string query = @"SELECT
                            e.IdEmpleado, e.TipoIdentificacion, e.NumeroIdentificacion,
                            e.Nombre, e.Apellido, e.Email, e.Telefono,
                            r.NombreRol AS Rol,
                            CASE WHEN e.Estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                          FROM Empleados e
                          INNER JOIN Roles r ON e.IdRol = r.IdRol
                          WHERE (@Nombre = '' OR e.Nombre LIKE '%' + @Nombre + '%' OR e.Apellido LIKE '%' + @Nombre + '%')
                            AND (@Rol = 'Todos' OR r.NombreRol = @Rol)
                            AND (@Estado = 'Todos' OR (CASE WHEN e.Estado = 1 THEN 'Activo' ELSE 'Inactivo' END) = @Estado)
                          ORDER BY e.Nombre";

                SqlCommand cmd = new SqlCommand(query, conexion.oCon);
                cmd.Parameters.AddWithValue("@Nombre", txtEmpleado.Text.Trim());
                cmd.Parameters.AddWithValue("@Rol", cmbRolFiltro.Text);
                cmd.Parameters.AddWithValue("@Estado", cmbEstadoFiltro.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpleados.DataSource = dt;

                conexion.cerrarConexion();
            }
        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

        private void cmbRolFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

        private void cmbEstadoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

        private void lblGuardar_Click(object sender, EventArgs e)
        {
            if (pnlEditarEmpleados.Tag is frmEditarEmpleado frm)
            {
                bool exito = frm.ActualizarEmpleado();
                if (exito)
                {
                    FiltrarEmpleados(); 
                }
            }
        }
       

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            if (pnlRegistroEmpleados.Tag is frmRegistrarEmpleado frmNuevo)
            {
                frmNuevo.LimpiarCampos();
            }
            if (pnlEditarEmpleados.Tag is frmEditarEmpleado frmEditar)
            {
                frmEditar.CargarDatosEmpleado(frmEditar.IdEmpleadoActual);
            }
        }

        private void LimpiarFormulariosActivos()
        {
            pnlRegistroEmpleados.Controls.Clear();
            pnlRegistroEmpleados.Tag = null;

            pnlEditarEmpleados.Controls.Clear();
            pnlEditarEmpleados.Tag = null;
        }
    }
}
