using DataBeef;
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

namespace ModuloVentas
{
    public partial class frmRegistrarClientes : Form
    {
        public frmRegistrarClientes()
        {
            InitializeComponent();
        }

        private void frmRegistrarClientes_Load(object sender, EventArgs e)
        {
            CargarComboTipoIdentificacion();
            CargarComboTipoCliente();
        }

        private void CargarComboTipoIdentificacion()
        {
            csConectaSQL oConexion = new csConectaSQL();

            if (oConexion.abrirConexion())
            {
                try
                {
                    string query = "SELECT IdTipoIdentificacion, Nombre FROM TipoIdentificacion";
                    SqlCommand cmdSQL = new SqlCommand(query, oConexion.oCon);
                    SqlDataAdapter da = new SqlDataAdapter(cmdSQL);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbTipoIdentificacion.DataSource = dt;
                    cmbTipoIdentificacion.DisplayMember = "Nombre";
                    cmbTipoIdentificacion.ValueMember = "IdTipoIdentificacion";
                    cmbTipoIdentificacion.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    oConexion.cerrarConexion();
                }
            }
        }

        private void CargarComboTipoCliente()
        {
            csConectaSQL oConexion = new csConectaSQL();

            if (oConexion.abrirConexion())
            {
                try
                {
                    string query = "SELECT IdTipoCliente, Nombre FROM TipoCliente";
                    SqlCommand cmdSQL = new SqlCommand(query, oConexion.oCon);
                    SqlDataAdapter da = new SqlDataAdapter(cmdSQL);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbTipoCliente.DataSource = dt;
                    cmbTipoCliente.DisplayMember = "Nombre";
                    cmbTipoCliente.ValueMember = "IdTipoCliente";
                    cmbTipoCliente.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    oConexion.cerrarConexion();
                }
            }
        }

        //registro de los clientes 
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroIdentificacion.Text) ||
                cmbTipoIdentificacion.SelectedValue == null ||
                cmbTipoCliente.SelectedValue == null)
            {
                MessageBox.Show("Por favor complete los campos.");
                return;
            }

            csConectaSQL oConexion = new csConectaSQL();

            if (oConexion.abrirConexion())
            {
                try
                {
                    string query = @"INSERT INTO Clientes 
                                (Nombre, Apellido, Identificacion, Email, Telefono, Direccion, IdTipoIdentificacion, IdTipoCliente)
                              VALUES 
                                (@Nombre, @Apellido, @Identificacion, @Email, @Telefono, @Direccion, @IdTipoIdentificacion, @IdTipoCliente)";

                    SqlCommand cmdSQL = new SqlCommand(query, oConexion.oCon);

                    cmdSQL.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    cmdSQL.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim());
                    cmdSQL.Parameters.AddWithValue("@Identificacion", txtNumeroIdentificacion.Text.Trim());
                    cmdSQL.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim());
                    cmdSQL.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                    cmdSQL.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                    cmdSQL.Parameters.AddWithValue("@IdTipoIdentificacion", cmbTipoIdentificacion.SelectedValue);
                    cmdSQL.Parameters.AddWithValue("@IdTipoCliente", cmbTipoCliente.SelectedValue);

                    cmdSQL.ExecuteNonQuery();

                    MessageBox.Show("Cliente registrado correctamente.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    oConexion.cerrarConexion();
                }
            }
        }
    }
    
}
