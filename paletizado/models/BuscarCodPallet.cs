using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class BuscarCodPallet
    {
        public decimal getPallet(decimal id_pallet)
        {
            decimal pallet;

            Connection coneccion = new Connection();
            String query = "SELECT cod_pallet FROM mov_pallets_citrus where id =@id_pallet";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("id_pallet", id_pallet);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    pallet = Convert.ToDecimal(leer[0] is DBNull ? 0 : leer[0]);
                    return pallet;
                }

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }
            coneccion.cerrarConeccion();

            return 0;
        }
    }
}
