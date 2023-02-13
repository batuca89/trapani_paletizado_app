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
    public partial class ventana_cospel : Form
    {
        public ventana_cospel()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
            Buscar_cospel buscar_Cospel = new Buscar_cospel();
            buscar_Cospel.Show();
            buscar_Cospel.setBandera(false);
            this.Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            inicio_cospel inicio = new inicio_cospel();
            inicio.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscar_cospel buscar_Cospel = new Buscar_cospel();
            buscar_Cospel.Show();
            buscar_Cospel.setBandera(true);
            this.Close();
        }
    }
}
