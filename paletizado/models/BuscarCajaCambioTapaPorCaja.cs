using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class BuscarCajaCambioTapaPorCaja
    {

        public void borrarCajaCambioTapaporCaja(String codigo_barra)
        {

            String query;


            query = "sp_borrar_cambio_tapa_caja";


            Connection coneccion = new Connection();



            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_codigo_barra", codigo_barra);

                cmd.ExecuteNonQuery();
     
              
                coneccion.cerrarConeccion();

            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);

                coneccion.cerrarConeccion();
            }

        }

        public List<CambioDeTapaPorCadaCaja> buscarCajaCambioTapaporCaja(String codigo_barra)
        {

            List<CambioDeTapaPorCadaCaja> list = new List<CambioDeTapaPorCadaCaja>();
            String query;

         
                query = "sp_buscar_empleado_up_cambio_tapa_caja";
          


            Connection coneccion = new Connection();




            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_codigo_barra", codigo_barra);

                cmd.ExecuteScalar();
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    CambioDeTapaPorCadaCaja lectura = new CambioDeTapaPorCadaCaja(leer[0] is DBNull ? 0 : Convert.ToDecimal(leer[0]), leer[1] is DBNull ? 0 : Convert.ToDecimal(leer[1]), leer[2] is DBNull ? 0 : Convert.ToDecimal(leer[2]), leer[3].ToString(), leer[4].ToString());


                    list.Add(lectura);


                }
                coneccion.cerrarConeccion();

            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);

                coneccion.cerrarConeccion();
            }
                return list;


         


        }

    }
}
