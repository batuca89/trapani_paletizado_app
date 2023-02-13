using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class CargarPallet
    {

        public void updateEstadoCospel(int nroCospel)
        {

            String query = "sp_actualizar_estado_cospel";
            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_nro_cospel", nroCospel);
                cmd.ExecuteScalar();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            coneccion.cerrarConeccion();


        }

        public void updateEnvasesEtiquetasCodPallet(decimal CodPallet, decimal nroCospel)
        {

            String query = "sp_update_cod_pallet_envases_etiquetas";
            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@as_cod_pallet", CodPallet);
                cmd.Parameters.AddWithValue("@as_nro_cospel", nroCospel);

                cmd.ExecuteNonQuery();
                coneccion.cerrarConeccion();

            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }


        }
        public decimal getCodPallet()
        {

            decimal NroPallet=0;
            String query = "SELECT fu_get_ultimo_pallet()";
            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = System.Data.CommandType.Text;
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    NroPallet = leer[0] is DBNull ? 0 : Convert.ToDecimal(leer[0]);
                }
                coneccion.cerrarConeccion();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
                coneccion.cerrarConeccion();

            }

            

            return NroPallet;


        }

        public void cargarTablaMovPalletCitrus(decimal nroPallet, String nombreCliente,String nombreCondicionEmbalado,
            String marca,String calibre,String obseervaciones,String propietario,decimal turno,String nombreCalidad, String nombreContramarca,
             String nombreDestino, String codSenasa,String up, String nombreColor,String codigoPedido, String usuario, char embaladoraAutomatica,decimal peso )
        {

            String query = "sp_cargar_tabla_mov_pallet_citrus";
            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@as_cod_pallet", nroPallet);
                cmd.Parameters.AddWithValue("@as_nombre_cliente", nombreCliente);
                cmd.Parameters.AddWithValue("@as_nombre_condicion_embalado", nombreCondicionEmbalado);
                cmd.Parameters.AddWithValue("@as_nombre_marca", marca);
                cmd.Parameters.AddWithValue("@as_nombre_calibres", calibre);
                cmd.Parameters.AddWithValue("@as_observaciones", obseervaciones);
                cmd.Parameters.AddWithValue("@as_propiertario", propietario);
                cmd.Parameters.AddWithValue("@as_turno", turno);
                cmd.Parameters.AddWithValue("@as_cod_calidad", nombreCalidad);
                cmd.Parameters.AddWithValue("@as_nombre_contramarca", nombreContramarca);
                cmd.Parameters.AddWithValue("@as_destinos", nombreDestino);
                cmd.Parameters.AddWithValue("@as_cod_senasa", codSenasa);
                cmd.Parameters.AddWithValue("@as_up", up);
                cmd.Parameters.AddWithValue("@as_color", nombreColor);
                cmd.Parameters.AddWithValue("@as_codigo_pedido", codigoPedido);
                cmd.Parameters.AddWithValue("@as_usuario", usuario);
                cmd.Parameters.AddWithValue("@as_embaladora_automatica", embaladoraAutomatica);
                cmd.Parameters.AddWithValue("@as_peso", peso);
                cmd.ExecuteScalar();
                //MySqlDataReader leer = cmd.ExecuteReader();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            coneccion.cerrarConeccion();


        }
        public void cargarTablaMovPalletCitrusIngresos(decimal nroPallet, String codEmpaque, int cantidadCajas, String nombreCalibre)
        {

            String query = "sp_cargar_tabla_mov_pallet_citrus_ingreso";
            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@as_cod_pallet", nroPallet);
                cmd.Parameters.AddWithValue("@as_cod_empaque", codEmpaque);
                cmd.Parameters.AddWithValue("@as_cantidad_cajas", cantidadCajas);
                cmd.Parameters.AddWithValue("@as_nombre_calibre", nombreCalibre);
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
