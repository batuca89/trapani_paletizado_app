using FluentValidation.Results;
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
using System.Xml.Linq;

namespace paletizado.view
{
    public partial class CambioDeTapa : Form
    {
        public bool bandera = false;
        List <String> codigoBarraCaja= new List<String>();
        List <EmbaladorUpCambioDeTapa> embaladorUp = new List<EmbaladorUpCambioDeTapa>();
        BuscarCajas buscar = new BuscarCajas();
        bool palletEncontrado = false;
        decimal nroPallet;
        public CambioDeTapa()
        {
            InitializeComponent();
            txt_leer.Visible= false;
            this.txt_info.ReadOnly=true;
            this.txt_cajas.ReadOnly=true;
            this.label3.Visible = false;
            this.txt_lectura.Focus();
           

        }

        private void txt_lectura_TextChanged(object sender, EventArgs e)
        {

            String lectura2 = txt_lectura.Text;
  
          
            
                if (lectura2.Length == 11)
                {
                    Validaciones validations = new Validaciones(lectura2);
                    if (validations.validarEtiquetas(lectura2) == "caja")
                    {
                    BuscarCajas buscar = new BuscarCajas();

                     nroPallet = buscar.getIdPalletPorCodigoBarra(lectura2) == "" ? -1 : Convert.ToDecimal(buscar.getIdPalletPorCodigoBarra(lectura2));

                    if (nroPallet == -1)
                    {
                        this.txt_info.Text = "Pallet no encontrado";
                        this.txt_lectura.Text = "";
                    }
                    else
                    {
                        
                        palletEncontrado= true;
                       
                    }
                    

                    }
                    else
                this.txt_info.Text = "La etiqueta no corresponde";
                this.txt_lectura.Text = "";
                }
            
        }

        public void setLista(List<EmbaladorUpCambioDeTapa> lista)
        {
            embaladorUp.AddRange(lista);
        }

        public void setTxtInfo(String datos, bool validar){

            this.txt_info.Text = datos;
            if(validar==true)
            this.txt_info.BackColor= Color.GreenYellow;
            else
              this.txt_info.BackColor = Color.OrangeRed;
        }


        public void setTxtCajas(String datos)
        {

            this.txt_cajas.Text = datos;
            this.txt_cajas.BackColor = Color.GreenYellow;
            
        }

        public void setTxtLeer(String datos)
        {

            if (datos != "") { 
            this.txt_leer.Visible= true;
                this.label3.Visible= true;
                this.txt_cajas_leidas.Text = "0";
            this.txt_leer.Text = datos;
            
            }
            this.txt_lectura.Focus();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_info_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(palletEncontrado == true) { 
            inicio_cospel inicio = new inicio_cospel();
            inicio.setCambioDeTapa(true);
            inicio.setnroPallet(nroPallet);
            inicio.Show();
            this.Close();
            }
            else { MessageBox.Show("No hay ningun pallet seleccionado"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (palletEncontrado == true)
            {
                Buscar_cospel cospel = new Buscar_cospel();
                cospel.setCambioDeTapa(true, nroPallet);
                cospel.Show();
            }
            else { MessageBox.Show("No hay ningun pallet seleccionado"); }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CambioTapaPorCaja tapaPorCadaCaja = new CambioTapaPorCaja();
            tapaPorCadaCaja.Show();
        }
    }
}
