using MySql.Data.MySqlClient;
using paletizado.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace paletizado.models
{
    internal class BuscarCajas
    {
       
        public void BorrarCospel(decimal codCospel)
        {

            String query;


            query = "sp_borrar_cospel";



            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_nroCospel", codCospel);
                cmd.ExecuteNonQuery();
                coneccion.cerrarConeccion();

            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }


        }
        public List<TarjetonVentanaCalibre> getTarjetonCalibre(decimal codPallet)
        {

            List<TarjetonVentanaCalibre> list = new List<TarjetonVentanaCalibre>();
            String query;


            query = "sp_cargar_tarjeton_mov_pallet_citrus_ingreso_calibre";


            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_cod_pallet", codPallet);

                cmd.ExecuteScalar();
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    TarjetonVentanaCalibre lectura = new TarjetonVentanaCalibre(leer[0].ToString(), leer[1].ToString());


                    list.Add(lectura);


                }
                coneccion.cerrarConeccion();

            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }



            return list;


        }
        public List<TarjetonVentanaUp> getTarjetonUp(decimal codPallet)
        {

            List<TarjetonVentanaUp> list = new List<TarjetonVentanaUp>();
            String query;

           
                query = "sp_cargar_tarjeton_mov_pallet_citrus_ingreso";
         

            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_cod_pallet", codPallet);

                cmd.ExecuteScalar();
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    TarjetonVentanaUp lectura = new TarjetonVentanaUp(leer[0].ToString(), leer[1].ToString(), leer[2].ToString());


                    list.Add(lectura);


                }
                coneccion.cerrarConeccion();

            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            

            return list;


        }
        public String validarCajaLeida(String codigoBarraCaja)
        {
            String idEmpleado = "";

            Connection coneccion = new Connection();
            String query = "SELECT id_empleado FROM envases_etiquetas where codigo_barra = @codigoBarra";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("codigoBarra", codigoBarraCaja);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    idEmpleado = leer[0].ToString();


                }
                coneccion.cerrarConeccion();
            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            return idEmpleado;
        }

        public String getIdPalletPorCodigoBarra(String codigoBarraCaja)
        {
            String idPallet="";

            Connection coneccion = new Connection();
            String query = "SELECT id_pallet FROM envases_etiquetas where codigo_barra = @codigoBarra";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("codigoBarra", codigoBarraCaja);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    idPallet = leer[0].ToString();

                    
                }
                coneccion.cerrarConeccion();
            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            return idPallet;
        }

        public void updateEnvasesEtiquetasNroPalletCambioTapa(decimal nroPallet)
        {

            String query;
            query = "sp_udate_envase_etiquetas_nro_pallet_cambio_tapa";
            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_nro_pallet", nroPallet);

                cmd.ExecuteNonQuery();
                coneccion.cerrarConeccion();
            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);

            }

            

        }
        public void updateEnvasesEtiquetasCambioTapa(decimal idEmpleado, decimal idVolcado, decimal peso, decimal nroCospel, String codigoBarra)
        {

            String query;
            query = "sp_update_envase_etiqueta_cambio_tapa";
            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_fecha_id_empleado", idEmpleado);
                cmd.Parameters.AddWithValue("@as_id_empaque_volcado", idVolcado);
                cmd.Parameters.AddWithValue("@as_peso", peso);
                cmd.Parameters.AddWithValue("@as_cod_cospel", nroCospel);
                cmd.Parameters.AddWithValue("@as_codigo_barra", codigoBarra);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);

            }

            coneccion.cerrarConeccion();

        }
        public void updateEnvasesEtiquetasSegunCospel(decimal idEmpleado, decimal idVolcado, decimal peso, decimal nroCospel, String codigoBarra, bool bandera)
        {

            String query;
            query = "sp_update_envase_etiqueta_app_paletizado";
             Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_fecha_id_empleado", idEmpleado);
                cmd.Parameters.AddWithValue("@as_id_empaque_volcado", idVolcado);
                cmd.Parameters.AddWithValue("@as_peso", peso);
                cmd.Parameters.AddWithValue("@as_cod_cospel", nroCospel);
                cmd.Parameters.AddWithValue("@as_codigo_barra", codigoBarra);
                cmd.Parameters.AddWithValue("@as_bandera_paletizado", bandera);
                cmd.ExecuteScalar();
                
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
               
            }

           coneccion.cerrarConeccion();

        }
        public List<EmbaladorUpCambioDeTapa> getEmbaladorYupCambioTapa(decimal idPallet)
     
            {
            String query;
            List<EmbaladorUpCambioDeTapa> lista = new List<EmbaladorUpCambioDeTapa>();
            query = "sp_buscar_empleado_up_cambio_tapa";
            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_id_pallet", idPallet);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    EmbaladorUpCambioDeTapa datos = new EmbaladorUpCambioDeTapa(leer[0] is DBNull ? 0 : Convert.ToDecimal(leer[0]), leer[1] is DBNull ? 0 : Convert.ToDecimal(leer[1]), leer[2] is DBNull ? 0 : Convert.ToDecimal(leer[2]), leer[3].ToString());
                    lista.Add(datos);

                }
                coneccion.cerrarConeccion();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
                coneccion.cerrarConeccion();
            }

            

            return lista;

        }


        public List<SetHeaderDatos> buscarCospelTablaCospel(decimal codCospel)
        {

            String query;

            List<SetHeaderDatos>lista = new List<SetHeaderDatos>();
            query = "sp_buscar_cospel_tabla_cospel";



            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_cod_cospel", codCospel);
                cmd.ExecuteScalar();
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    SetHeaderDatos lectura = new SetHeaderDatos(leer[0].ToString(), leer[3].ToString(), leer[1].ToString(), leer[2].ToString(), leer[4] is DBNull ? 0 : Convert.ToInt16(leer[4]));
                    lista.Add(lectura);

                }


            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            finally
            {
                coneccion.cerrarConeccion();
            }

            

            return lista;

        }

        public List<LecturaCajas> buscarCajaSegunCodigoCospel(decimal codCospel)
        {

            List<LecturaCajas> list = new List<LecturaCajas>();
            String query;

           
                query = "sp_cospel_cajas_leidas";
           


            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_codigo_cospel", codCospel);
                cmd.ExecuteScalar();
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    LecturaCajas lectura = new LecturaCajas(leer[0].ToString(), leer[1].ToString(), leer[2].ToString(), leer[3].ToString(),
                        leer[4].ToString(), leer[5].ToString(), leer[6].ToString(), leer[7].ToString(), leer[8].ToString(), leer[9].ToString(),
                        leer[10].ToString(), leer[11].ToString(), leer[12].ToString(), leer[13].ToString(), "",
                        0, Convert.ToDecimal(leer[14] is DBNull ? 0 : leer[14]), leer[15].ToString(), "0");


                    list.Add(lectura);


                }

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            finally
            {
                coneccion.cerrarConeccion();
            }


            return list;


        }

        public List<LecturaCajas> buscarCaja(String codigo_barra_caja, [Optional] String  codigo_barra_up, [Optional] String codigo_barra_personal, [Optional] String nombreEmpleado)
        {

            List<LecturaCajas> list = new List<LecturaCajas>();
            String query;

            if ((codigo_barra_up == "" && codigo_barra_personal == "") || codigo_barra_up is null && codigo_barra_personal is null)
            {
               query = "sp_cargar_ventana_lectura_scanner_pallet";
            }
            else
            {
                query = "sp_cargar_ventana_lectura_scanner_palle_sin_up_sin_personal";
            }

           
            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_id_etiqueta_caja", codigo_barra_caja);
                cmd.Parameters.AddWithValue("@as_codigo_barra_up", codigo_barra_up);
                cmd.Parameters.AddWithValue("@as_codigo_barra_empleado", codigo_barra_personal);
                cmd.Parameters.AddWithValue("@as_nombre_empleado", nombreEmpleado);
                cmd.ExecuteScalar();
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    LecturaCajas lectura = new LecturaCajas(leer[0].ToString(), leer[1].ToString(), leer[2].ToString(), leer[3].ToString(),
                        leer[4].ToString(), leer[5].ToString(), leer[6].ToString(), leer[7].ToString(), leer[8].ToString(), leer[9].ToString(),
                        leer[10].ToString(), leer[11].ToString(), leer[12].ToString(), leer[13].ToString(), leer[14].ToString(),
                        Convert.ToDecimal(leer[15] is DBNull ? 0 : leer[15]), Convert.ToDecimal(leer[16] is DBNull ? 0  : leer[16]), nombreEmpleado is null ? leer[17].ToString() : nombreEmpleado, leer[18].ToString());

                  
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

        public String getUpPorEtiquetaUp(String codigoBarraUp)
        {
            String up; 

            Connection coneccion = new Connection();
            String query = "SELECT fu_buscar_up_para_palletizado(@codigoBarra)";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("codigoBarra", codigoBarraUp);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    up = leer[0].ToString();

                    return up;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            finally
            {
                coneccion.cerrarConeccion();
            }


            return "";
        }

        public String getUp(String codigoBarraUp)
        {

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConeccion =
          "server=192.168.41.40;"
          + "port=3306;"
          + "database=pm_vtrapani2020_prueba;"
          + "user=cons_vtrapani;"
      + "password=v7r4p4n1;"
          ;
            String up;
            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConeccion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            
            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            try
            {
               
                string consulta = "SELECT fu_buscar_up_para_palletizado(@codigoBarra)"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("codigoBarra", codigoBarraUp);
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    up = reader.GetString(0); //Almacena cada registro con un salto de linea
                    return up;
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message); //Si existe un error aquí muestra el mensaje

            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
                
            }
            return "";
        }

        public String getNroProvisorioSegunCodigoBarraCaja(String codigoBarra)
        {
            String cadena = "";

          
            String nroProvisorio="";
           
            Connection coneccion = new Connection();
            String query = "SELECT coalesce((id_sap_envase_etiqueta)) as nro FROM envases_etiquetas WHERE codigo_barra = @codigobarra";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("codigobarra", codigoBarra);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    nroProvisorio = leer[0].ToString();

                }
                coneccion.cerrarConeccion();
            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
                
            }
            if (nroProvisorio != "")
            {
                cadena = nroProvisorio + "P";
                Generales generales = new Generales();
                cadena = generales.RellenarCadena(cadena, '0', 11, true);
            }
            

            return cadena;
           
           
        }
        public String getEmpleado(String legajo )
        {
            String empleado;

            Connection coneccion = new Connection();
            String query = "SELECT concat(apellido, ' ', nombre) FROM personal where id = (SELECT fu_get_id_empleado(@legajo))";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("legajo", legajo);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    empleado = leer[0].ToString();
                    return empleado;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            finally {
                coneccion.cerrarConeccion();
            }

            return "";
        }

        public decimal getPesoCaja (String peso)
        {
            decimal pesoNeto;

            Connection coneccion = new Connection();
            String query = "SELECT peso_neto FROM cajas where descripcion = @peso ;";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("peso", peso);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    pesoNeto = Convert.ToDecimal(leer[0]);
                    return pesoNeto;
                }


            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            finally
            {
                coneccion.cerrarConeccion();
            }

            return 0;
        }


        public decimal getIdEmpleado(String codigoBarraEtiquetaEmbalador)
        {
            decimal idEmpleado;

            Connection coneccion = new Connection();
            String query = "SELECT fu_get_id_empleado(@codigoBarra)";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("codigoBarra", codigoBarraEtiquetaEmbalador);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    idEmpleado = leer[0] is null ? 0 : Convert.ToDecimal(leer[0]);

                    return idEmpleado;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            finally
            {
                coneccion.cerrarConeccion();
            }
            

            return 0;
        }

        public int comprobarKgDisponibles(String codEmpaque, int NroCospel, decimal pesoPallet)
        {
            int cantidadCajasDeMas=0;

            Connection coneccion = new Connection();
            String query = "SELECT fu_verificar_peso_segun_cod_empaque(@as_cod_empaque,@as_cod_cospel,@as_peso_palltet)";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("as_cod_empaque", codEmpaque);
                cmd.Parameters.AddWithValue("as_cod_cospel", NroCospel);
                cmd.Parameters.AddWithValue("as_peso_palltet", pesoPallet);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    Console.WriteLine(leer[0].ToString());
                    cantidadCajasDeMas = leer[0] is null ? 0 : Convert.ToInt16(leer[0]);

                    return cantidadCajasDeMas;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }
            coneccion.cerrarConeccion();

            return 0;
        }

        public String getCodVolcado(String codigo_barra_up)
        {
            String codVolcado;

            Connection coneccion = new Connection();
            String query = "select fu_buscar_cod_volcado_por_codigoBarra_up(@codigo_barra_up);";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("codigo_barra_up", codigo_barra_up);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    codVolcado = leer[0].ToString();
                    return codVolcado;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }
            coneccion.cerrarConeccion();

            return "";
        }
        public String getCalibreMix()
        {
            String codCalibre;

            Connection coneccion = new Connection();
            String query = "SELECT cod_calibre FROM calibres where descripcion = 'MIX';";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    codCalibre = leer[0].ToString();
                    return codCalibre;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }
            coneccion.cerrarConeccion();

            return "";
        }
    }
}
