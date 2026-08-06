using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataBeef
{
    public partial class frmRegistrarCuenta : Form
    {
        public frmRegistrarCuenta()
        {
            InitializeComponent();
        }

        private void linkIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarUsuario(string usuario, string contrasena)
        {
            string ruta = "usuarios.txt";

            // Leer todas las líneas si el archivo existe
            List<string> lineas = new List<string>();
            if (System.IO.File.Exists(ruta))
                lineas = new List<string>(System.IO.File.ReadAllLines(ruta));

            // Verificar que el usuario no exista ya
            foreach (string linea in lineas)
            {
                string[] partes = linea.Split(',');
                if (partes.Length == 2 && partes[0] == usuario)
                {
                    MessageBox.Show("Ese nombre de usuario ya está registrado. Elige otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Agregar el nuevo usuario
            lineas.Add($"{usuario},{contrasena}");

            // Guardar todo
            System.IO.File.WriteAllLines(ruta, lineas);

            MessageBox.Show("¡Cuenta creada con éxito! Ya puedes iniciar sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Completa todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GuardarUsuario(usuario, contrasena);
        }


    }
}
