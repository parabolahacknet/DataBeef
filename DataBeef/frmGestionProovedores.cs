using Menú;
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
    public partial class frmGestionProovedores : Form
    {
        private DataTable dtProveedores;
        private DataTable dtProveedoresOriginal;
        private int idProveedorActual = 0;

        public frmGestionProovedores()
        {
            InitializeComponent();
        }

        private void lblArriba_Click(object sender, EventArgs e)
        {
            pnlStock.Size = new Size(1600, 1);
            lblBajar.Visible = true;
        }

        private void lblBajar_Click(object sender, EventArgs e)
        {
            pnlStock.Size = new Size(1600, 108);
            lblBajar.Visible = false;
        }

        private void lblCompras_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new frmRecepcionCompras());
            }
        }

        private void frmGestionProovedores_Load(object sender, EventArgs e)
        {
            CargarComboTipoIdentificacion();
            CargarComboTipoProveedor();
            CargarProveedores();
            ActualizarLabels();
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

        private void CargarComboTipoProveedor()
        {
            csConectaSQL oConexion = new csConectaSQL();

            if (oConexion.abrirConexion())
            {
                try
                {
                    string query = "SELECT IdTipoProveedor, Nombre FROM TipoProveedor";
                    SqlCommand cmdSQL = new SqlCommand(query, oConexion.oCon);
                    SqlDataAdapter da = new SqlDataAdapter(cmdSQL);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbTipoProveedor.DataSource = dt;
                    cmbTipoProveedor.DisplayMember = "Nombre";
                    cmbTipoProveedor.ValueMember = "IdTipoProveedor";
                    cmbTipoProveedor.SelectedIndex = -1;
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
    

    private void CargarProveedores()
        {
            csConectaSQL oConexion = new csConectaSQL();

            if (oConexion.abrirConexion())
            {
                try
                {
                    string query = @"SELECT 
                                Proveedores.IdProveedor,
                                Proveedores.CodigoProveedor AS Código,
                                Proveedores.NombreProveedor AS Nombre,
                                Proveedores.NumeroIdentificacion AS Identificación,
                                Proveedores.Telefono,
                                Proveedores.Correo,
                                TipoProveedor.Nombre AS TipoProveedor,
                                Proveedores.Estado
                              FROM Proveedores
                              INNER JOIN TipoIdentificacion ON Proveedores.IdTipoIdentificacion = TipoIdentificacion.IdTipoIdentificacion
                              INNER JOIN TipoProveedor ON Proveedores.IdTipoProveedor = TipoProveedor.IdTipoProveedor";

                    SqlCommand cmdSQL = new SqlCommand(query, oConexion.oCon);
                    SqlDataAdapter da = new SqlDataAdapter(cmdSQL);
                    dtProveedores = new DataTable();
                    da.Fill(dtProveedores);

                    dgvProveedores.DataSource = dtProveedores;
                    dtProveedoresOriginal = dtProveedores.Copy();

                    if (dgvProveedores.Columns["IdProveedor"] != null)
                        dgvProveedores.Columns["IdProveedor"].Visible = false;
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

            ActualizarLabels();
        }

        private void lblNuevo_Click(object sender, EventArgs e)
        {
            idProveedorActual = 0;
            LimpiarFormulario();
            lblDatosProveedor.Text = "      Registro de proveedor";
            cmbEstado.SelectedIndex = -1; 
        }

        private void LimpiarFormulario()
        {
            txtNombreProveedor.Clear();
            txtNumeroIdentificacion.Clear();
            txtTelefono.Clear();
            txtPersonaContacto.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            cmbTipoIdentificacion.SelectedIndex = -1;
        }

        private void lblEditar_Click(object sender, EventArgs e)
        {

            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un proveedor de la lista.");
                return;
            }

            int filaSeleccionada = dgvProveedores.CurrentRow.Index;
            idProveedorActual = Convert.ToInt32(dtProveedores.DefaultView[filaSeleccionada]["IdProveedor"]);

            CargarDatosProveedor(idProveedorActual);
            lblDatosProveedor.Text = "      Editar proveedor";
        }

        private void CargarDatosProveedor(int idProveedor)
        {
            csConectaSQL oConexion = new csConectaSQL();

            if (oConexion.abrirConexion())
            {
                try
                {
                    string query = @"SELECT NombreProveedor, IdTipoIdentificacion, NumeroIdentificacion,
                                     Telefono, PersonaContacto, Correo, Direccion, IdTipoProveedor
                              FROM Proveedores
                              WHERE IdProveedor = @IdProveedor";

                    SqlCommand cmdSQL = new SqlCommand(query, oConexion.oCon);
                    cmdSQL.Parameters.AddWithValue("@IdProveedor", idProveedor);

                    SqlDataReader dr = cmdSQL.ExecuteReader();

                    if (dr.Read())
                    {
                        txtNombreProveedor.Text = dr["NombreProveedor"].ToString();
                        cmbTipoIdentificacion.SelectedValue = dr["IdTipoIdentificacion"];
                        txtNumeroIdentificacion.Text = dr["NumeroIdentificacion"].ToString();
                        txtTelefono.Text = dr["Telefono"] == DBNull.Value ? "" : dr["Telefono"].ToString();
                        txtPersonaContacto.Text = dr["PersonaContacto"] == DBNull.Value ? "" : dr["PersonaContacto"].ToString();
                        txtCorreo.Text = dr["Correo"] == DBNull.Value ? "" : dr["Correo"].ToString();
                        txtDireccion.Text = dr["Direccion"] == DBNull.Value ? "" : dr["Direccion"].ToString();
                        cmbTipoProveedor.SelectedValue = dr["IdTipoProveedor"];
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

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            if (idProveedorActual == 0)
            {
                LimpiarFormulario();
            }
            else
            {
                CargarDatosProveedor(idProveedorActual);
            }

        }

        private void lblGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text))
            {
                MessageBox.Show("El nombre del proveedor es obligatorio.");
                return;
            }

            if (cmbTipoIdentificacion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de identificación.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroIdentificacion.Text))
            {
                MessageBox.Show("El número de identificación es obligatorio.");
                return;
            }

            if (cmbTipoProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de proveedor.");
                return;
            }

            if (cmbEstado.SelectedIndex == -1)  // ← Valida que haya Estado
            {
                MessageBox.Show("Seleccione el estado.");
                return;
            }

            csConectaSQL oConexion = new csConectaSQL();

            if (oConexion.abrirConexion())
            {
                try
                {
                    SqlCommand cmdSQL = new SqlCommand();
                    cmdSQL.Connection = oConexion.oCon;

                    if (idProveedorActual == 0)
                    {
                        // INSERTAR nuevo proveedor
                        string query = @"INSERT INTO Proveedores 
                        (CodigoProveedor, IdTipoIdentificacion, NumeroIdentificacion, NombreProveedor, 
                         Telefono, PersonaContacto, Correo, Direccion, IdTipoProveedor, Estado)
                        VALUES 
                        (@CodigoProveedor, @IdTipoIdentificacion, @NumeroIdentificacion, @NombreProveedor,
                         @Telefono, @PersonaContacto, @Correo, @Direccion, @IdTipoProveedor, @Estado)";  // ← Cambio aquí

                        cmdSQL.CommandText = query;

                        string codigoProveedor = GenerarCodigoProveedor(oConexion.oCon);

                        cmdSQL.Parameters.AddWithValue("@CodigoProveedor", codigoProveedor);
                        cmdSQL.Parameters.AddWithValue("@IdTipoIdentificacion", cmbTipoIdentificacion.SelectedValue);
                        cmdSQL.Parameters.AddWithValue("@NumeroIdentificacion", txtNumeroIdentificacion.Text);
                        cmdSQL.Parameters.AddWithValue("@NombreProveedor", txtNombreProveedor.Text);
                        cmdSQL.Parameters.AddWithValue("@Telefono", string.IsNullOrWhiteSpace(txtTelefono.Text) ? (object)DBNull.Value : txtTelefono.Text);
                        cmdSQL.Parameters.AddWithValue("@PersonaContacto", string.IsNullOrWhiteSpace(txtPersonaContacto.Text) ? (object)DBNull.Value : txtPersonaContacto.Text);
                        cmdSQL.Parameters.AddWithValue("@Correo", string.IsNullOrWhiteSpace(txtCorreo.Text) ? (object)DBNull.Value : txtCorreo.Text);
                        cmdSQL.Parameters.AddWithValue("@Direccion", string.IsNullOrWhiteSpace(txtDireccion.Text) ? (object)DBNull.Value : txtDireccion.Text);
                        cmdSQL.Parameters.AddWithValue("@IdTipoProveedor", cmbTipoProveedor.SelectedValue);
                        cmdSQL.Parameters.AddWithValue("@Estado", cmbEstado.SelectedItem.ToString());  // ← Agrega aquí

                        cmdSQL.ExecuteNonQuery();
                        MessageBox.Show("Proveedor creado exitosamente.");
                    }
                    else
                    {
                        // ACTUALIZAR proveedor existente
                        string query = @"UPDATE Proveedores 
                        SET IdTipoIdentificacion = @IdTipoIdentificacion,
                            NumeroIdentificacion = @NumeroIdentificacion,
                            NombreProveedor = @NombreProveedor,
                            Telefono = @Telefono,
                            PersonaContacto = @PersonaContacto,
                            Correo = @Correo,
                            Direccion = @Direccion,
                            IdTipoProveedor = @IdTipoProveedor,
                            Estado = @Estado
                        WHERE IdProveedor = @IdProveedor";

                        cmdSQL.CommandText = query;

                        cmdSQL.Parameters.AddWithValue("@IdTipoIdentificacion", cmbTipoIdentificacion.SelectedValue);
                        cmdSQL.Parameters.AddWithValue("@NumeroIdentificacion", txtNumeroIdentificacion.Text);
                        cmdSQL.Parameters.AddWithValue("@NombreProveedor", txtNombreProveedor.Text);
                        cmdSQL.Parameters.AddWithValue("@Telefono", string.IsNullOrWhiteSpace(txtTelefono.Text) ? (object)DBNull.Value : txtTelefono.Text);
                        cmdSQL.Parameters.AddWithValue("@PersonaContacto", string.IsNullOrWhiteSpace(txtPersonaContacto.Text) ? (object)DBNull.Value : txtPersonaContacto.Text);
                        cmdSQL.Parameters.AddWithValue("@Correo", string.IsNullOrWhiteSpace(txtCorreo.Text) ? (object)DBNull.Value : txtCorreo.Text);
                        cmdSQL.Parameters.AddWithValue("@Direccion", string.IsNullOrWhiteSpace(txtDireccion.Text) ? (object)DBNull.Value : txtDireccion.Text);
                        cmdSQL.Parameters.AddWithValue("@IdTipoProveedor", cmbTipoProveedor.SelectedValue);
                        cmdSQL.Parameters.AddWithValue("@Estado", cmbEstado.SelectedItem.ToString());  // ← Agrega aquí
                        cmdSQL.Parameters.AddWithValue("@IdProveedor", idProveedorActual);

                        cmdSQL.ExecuteNonQuery();
                        MessageBox.Show("Proveedor actualizado exitosamente.");
                    }

                    CargarProveedores();
                    idProveedorActual = 0;
                    LimpiarFormulario();
                    lblDatosProveedor.Text = "      Registro de proveedor";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
                finally
                {
                    oConexion.cerrarConexion();
                }
            }
        }

        private string GenerarCodigoProveedor(SqlConnection conexion)
        {
            try
            {
                string query = "SELECT MAX(CAST(SUBSTRING(CodigoProveedor, 5, LEN(CodigoProveedor)) AS INT)) FROM Proveedores WHERE CodigoProveedor LIKE 'PRV-%'";
                SqlCommand cmd = new SqlCommand(query, conexion);

                object resultado = cmd.ExecuteScalar();
                int numero = (resultado == DBNull.Value || resultado == null) ? 1 : Convert.ToInt32(resultado) + 1;

                return "PRV-" + numero.ToString("D3"); 
            }
            catch
            {
                return "PRV-001";
            }
        }
       
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarProveedores(txtBuscar.Text);
        }

        private void FiltrarProveedores(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dtProveedores = dtProveedoresOriginal.Copy();
            }
            else
            {
                DataView dv = dtProveedoresOriginal.DefaultView;
                dv.RowFilter = $"Nombre LIKE '%{filtro}%' OR Código LIKE '%{filtro}%' OR Identificación LIKE '%{filtro}%'";
                dtProveedores = dv.ToTable();
            }

            dgvProveedores.DataSource = dtProveedores;

            if (dgvProveedores.Columns["IdProveedor"] != null)
                dgvProveedores.Columns["IdProveedor"].Visible = false;

        }
        private void ActualizarLabels()
        {
            int total = dtProveedores.Rows.Count;
            int activos = dtProveedores.AsEnumerable().Count(r => r["Estado"].ToString() == "Activo");
            int inactivos = total - activos;

            lblTotalProveedores.Text = total.ToString();          
            lblProveedoresActivos.Text = activos.ToString();     
            lblProveedoresInactivos.Text = inactivos.ToString();   
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Nombre, Código o Identificación")
                txtBuscar.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }
    }
}