using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class CargarDatosTarjetonMovPallet
    {
        public List<TarjetonMovPallet> buscarCajaSegunCodigoPallets(decimal nroPallet)
        {

            List<TarjetonMovPallet> list = new List<TarjetonMovPallet>();
            String query;


            query = "sp_cargar_tarjeton_mov_pallet_citrus";



            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_cod_pallet", nroPallet);
                cmd.ExecuteScalar();
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    TarjetonMovPallet lectura = new TarjetonMovPallet(leer[0].ToString(), leer[1].ToString(), leer[2] is DBNull ? 0 : Convert.ToInt16(leer[2]),
                    leer[3].ToString(), leer[4].ToString(), leer[5].ToString(), leer[6].ToString(), leer[7].ToString(), leer[8].ToString(), leer[9].ToString(), leer[10].ToString(), leer[11].ToString(), leer[12].ToString(), leer[13].ToString(), leer[14].ToString());
                    list.Add(lectura);


                }

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            coneccion.cerrarConeccion();

            return list;


        }
    }
}
