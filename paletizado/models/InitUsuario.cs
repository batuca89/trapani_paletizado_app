using MySql.Data.MySqlClient;
using paletizado.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class InitUsuario
    {
        public Usuarios validarUsuario(String usuario)
        {
            Usuarios usuarios = new Usuarios("",0,"","");
            bool bandera = false;
            String query;


            query = "sp_login";


            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_usuario", usuario);

                cmd.ExecuteScalar();
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                     usuarios = new Usuarios(leer[0].ToString(), leer[1] is DBNull ? 0 : Convert.ToInt16(leer[1]), leer[2].ToString(), leer[3].ToString());
                    
                }
                coneccion.cerrarConeccion();

                

            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }


            return usuarios;
           


        }
    }
}
