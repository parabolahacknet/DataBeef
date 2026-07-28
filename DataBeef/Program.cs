using System;
using System.Windows.Forms;
using MenuPrincipal;

namespace DataBeef
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar el formulario de inicio de sesión como diálogo. Si el inicio de sesión fue
            // exitoso (DialogResult.OK), iniciar el bucle principal con frmMenu. Esto asegura
            // que al cerrar frmMenu el proceso termine completamente.
            using (var login = new InicioSesion())
            {
                var result = login.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Application.Run(new frmMenu());
                }
            }
        }
    }
}
