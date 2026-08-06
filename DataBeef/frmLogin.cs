using MenuPrincipal;
using System;
using System.Windows.Forms;

namespace DataBeef
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistrarCuenta registro = new frmRegistrarCuenta();
            registro.ShowDialog();
        }

        private bool ValidarUsuario(string usuario, string contrasena)
        {
            string ruta = "usuarios.txt";
            if (!System.IO.File.Exists(ruta))
                return false; // No hay usuarios registrados

            string[] lineas = System.IO.File.ReadAllLines(ruta);
            foreach (string linea in lineas)
            {
                string[] partes = linea.Split(',');
                if (partes.Length == 2 && partes[0] == usuario && partes[1] == contrasena)
                    return true;
            }
            return false;
        }

        public void LimpiarCampos()
        {
            txtUsuario.Text = "";          // Vacía el campo de usuario
            txtContrasena.Text = "";       // Vacía el campo de contraseña
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Ingresa usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarUsuario(usuario, contrasena))
            {
                // Credenciales correctas: abrir menú y cerrar login
                frmMenu menu = new frmMenu();
                menu.LoginAnterior = this;
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}