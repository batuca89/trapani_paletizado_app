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
    public partial class VentamaYes : Form
    {
       public decimal codCospel;
        public VentamaYes()
        {
            InitializeComponent();
        }
        public void setCodCospel(decimal _valor)
        {
            codCospel = _valor;
            this.txtNro.Text = codCospel.ToString();
            //this.txt_nro.Focus();
        }


        private void VentamaYes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarCajas buscar = new BuscarCajas();
            buscar.BorrarCospel(codCospel);
            this.Close();
            MessageBox.Show("se borro el pallet provisorio con exito");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}





