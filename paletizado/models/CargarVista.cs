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
    internal class CargarVista
    {


     

        public void  cargarpallet(List<VentanaCospel> lista, String fechaInicio, String fechaFin)
        {



            String query = "sp_ver_cospel";

            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_fecha_ini", fechaInicio);
                cmd.Parameters.AddWithValue("@as_fecha_fin", fechaFin);
                cmd.ExecuteScalar();
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    VentanaCospel cospel = new VentanaCospel(leer[0].ToString(), leer[1] is DBNull ? 0 : Convert.ToDecimal(leer[1]), leer[2].ToString(), leer[3].ToString(), leer[4].ToString(), leer[5].ToString(), leer[6].ToString(), leer[7].ToString(), leer[8] is DBNull ? 0 : Convert.ToInt16(leer[8]), leer[9] is DBNull ? 0 : Convert.ToInt16(leer[9]), leer[10] is DBNull ? 0 : Convert.ToDecimal(leer[10]));



                    lista.Add(cospel);

                }

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            coneccion.cerrarConeccion();

           

        }
       /* public void cargarPallet(List<CreacionDePallet> lista, String fecha_before, String fecha_after)
        {

            Connection coneccion = new Connection();
            String query = "SELECT * FROM view_creacion_de_pallets WHERE fecha between @fechaBefore AND @fechaAfter;";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("fechaBefore", fecha_before);
                cmd.Parameters.AddWithValue("fechaAfter", fecha_after);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    CreacionDePallet pallet = new CreacionDePallet(leer[0].ToString(), leer[1].ToString(), leer[2].ToString(), leer[3].ToString(),
                        leer[4].ToString(), leer[5].ToString(), Convert.ToDecimal(leer[6] is DBNull ? 0 : leer[6]),
                        Convert.ToDecimal(leer[7] is DBNull ? 0 : leer[7]), leer[8].ToString(), leer[9].ToString(), leer[10].ToString(),
                        leer[11].ToString(), leer[12].ToString(), leer[13].ToString(), leer[14].ToString(), leer[15].ToString(), leer[16].ToString(),
                        leer[17].ToString(), leer[18].ToString(), leer[19].ToString(), leer[20].ToString(), leer[21].ToString(), leer[22].ToString(),
                        leer[23].ToString(), leer[24].ToString(), leer[25].ToString(), leer[26].ToString());

                    //usuarios uss = new usuarios(Convert.ToInt32(leer[0]), leer[1].ToString(), leer[2].ToString());
                    lista.Add(pallet);

                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }
            coneccion.cerrarConeccion();


        }*/

        public void cargarPalletPorCheckbox(List<CreacionDePallet> lista, String cliente)
        {

            Connection coneccion = new Connection();
            String query="";

            if (cliente == "piso")
            {
                query = "SELECT * FROM view_creacion_de_pallets where cliente is null";
            }
            else if (cliente == "egresos")
            {
                 query = "SELECT * FROM view_creacion_de_pallets where cliente is not null";
            }
            else
            {
                query = "SELECT * FROM view_creacion_de_pallets;";
            }


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    CreacionDePallet pallet = new CreacionDePallet(leer[0].ToString(), leer[1].ToString(), leer[2].ToString(), leer[3].ToString(), leer[4].ToString(), leer[5].ToString(), Convert.ToDecimal(leer[6] is DBNull ? 0 : leer[6]), Convert.ToDecimal(leer[7] is DBNull ? 0 : leer[7]), leer[8].ToString(), leer[9].ToString(), leer[10].ToString(), leer[11].ToString(), leer[12].ToString(), leer[13].ToString(), leer[14].ToString(), leer[15].ToString(), leer[16].ToString(), leer[17].ToString(), leer[18].ToString(), leer[19].ToString(), leer[20].ToString(), leer[21].ToString(), leer[22].ToString(), leer[23].ToString(), leer[24].ToString(), leer[25].ToString(), leer[26].ToString());

                    //usuarios uss = new usuarios(Convert.ToInt32(leer[0]), leer[1].ToString(), leer[2].ToString());
                    lista.Add(pallet);

                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }
            coneccion.cerrarConeccion();


        }

        public List<VentanaInferior> resumenPallet(decimal cod_pallet)
        {
            String query;

            List<VentanaInferior> list = new List<VentanaInferior>();



            query = "sp_cargar_ventana_inferior_creacion_pallets";

            Connection coneccion = new Connection();
            try
            {
           
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_cod_pallet", cod_pallet);

                cmd.ExecuteScalar();
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    VentanaInferior lectura = new VentanaInferior(leer[0].ToString(), leer[1].ToString(), leer[2].ToString(), leer[3].ToString(), Convert.ToDecimal(leer[4] is DBNull ? 0 : leer[4]));


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
        public List<String> cargarCbPedidos( String fecha_before, String fecha_after)
        {

            List<String> list = new List<String>();
            Connection coneccion = new Connection();
            String query = "SELECT cod_pedido FROM pedidos WHERE estado = 'L' OR estado = 'P';";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("fechaBefore", fecha_before);
                cmd.Parameters.AddWithValue("fechaAfter", fecha_after);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    list.Add(leer[0].ToString());

                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }
            coneccion.cerrarConeccion();

            return list;
        }
        public int buscarCantidadCajasSegunCondicionEmbalado(String condicion_embalado)
        {

            int cantidad = 0;
            Connection coneccion = new Connection();
            String query = "SELECT cantidad_cajas FROM condiciones_embalado where nombre = @condicionembalado;";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("condicionembalado", condicion_embalado);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    cantidad = (Convert.ToInt16(leer[0] is DBNull ? 0 : leer[0]));

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


            return cantidad;
        }

    }
}
