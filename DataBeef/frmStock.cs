using DataBeef;
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

namespace InventarioLospulpos
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void lblArriba_Click(object sender, EventArgs e)
        {
            pnlStock.Size = new Size(1600, 1);
            lblAbajo.Visible = true;
        }

        private void lblAbajo_Click(object sender, EventArgs e)
        {
            pnlStock.Size = new Size(1600, 108);
            lblAbajo.Visible = false;
        }

        private void lblFaenamieto_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new Faenamiento());
            }
        }

        private void lbldesposte_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new Desposte());
            }
        }

        private void lblEmpaque_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new Empaque());
            }
        }

        private void lblCatalogos_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new frmCatalogoscs());
            }
        }
    }
}
