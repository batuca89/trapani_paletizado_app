using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class AgregarClientes
    {
        public List <String> cargarClientes() {
            List<String> list = new List<String>();

            Connection coneccion = new Connection();
            String query = "SELECT descripcion FROM clientes where habilitado='S' order by descripcion asc";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
             
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    //CreacionDePallet pallet = new CreacionDePallet(leer[0].ToString(), leer[1].ToString(), leer[2].ToString(), leer[3].ToString(), leer[4].ToString(), leer[5].ToString(), Convert.ToDecimal(leer[6] is DBNull ? 0 : leer[6]), Convert.ToDecimal(leer[7] is DBNull ? 0 : leer[7]), leer[8].ToString(), leer[9].ToString(), leer[10].ToString(), leer[11].ToString(), leer[12].ToString(), leer[13].ToString(), leer[14].ToString(), leer[15].ToString(), leer[16].ToString(), leer[17].ToString(), leer[18].ToString(), leer[19].ToString(), leer[20].ToString(), leer[21].ToString(), leer[22].ToString(), leer[23].ToString(), leer[24].ToString(), leer[25].ToString());

                    //usuarios uss = new usuarios(Convert.ToInt32(leer[0]), leer[1].ToString(), leer[2].ToString());
                    //lista.Add(pallet);
                    list.Add(leer.GetString(0));

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
