using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DataBeef
{
    internal class csConectaSQL
    {
        public SqlConnection oCon;

        string Server;
        string Database;
        string Usuario;
        string Clave;

        public csConectaSQL()
        {
            Server = "proyectodatabeef.database.windows.net";
            Database = "DataBeef";
            Usuario = "richard";
            Clave = "Rich1234!";
        }

        public bool abrirConexion()
        {
            oCon = new SqlConnection();

            try
            {
                oCon.ConnectionString =
                    "Server=tcp:" + Server + ",1433;" +
                    "Database=" + Database + ";" +
                    "User ID=" + Usuario.Trim() + ";" +
                    "Password=" + Clave + ";" +
                    "Encrypt=True;" +
                    "TrustServerCertificate=False;" +
                    "Connection Timeout=30;";

                oCon.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool cerrarConexion()
        {
            try
            {
                oCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
