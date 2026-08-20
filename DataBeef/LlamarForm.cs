using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBeef
{
    public class LlamarForm
    {
        private Form formularioActivo = null;

        public void AbrirFormulario(Form formularioHijo, Panel contedido)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formularioHijo;

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Evitar que mínimas restricciones del formulario hijo impidan el ajuste en el panel
            formularioHijo.MinimumSize = System.Drawing.Size.Empty;
            formularioHijo.MaximumSize = System.Drawing.Size.Empty;
            formularioHijo.Size = contedido.ClientSize;

            contedido.Controls.Clear();
            contedido.Controls.Add(formularioHijo);
            contedido.Tag = formularioHijo;

            formularioHijo.Show();
        }

    }
}
