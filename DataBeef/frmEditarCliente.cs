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
    public partial class frmEditarCliente : Form
    {
        private int idClienteActual;
        public frmEditarCliente(int idCliente)
        {
            InitializeComponent();
            idClienteActual = idCliente;
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            CargarComboTipoIdentificacion();
            CargarComboTipoCliente();
            CargarDatosCliente();
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

        private void CargarDatosCliente()
        {
            csConectaSQL oConexion = new csConectaSQL();

            if (oConexion.abrirConexion())
            {
                try
                {
                    string query = @"SELECT Nombre, Apellido, Identificacion, Email, Telefono, Direccion, 
                                     IdTipoIdentificacion, IdTipoCliente, Estado
                              FROM Clientes
                              WHERE IdClientes = @IdClientes";

                    SqlCommand cmdSQL = new SqlCommand(query, oConexion.oCon);
                    cmdSQL.Parameters.AddWithValue("@IdClientes", idClienteActual);

                    SqlDataReader dr = cmdSQL.ExecuteReader();

                    if (dr.Read())
                    {
                        txtNombre.Text = dr["Nombre"].ToString();
                        txtApellido.Text = dr["Apellido"].ToString();
                        txtNumeroIdentificacion.Text = dr["Identificacion"].ToString();
                        txtEmail.Text = dr["Email"] == DBNull.Value ? "" : dr["Email"].ToString();
                        txtTelefono.Text = dr["Telefono"].ToString();
                        txtDireccion.Text = dr["Direccion"].ToString();

                        cmbTipoIdentificacion.SelectedValue = dr["IdTipoIdentificacion"];
                        cmbTipoCliente.SelectedValue = dr["IdTipoCliente"];

                        bool estado = Convert.ToBoolean(dr["Estado"]);
                        cmbEstadoCliente.SelectedItem = estado ? "Activo" : "Inactivo";
                    }

                    dr.Close();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroIdentificacion.Text) ||
                cmbTipoIdentificacion.SelectedValue == null ||
                cmbTipoCliente.SelectedValue == null ||
                cmbEstadoCliente.SelectedItem == null)
            {
                MessageBox.Show("Por favor complete los campos obligatorios.");
                return;
            }

            csConectaSQL oConexion = new csConectaSQL();

            if (oConexion.abrirConexion())
            {
                try
                {
                    string query = @"UPDATE Clientes SET
                                Nombre = @Nombre,
                                Apellido = @Apellido,
                                Identificacion = @Identificacion,
                                Email = @Email,
                                Telefono = @Telefono,
                                Direccion = @Direccion,
                                IdTipoIdentificacion = @IdTipoIdentificacion,
                                IdTipoCliente = @IdTipoCliente,
                                Estado = @Estado
                              WHERE IdClientes = @IdClientes";

                    SqlCommand cmdSQL = new SqlCommand(query, oConexion.oCon);

                    cmdSQL.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    cmdSQL.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim());
                    cmdSQL.Parameters.AddWithValue("@Identificacion", txtNumeroIdentificacion.Text.Trim());
                    cmdSQL.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim());
                    cmdSQL.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                    cmdSQL.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                    cmdSQL.Parameters.AddWithValue("@IdTipoIdentificacion", cmbTipoIdentificacion.SelectedValue);
                    cmdSQL.Parameters.AddWithValue("@IdTipoCliente", cmbTipoCliente.SelectedValue);
                    cmdSQL.Parameters.AddWithValue("@Estado", cmbEstadoCliente.SelectedItem.ToString() == "Activo" ? 1 : 0);
                    cmdSQL.Parameters.AddWithValue("@IdClientes", idClienteActual);

                    cmdSQL.ExecuteNonQuery();

                    MessageBox.Show("Cliente actualizado correctamente.");
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
