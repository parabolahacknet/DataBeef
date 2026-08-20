using Menú;
using ModuloVentas;
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
    public partial class frmGestionClientes : Form
    {
        private DataTable dtClientes;

        public frmGestionClientes()
        {
            InitializeComponent();
        }

       

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmRegistrarClientes frm = new frmRegistrarClientes();
            frm.ShowDialog();
            CargarClientes();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
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

        private void lblVentas_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new frmRegistrarVenta());
            }
        }

        private void lblRecibos_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new frmGestionComprobantes());
            }
        }

        private void lblNuevoCliente_Click(object sender, EventArgs e)
        {
            frmRegistrarClientes frmCliente = new frmRegistrarClientes();
            frmCliente.ShowDialog();
        }

        private void lblEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente de la lista.");
                return;
            }

            int filaSeleccionada = dgvClientes.CurrentRow.Index;

            int idCliente = Convert.ToInt32(
                dtClientes.DefaultView[filaSeleccionada]["IdClientes"]
            );

            frmEditarCliente frm = new frmEditarCliente(idCliente);
            frm.ShowDialog();

            CargarClientes();
        }

        private void lblPrecios_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new frmPrecioProductos());
            }
        }

        private void frmGestionClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            csConectaSQL oConexion = new csConectaSQL();

            if (oConexion.abrirConexion())
            {
                try
                {
                    string query = @"SELECT 
                Clientes.IdClientes,
                Clientes.Identificacion,
                Clientes.Nombre,
                Clientes.Apellido,
                Clientes.Email,
                Clientes.Telefono,
                TipoCliente.Nombre AS TipoCliente,
                CASE WHEN Clientes.Estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
              FROM Clientes
              INNER JOIN TipoCliente ON Clientes.IdTipoCliente = TipoCliente.IdTipoCliente";

                    SqlCommand cmdSQL = new SqlCommand(query, oConexion.oCon);
                    SqlDataAdapter da = new SqlDataAdapter(cmdSQL);
                    dtClientes = new DataTable();
                    da.Fill(dtClientes);

                    dgvClientes.DataSource = dtClientes;
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

        private void AplicarFiltros()
        {
            if (dtClientes == null) return;

            string filtro = "";

            if (!string.IsNullOrWhiteSpace(txtIdentificacion.Text))
                filtro += "Identificacion LIKE '%" + txtIdentificacion.Text + "%'";

            if (!string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                if (filtro != "") filtro += " AND ";
                filtro += "(Nombre LIKE '%" + txtCliente.Text + "%' OR Apellido LIKE '%" + txtCliente.Text + "%')";
            }

            if (cmbEstado.SelectedItem != null && cmbEstado.Text != "Todos")
            {
                if (filtro != "") filtro += " AND ";
                filtro += "Estado = '" + cmbEstado.Text + "'";
            }

            dtClientes.DefaultView.RowFilter = filtro;
            dgvClientes.DataSource = dtClientes.DefaultView;
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cmbEstado_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Clear();
            txtCliente.Clear();
            cmbEstado.SelectedIndex =0;

            if (dtClientes != null)
            {
                dtClientes.DefaultView.RowFilter = "";
                dgvClientes.DataSource = dtClientes.DefaultView;
            }
        }
    }
}
