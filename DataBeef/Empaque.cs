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
    public partial class Empaque : Form
    {
        public Empaque()
        {
            InitializeComponent();
        }

        private void lblFaenamieto_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new Faenamiento());
            }
        }

        private void lblDesposte_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new Desposte());
            }
        }

        private void lblSubir_Click(object sender, EventArgs e)
        {
            pnlStock.Size = new Size(1600, 1);
            lblAbajo.Visible = true;
        }

        private void lblAbajo_Click(object sender, EventArgs e)
        {
            pnlStock.Size = new Size(1600, 108);
            lblAbajo.Visible = false;
        }

        private void lblStock_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new frmStock());
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
