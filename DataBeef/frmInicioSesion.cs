using Menú;
using ModuloVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBeef
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Ingresa tu identificación y contraseña.");
                return;
            }

            csConectaSQL conexion = new csConectaSQL();

            if (conexion.abrirConexion())
            {
                try
                {
                    string query = @"SELECT IdEmpleado, Nombre, Apellido, IdRol, PasswordHash, Estado
                              FROM Empleados
                              WHERE NumeroIdentificacion = @NumeroIdentificacion";

                    SqlCommand cmd = new SqlCommand(query, conexion.oCon);
                    cmd.Parameters.AddWithValue("@NumeroIdentificacion", txtUsuario.Text.Trim());

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        bool estaActivo = (bool)dr["Estado"];
                        string passwordGuardada = dr["PasswordHash"].ToString();

                        if (!estaActivo)
                        {
                            MessageBox.Show("Este empleado está inactivo. Contacta al administrador.");
                            return;
                        }

                        if (txtPassword.Text != passwordGuardada)
                        {
                            MessageBox.Show("Contraseña incorrecta.");
                            return;
                        }

                        UsuarioActual.IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]);
                        UsuarioActual.Nombre = dr["Nombre"].ToString();
                        UsuarioActual.IdRol = Convert.ToInt32(dr["IdRol"]);

                        MessageBox.Show("Bienvenido, " + dr["Nombre"].ToString());
                        // cuando creas y muestras el menú desde InicioSesion
                        var menu = new frmMenu2();
                        menu.Show(this); // asigna InicioSesion como Owner del menú
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("No existe ningún empleado con esa identificación.");
                    }
                }
                finally
                {
                    conexion.cerrarConexion();
                }
            }
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
