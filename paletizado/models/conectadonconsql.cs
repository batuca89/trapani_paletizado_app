using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletizado.models
{
    public class conectadonconsql
    {
        public String conectar(String codigoBarraUp)
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

    }

}
