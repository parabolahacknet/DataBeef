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
    public partial class frmRecepcionCompras : Form
    {
        public frmRecepcionCompras()
        {
            InitializeComponent();
        }
        private void btnRegistraObservaciones_Click(object sender, EventArgs e)
        {
            frmInspeccionSanitaria frmInspeccion = new frmInspeccionSanitaria();

            DialogResult resultado = frmInspeccion.ShowDialog();
        }

        private void lblProveedores_Click(object sender, EventArgs e)
        {
            frmGestionProovedores frm = new frmGestionProovedores();
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

        private void lblProveedor_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new frmGestionProovedores());
            }
        }
    }
}
