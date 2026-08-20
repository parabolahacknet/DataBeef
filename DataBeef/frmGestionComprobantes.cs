using Menú;
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
    public partial class frmGestionComprobantes : Form
    {
        public frmGestionComprobantes()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlStock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblVentas_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new frmRegistrarVenta());
            }
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new frmGestionClientes());
            }
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

        private void lblPrecios_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new frmPrecioProductos());
            }
        }
    }
}
