using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class GetContramarca
    {
        public String cargarContramarca(String nombreCliente)
        {

            String query;
            String contramarca="";


            query = "sp_get_contramarca_por_nombre_cliente";
            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_nombre_cliente", nombreCliente);
                cmd.ExecuteScalar();
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    contramarca = leer[0].ToString();
                }

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            coneccion.cerrarConeccion();

            return contramarca;
        }
    }
}
