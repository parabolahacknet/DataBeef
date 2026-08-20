using DataBeef;
using Menú;
using System;
using System.Collections;
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
    public partial class Faenamiento : Form
    {
        public Faenamiento()
        {
            InitializeComponent();
        }

        private void lblDesposte_Click(object sender, EventArgs e)
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

        private void lblAbajo_Click(object sender, EventArgs e)
        {
            pnlStock.Size = new Size(1600, 108);
            lblAbajo.Visible = false;
        }

        private void lblSubir_Click(object sender, EventArgs e)
        {
            pnlStock.Size = new Size(1600, 1);
            lblAbajo.Visible = true;
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
