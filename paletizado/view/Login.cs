using paletizado.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletizado.view
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.txt_password.Text!="" && this.txt_password.Text != "")
            {
                InitUsuario init = new InitUsuario();
                Usuarios usuario = (init.validarUsuario(this.txt_usuario.Text));
                String pass = usuario.Password;
                String nombre = usuario.Nombre;
                int perfil = usuario.Perfil;
                String usuarioNombre = usuario.Usuario;
                if (pass.Trim() == this.txt_password.Text.Trim())
                {

                    Form1 form1 = new Form1();
                    form1.Show();
                    form1.setUsuario(nombre, perfil, usuarioNombre);
                    this.txt_password.Text = "";
                    this.txt_usuario.Text = "";

                }
                else
                    MessageBox.Show("Usuario o contraseña incorrectos");
            }
            else
            {
                MessageBox.Show("No puede haber campos vacios");
            }
        
           //this.Close();
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
