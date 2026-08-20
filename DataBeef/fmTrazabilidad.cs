using System;
using System.Windows.Forms;

namespace DataBeef
{
    public partial class fmTrazabilidad : Form
    {
        public fmTrazabilidad()
        {
            InitializeComponent();
        }

      

     

        private void fmTrazabilidad_Shown(object sender, EventArgs e)
        {
            // Asignar el foco a cuiPanel1 (lo hice para q se muestre el placeholder del buscador cuando se abre este form)
            ActiveControl = cuiPanel1;
        }
    }
}
