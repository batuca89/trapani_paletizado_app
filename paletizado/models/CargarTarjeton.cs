using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletizado.models
{



    internal class CargarTarjeton
    {


        public void limpiarCodCospel(decimal codCospel)
        {



            String query = "DELETE FROM cospel WHERE cod_cospel = @as_cod_cospel;";

            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("as_cod_cospel", codCospel);
                cmd.ExecuteScalar();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            coneccion.cerrarConeccion();

        }

        public void crearCospelVacio(decimal codCospel,String nombreMarca, String nombreCalibre, String nombreCondicionEmbalado)
        {



            String query = "sp_crear_nuevo_cospel";

            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@as_cod_cospel", codCospel);
                cmd.ExecuteScalar();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            coneccion.cerrarConeccion();

        }
        public String getCodCospel()
        {
            String codCospel;

            Connection coneccion = new Connection();
            String query = "SELECT IF(cod_cospel is NULL,1,MAX(cod_cospel)+1) FROM cospel Order by id desc limit 1";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    int nroCospel = (Convert.ToInt32(leer[0] is DBNull ? 0 : (leer[0]))) ;
                    codCospel = nroCospel.ToString();
                    return codCospel;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }
            coneccion.cerrarConeccion();

            return "";
        }

        public void  cargarTablaCospel(decimal codCospel, String codVolcado,String NombreCaja, String codBarra, String nombreCalibre, decimal cantidadEnvases,String marca, decimal pesoEstimado, String observaciones, String usuario, String nombreCondicionEmbalado, String usuarioUltimoAcceso)
        {

            List<LecturaCajas> list = new List<LecturaCajas>();
            String query;

                query = "sp_cargar_ventana_cospel";
            


            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_cod_cospel", codCospel);
                cmd.Parameters.AddWithValue("@as_cod_volcado", codVolcado);
                cmd.Parameters.AddWithValue("@as_caja", NombreCaja);
                cmd.Parameters.AddWithValue("@as_codigo_barra", codBarra);
                cmd.Parameters.AddWithValue("@as_calibre", nombreCalibre);
                cmd.Parameters.AddWithValue("@as_cantidad_envases", cantidadEnvases);
                cmd.Parameters.AddWithValue("@as_marca", marca);
                cmd.Parameters.AddWithValue("@as_peso_estimado", pesoEstimado);
                cmd.Parameters.AddWithValue("@as_observaciones", observaciones);
                cmd.Parameters.AddWithValue("@as_usuario", usuario);
                cmd.Parameters.AddWithValue("@as_cod_condicion_embalado", nombreCondicionEmbalado);
                cmd.Parameters.AddWithValue("@as_usuario_ultimo_acceso", usuarioUltimoAcceso);
                cmd.ExecuteScalar();
               

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            coneccion.cerrarConeccion();

        }
    }
}
