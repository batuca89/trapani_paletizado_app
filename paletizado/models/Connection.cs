using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace paletizado.models
{
    internal class Connection
    {
        MySqlConnection conex = new MySqlConnection();



        string cadenaConeccion =
            "server=192.168.41.40;"
            + "port=3306;"
            + "database=pm_vtrapani2023;"
            + "user=cons_vtrapani;"
        + "password=v7r4p4n1;"
            ;


        public MySqlConnection establecerConeccion()
        {
            try
            {
                conex.ConnectionString = cadenaConeccion;

                conex.Open();


                //MessageBox.Show("se logro conectar la base de datos correctamente" );
                return conex;

            }

            catch (MySqlException e)
            {
                MessageBox.Show("La coneccion fallo" + e.ToString());
                return null;
            }
        }

        public void cerrarConeccion()
        {
            conex.Close();
            conex.Dispose();

        }
    }
}
