using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class CargarVentanaCospel
    {
        public List<VentanaCospel> cargarVentana()
        {
            List<VentanaCospel> ventanaCospels= new List<VentanaCospel>();

            Connection coneccion = new Connection();
            String query = "SELECT * FROM view_cargar_ventana_cospel;";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    VentanaCospel ventana = new VentanaCospel( leer[0].ToString(), Convert.ToDecimal(leer[1]), leer[2].ToString(), leer[3].ToString(), leer[4].ToString(), leer[5].ToString(), leer[6].ToString(), leer[7].ToString(), leer[8] is DBNull ? 0 : Convert.ToInt32(leer[8]), leer[9] is DBNull ? 0 : Convert.ToInt32(leer[9]), leer[10] is DBNull ? 0 : Convert.ToDecimal(leer[10]));

                    ventanaCospels.Add(ventana);
                    
                }
                return ventanaCospels;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }
           
            coneccion.cerrarConeccion();
            return ventanaCospels;

        }
        public List<VentanaInferior> cargarVentanaInferirorCospel(decimal nroCospel)
        {
            List<VentanaInferior> ventanaCospels = new List<VentanaInferior>();

            String query = "sp_cargar_ventana_inferior_cospel";
            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_nro_cospel", nroCospel);
                cmd.ExecuteScalar();
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    VentanaInferior ventana = new VentanaInferior(leer[0].ToString(), leer[1].ToString(), leer[2].ToString(), leer[3].ToString(), leer[4] is DBNull ? 0 : Convert.ToDecimal(leer[4]));
                    ventanaCospels.Add(ventana);

                }

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            coneccion.cerrarConeccion();

            return ventanaCospels;

        }
        public List<PedidosProduccion> cargarVentanaPedidosProduccion()
        {
            List<PedidosProduccion> ventanaPedidos = new List<PedidosProduccion>();

            Connection coneccion = new Connection();
            String query = "SELECT * FROM view_pedidos_produccion;";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    PedidosProduccion pedidos = new PedidosProduccion(leer[0] is DBNull ? 0 : Convert.ToInt32(leer[0]), leer[1].ToString(), leer[2].ToString(),
                       leer[3] is DBNull ? Convert.ToDateTime("00-00-00") : Convert.ToDateTime(leer[3]), leer[4].ToString(), leer[5].ToString(), leer[6].ToString(),
                       leer[7].ToString(), leer[8].ToString() ,leer[9] is DBNull ? 0 : Convert.ToInt32(leer[9]),
                       leer[10] is DBNull ? 0 : Convert.ToInt32(leer[10]),
                        leer[11] is DBNull ? 0 : Convert.ToInt32(leer[11]), leer[12].ToString(), leer[13].ToString());

                    ventanaPedidos.Add(pedidos);

                }
               
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            coneccion.cerrarConeccion();
            return ventanaPedidos;

        }

        public List<String> buscarCodCospel(String envase, String calibre, String marca, String condicionEmbalado)
        {

            List<String> codCospel = new List<String>();

            codCospel.Clear();

            Connection coneccion = new Connection();
            String query = "SELECT co.cod_cospel FROM view_ver_cospel co where co.envase = @envase  AND calibre = @calibre AND marca =  @marca AND cajas_faltante=0 AND co.codicion_embalado =@condicionEmbalado";

          
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("envase", envase);
                cmd.Parameters.AddWithValue("calibre", calibre);
                cmd.Parameters.AddWithValue("marca", marca);
                cmd.Parameters.AddWithValue("condicionEmbalado", condicionEmbalado);
                
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    codCospel.Add(leer[0].ToString());

                }

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            coneccion.cerrarConeccion();
            return codCospel;

        }
        public String buscarCospelPorCodigoBarra(String codigoBarra)
        {

            String codCospel = "";

            Connection coneccion = new Connection();
            String query = "SELECT cod_cospel FROM cospel WHERE cod_barra =@codigoBarra";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("codigoBarra", codigoBarra);

                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    codCospel=leer[0].ToString();

                }

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            coneccion.cerrarConeccion();
            return codCospel;

        }
    }
}
