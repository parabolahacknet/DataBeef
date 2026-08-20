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
    public partial class frmEditarEmpleado : Form
    {
        private int idEmpleadoEditar;
        public int IdEmpleadoActual => idEmpleadoEditar;
        public frmEditarEmpleado()
        {
            InitializeComponent();
        }

        private void frmEditarEmpleado_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void CargarRoles()
        {
            csConectaSQL conexion = new csConectaSQL();
            if (conexion.abrirConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdRol, NombreRol FROM Roles ORDER BY NombreRol", conexion.oCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbRol.DataSource = dt;
                cmbRol.DisplayMember = "NombreRol";
                cmbRol.ValueMember = "IdRol";

                conexion.cerrarConexion();
            }
        }

        public void CargarDatosEmpleado(int idEmpleado)
        {
            idEmpleadoEditar = idEmpleado;

            csConectaSQL conexion = new csConectaSQL();
            if (conexion.abrirConexion())
            {
                string query = "SELECT * FROM Empleados WHERE IdEmpleado = @IdEmpleado";
                SqlCommand cmd = new SqlCommand(query, conexion.oCon);
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombre.Text = dr["Nombre"].ToString();
                    txtApellido.Text = dr["Apellido"].ToString();
                    cmbTipoIdentificacion.Text = dr["TipoIdentificacion"].ToString();
                    txtNumeroIdentificacion.Text = dr["NumeroIdentificacion"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    txtTelefono.Text = dr["Telefono"].ToString();
                    txtDireccion.Text = dr["Direccion"].ToString();
                    cmbRol.SelectedValue = dr["IdRol"];
                    cmbEstado.Text = (bool)dr["Estado"] ? "Activo" : "Inactivo";
                }

                conexion.cerrarConexion();
            }
        }

        public bool ActualizarEmpleado()
        {
            csConectaSQL conexion = new csConectaSQL();
            if (conexion.abrirConexion())
            {
                try
                {
                    string query;

                    if (txtContrasena.Text.Trim() == "")
                    {
                        query = @"UPDATE Empleados SET
                            TipoIdentificacion = @TipoIdentificacion,
                            NumeroIdentificacion = @NumeroIdentificacion,
                            Nombre = @Nombre, Apellido = @Apellido,
                            Email = @Email, Telefono = @Telefono, Direccion = @Direccion,
                            IdRol = @IdRol, Estado = @Estado
                          WHERE IdEmpleado = @IdEmpleado";
                    }
                    else
                    {
                        if (txtContrasena.Text != txtConfirmarContrasena.Text)
                        {
                            MessageBox.Show("Las contraseñas no coinciden.");
                            return false;
                        }

                        query = @"UPDATE Empleados SET
                            TipoIdentificacion = @TipoIdentificacion,
                            NumeroIdentificacion = @NumeroIdentificacion,
                            Nombre = @Nombre, Apellido = @Apellido,
                            Email = @Email, Telefono = @Telefono, Direccion = @Direccion,
                            IdRol = @IdRol, Estado = @Estado, PasswordHash = @PasswordHash
                          WHERE IdEmpleado = @IdEmpleado";
                    }

                    SqlCommand cmd = new SqlCommand(query, conexion.oCon);
                    cmd.Parameters.AddWithValue("@TipoIdentificacion", cmbTipoIdentificacion.Text);
                    cmd.Parameters.AddWithValue("@NumeroIdentificacion", txtNumeroIdentificacion.Text.Trim());
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                    cmd.Parameters.AddWithValue("@IdRol", cmbRol.SelectedValue);
                    cmd.Parameters.AddWithValue("@Estado", cmbEstado.Text == "Activo" ? 1 : 0);
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleadoEditar);

                    if (txtContrasena.Text.Trim() != "")
                    {
                        cmd.Parameters.AddWithValue("@PasswordHash", txtContrasena.Text);
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empleado actualizado con éxito.");
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                    return false;
                }
                finally
                {
                    conexion.cerrarConexion();
                }
            }
            return false;
        }
    }
}
