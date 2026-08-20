using InventarioLospulpos;
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

namespace DataBeef
{
    public partial class frmCatalogoscs : Form
    {
        public frmCatalogoscs()
        {
            InitializeComponent();
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

        private void lblEmpaque_Click(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new Empaque());
            }
        }

       
        private void lblStock_Click_1(object sender, EventArgs e)
        {
            frmMenu2 menu = this.ParentForm as frmMenu2;

            if (menu != null)
            {
                menu.AbrirFormulario(new frmStock());
            }
        }
    }
}
