using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class Usuarios
    {
        String password;
        int perfil;
        String nombre;
        String usuario;

        public Usuarios(string password, int perfil, string nombre, string usuario)
        {
            this.password = password;
            this.perfil = perfil;
            this.nombre = nombre;
            this.usuario = usuario;
        }

        public string Password { get => password; set => password = value; }
        public int Perfil { get => perfil; set => perfil = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Usuario { get => usuario; set => usuario = value; }
    }
}
