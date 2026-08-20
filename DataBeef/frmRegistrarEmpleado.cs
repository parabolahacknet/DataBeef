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
    public partial class frmRegistrarEmpleado : Form
    {
        public frmRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void frmRegistrarEmpleado_Load(object sender, EventArgs e)
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

        public void RegistrarEmpleado()
        {
            if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }
            if (txtContrasena.Text == "" || txtConfirmarContrasena.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
            if (txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
            if (cmbTipoIdentificacion.Text == "" || txtNumeroIdentificacion.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
            if (txtEmail.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
            if (txtDireccion.Text == "" || cmbRol.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            csConectaSQL conexion = new csConectaSQL();

            if (conexion.abrirConexion())
            {
                try
                {
                    string query = @"INSERT INTO Empleados
                (TipoIdentificacion, NumeroIdentificacion, Nombre, Apellido, Email, Telefono, Direccion, IdRol, PasswordHash)
                VALUES (@TipoIdentificacion, @NumeroIdentificacion, @Nombre, @Apellido, @Email, @Telefono, @Direccion, @IdRol, @PasswordHash)";

                    SqlCommand cmd = new SqlCommand(query, conexion.oCon);
                    cmd.Parameters.AddWithValue("@TipoIdentificacion", cmbTipoIdentificacion.Text);
                    cmd.Parameters.AddWithValue("@NumeroIdentificacion", txtNumeroIdentificacion.Text.Trim());
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                    cmd.Parameters.AddWithValue("@IdRol", cmbRol.SelectedValue);
                    cmd.Parameters.AddWithValue("@PasswordHash", txtContrasena.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empleado registrado con éxito.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al registrar: " + ex.Message);
                }
                finally
                {
                    conexion.cerrarConexion();
                }
            }
        }

       

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNumeroIdentificacion.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtContrasena.Text = "";
            txtConfirmarContrasena.Text = "";
            cmbTipoIdentificacion.SelectedIndex = -1;
            cmbRol.SelectedIndex = -1;
        }
    }
}
