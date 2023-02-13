using FluentValidation;
using FluentValidation.Results;
using paletizado.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletizado.view
{
    public partial class lectura_up_personal : Form
    {

        String lecturaScanner = "";
        String codigoCaja = "";
        String codigoBarraCaja;
        String codigoBarraUp = "";
        String codigoBarraEmpleado = "";
        public String codigoUp = "";
        String codigoEmbalador = "";
        decimal pesoDeCaja = 0;
        BuscarCajas buscarCaja = new BuscarCajas();
        String empleado;
        lectura lectura = new lectura();
        bool lecturaUp = false;
        bool lecturaEmpleado = false;
        List<LecturaCajas> listComprobacion = new List<LecturaCajas>();
        List<LecturaCajas> listActual = new List<LecturaCajas>();
        public String cajasDisponibles;
        public String marca;
        public String envase;
        public String calibre;
        public String condicionEmbalado;
        public String cospelNro;
        decimal id_volcado;
        decimal id_empleado;

        public lectura_up_personal(List<LecturaCajas> lista)
        {


            InitializeComponent();
            txt_lectura_l.Focus();

            listComprobacion.Clear();
            listComprobacion.AddRange(lista);
           



        }

        public void getLista(List<LecturaCajas> lista)
        {
            listComprobacion.Clear();
            listComprobacion.AddRange(lista);
        }

        public void peso(decimal peso)
        {
            pesoDeCaja = peso;
        }

        public void getCajas(String cajas)
        {

            cajasDisponibles = cajas;
        }

        public void getCodigoBarraCaja(String codigoBarra)
        {
            codigoBarraCaja = "";
            codigoBarraCaja = codigoBarra;
        }

        public void saveList(List<LecturaCajas> lista)
        {
            listActual.Clear();
            listActual.AddRange(lista);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)

        {

        }

      

        public void setMarca(String _marca, String _nombreEnvase, String _calibre, String _codicionEmbalado, String _cospelNro)
        {
            envase = _nombreEnvase;
            marca = _marca;
            calibre = _calibre;
            condicionEmbalado = _codicionEmbalado;
            cospelNro = _cospelNro;
        }
        private void txt_up_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void txt_lectura_l_TextChanged(object sender, EventArgs e)



        {


          


          

            if (txt_lectura_l.Text.Length >= 11) {

                lecturaScanner = txt_lectura_l.Text;


                if (txt_lectura_l.Text.Length == 11)
                
            {
               
                if (lecturaScanner.Last() == 'U')
                {
                    if (txt_up_l.Text != "")
                    {
                        txt_lectura_l.Text = "";
                        txt_error.Text = "La etiqueta de up ya fue leida";
                    }
                    else
                    {

                        txt_lectura_l.Focus();
                        codigoUp = txt_lectura_l.Text;
                        codigoUp = buscarCaja.getUpPorEtiquetaUp(txt_lectura_l.Text);
                        if (codigoUp is null || codigoUp == "")
                        {
                            txt_up_l.BackColor = Color.OrangeRed;
                            txt_error.Text = "Error: UP  no encotrada";
                            txt_lectura_l.Text = "";
                        }
                        else
                        {
                            txt_up_l.BackColor = Color.GreenYellow;
                            txt_up_l.Text = codigoUp;
                            id_volcado = Convert.ToDecimal(lecturaScanner.Remove(lecturaScanner.Length - 1));
                            lbl_up.ForeColor = Color.Black;
                            codigoBarraUp = txt_lectura_l.Text;
                            //listComprobacion[0].CodEmpaque = buscarCaja.getCodVolcado(txt_lectura_l.Text);
                            txt_lectura_l.Text = "";
                            txt_error.Text = "";
                            //listComprobacion[0].Up = codigoUp;

                            lecturaUp = true;

                            // lecturaCajas.Show();
                        }



                        txt_lectura_l.Clear();

                    }
                }
                    else
                    {
                        if (lecturaScanner.Last() == 'E' || lecturaScanner.Last() == 'P' || lecturaScanner.Last() == 'C')
                        {
                            txt_lectura_l.Text = "";
                            txt_error.Text = "La etiqueta no corresponde";
                        }

                           
                        
                        
                          
                    }

                }

               

                    if (txt_lectura_l.Text.Length == 12)
            {
                    if (lecturaScanner.Last() == 'E')
                    {
                        if (txt_personal_l.Text != "")
                        {
                            txt_lectura_l.Text = "";
                            txt_error.Text = "La etiqueta de personal ya fue leida";
                        }
                        else
                        {

                            txt_lectura_l.Focus();

                            try
                            {
                                //codigoEmbalador = decimal.Parse(txt_lectura_l.Text.Substring(0, 6));
                                codigoEmbalador = txt_lectura_l.Text;
                                id_empleado = buscarCaja.getIdEmpleado(codigoEmbalador);
                                empleado = buscarCaja.getEmpleado(codigoEmbalador);
                                if (empleado != "")
                                {
                                    txt_personal_l.Text = empleado;
                                    txt_personal_l.BackColor = Color.GreenYellow;
                                    lbl_personal.ForeColor = Color.Black;
                                    codigoBarraEmpleado = txt_lectura_l.Text;
                                    txt_lectura_l.Text = "";
                                    txt_error.Text = "";

                                    // listComprobacion[0].Empleado = id_empleado.ToString();
                                    //lectura.updateEmpleado(empleado);
                                    lecturaEmpleado = true;
                                }
                                else
                                {
                                    txt_error.Text = "Error empleado no existe";
                                    txt_lectura_l.Text = "";
                                }
                            }
                            catch (FormatException t)

                            {
                                txt_error.Text = t.Message;
                            }
                        }


                    }
                }
                
            }
          
                if (txt_lectura_l.Text.Length == 13)
            {
                if (txt_lectura_l.Text.Last() == 'S')
                {
                    txt_lectura_l.Text = "";
                    txt_error.Text = "La etiqueta no corresponde";
                }
            }







            if (lecturaEmpleado == true && lecturaUp == true)
            {

                BuscarCajas buscar = new BuscarCajas();

                decimal cospelNroDecimal = Convert.ToDecimal((cospelNro));
                lectura.codigoUp = codigoUp;
                lectura.updateTxtUp(codigoUp);
                buscar.updateEnvasesEtiquetasSegunCospel(id_empleado,id_volcado,pesoDeCaja, cospelNroDecimal, codigoBarraCaja,true);
                listActual.AddRange(buscar.buscarCaja(codigoBarraCaja, codigoBarraUp,codigoBarraEmpleado, empleado));
                lectura.updatesCajasLeidasYEnvasesDisponibles((listActual.Count-1).ToString(),cajasDisponibles);
                lectura.cargarDataGridView(listActual);

                lectura.updateTxtEmpleado(empleado);
                
                //comprobacion.AddRange(buscar.buscarCaja(codigoCaja));
                //lectura.caja.AddRange(comprobacion);
                //lectura.cargarDataGridView(lectura.caja);
                lectura.setMarca(marca,envase,calibre, condicionEmbalado, cospelNro);
                lectura.updateTxtErrorDesdeLecturaUpEmbalador();
                lectura.Show();
                this.Close();
            }
        }

       
    }
}
