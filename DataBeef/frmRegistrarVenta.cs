using InventarioLospulpos;
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
    public partial class frmRegistrarVenta : Form
    {
        public frmRegistrarVenta()
        {
            InitializeComponent();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            pnlStock.Size = new Size(1600, 1);
            lblBajar.Visible = true;
        }

        private void lblBajar_Click(object sender, EventArgs e)
        {
            pnlStock.Size = new Size(1600, 108);
            lblBajar.Visible = false;
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new frmGestionClientes());
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
