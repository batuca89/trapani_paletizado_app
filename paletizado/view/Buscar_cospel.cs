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
    public partial class Buscar_cospel : Form
    {
        public bool bandera = false;
        public bool isCambioTapa = false;
        public decimal nroPallet;
        public List<EmbaladorUpCambioDeTapa> cambioDeTapaList;
        public Buscar_cospel()
        {
            InitializeComponent();
        }

        public void setBandera(bool _valor) {
        
        bandera= _valor;
        }

        public void setCambioDeTapa(bool _cambioTapa, decimal _nroPallet)
        {
            isCambioTapa = _cambioTapa;
            nroPallet = _nroPallet;
        }

        public void setCambioDeTapaPorCaja( List<EmbaladorUpCambioDeTapa> _cambioDeTapaList)
        {
            isCambioTapa = true;
            cambioDeTapaList = _cambioDeTapaList;
        }

        private void txt_buscar_cospel_TextChanged(object sender, EventArgs e)
        {
            
            String lectura = txt_buscar_cospel.Text;

            Validaciones validations = new Validaciones(lectura);


            if (validations.validarEtiquetas(lectura) =="caja" || validations.validarEtiquetas(lectura) == "cospel")
            {
                if (validations.validarEtiquetas(lectura) == "caja"){
                    BuscarCajas buscarCajas = new BuscarCajas();
                    lectura = buscarCajas.getNroProvisorioSegunCodigoBarraCaja(lectura);
                    if (lectura != "")
                    {
                        // pregunta si quiero entrar a ese provisorio ,cambio de tapa o  borrarlo
                        if (bandera == false)
                        {

                            lectura formularioLectura = new lectura();
                            
                            if (isCambioTapa == true)
                            {
                                BuscarCajas buscar = new BuscarCajas();
                                formularioLectura.cambioDeTapaPorCaja(cambioDeTapaList);
                                //formularioLectura.setCambioDeTapa(true);
                                //formularioLectura.setNroDePallet(nroPallet);
                                //formularioLectura.setListaCambioDeTapa(buscar.getEmbaladorYupCambioTapa(nroPallet));
                                //buscar.updateEnvasesEtiquetasNroPalletCambioTapa(nroPallet);
                            }
                            formularioLectura.CargarDatos(lectura);
                            formularioLectura.Show();

                            this.Close();


                            


                        }
                        else
                        {
                            decimal nroCospel = Convert.ToDecimal(lectura.Substring(0, 10));
                            VentamaYes ventanaYesNo = new VentamaYes();
                           ventanaYesNo.setCodCospel(nroCospel);
                            ventanaYesNo.Show();
                        }
                       
                    }
                    else
                    {
                        this.txt_error.Text = "Lectura incorrecta";
                        this.txt_buscar_cospel.Text = "";
                
                            }

                }



                else 
            {

                    if (bandera == false)
                    {
                        lectura formularioLectura = new lectura();
                        formularioLectura.CargarDatos(lectura);
                        formularioLectura.Show();
                        this.Close();
                    }
                    else
                    {
                        decimal nroCospel = Convert.ToDecimal(lectura.Substring(0, 10));
                        VentamaYes ventanaYesNo = new VentamaYes();
                        ventanaYesNo.setCodCospel(Convert.ToDecimal(nroCospel));
                        ventanaYesNo.Show();
                    }

                }
            }
            else
            {
                txt_error.Text = "Lectura incorrecta: el codigo no corresponde a una etiqueta de caja";
                txt_error.Text = "";
            }


           
        }
    }
}
