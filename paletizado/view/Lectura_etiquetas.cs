using paletizado.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletizado.view
{
    public partial class Lectura_etiquetas : Form
    {
         List<LecturaCajas> listComprobacion = new List<LecturaCajas>();
        public int cajasDisponibles;
        public String marca;
        public String envase;
        public String calibre;
        public String condicionEmbalado;
        public String cospelNro;
        decimal pesoDeCaja = 0;
        String lecturaScanner = "";
        String codigoCaja = "";
        String codigoBarraCaja;
        String codigoBarraUp = "";
        List<LecturaCajas> listActual = new List<LecturaCajas>();
        public Lectura_etiquetas(List<LecturaCajas> lista)
        {
            InitializeComponent();
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

        public void getCajas(int cajas)
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

        public void setMarca(String _marca, String _nombreEnvase, String _calibre, String _codicionEmbalado, String _cospelNro)
        {
            envase = _nombreEnvase;
            marca = _marca;
            calibre = _calibre;
            condicionEmbalado = _codicionEmbalado;
            cospelNro = _cospelNro;
        }

        private void txt_lectura_TextChanged(object sender, EventArgs e)
       
        {
            String lecuraEtiqueta = txt_lectura.Text;
            Validaciones validations = new Validaciones(lecuraEtiqueta);
            BuscarCajas cargar = new BuscarCajas();
            if (validations.validarEtiquetas(lecuraEtiqueta) == "up")
            {
                if (this.txt_up.Text != "")
                {
                    this.txt_error_up.Text = "La etiqueta de uo ya fue leida";
                    this.txt_lectura.Text = "";
                    txt_up.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    this.txt_up.Text = cargar.getUp(lecuraEtiqueta);
                    txt_up.BackColor = System.Drawing.Color.GreenYellow;
                    this.txt_lectura.Text = "";
                }
               

            }
            if (validations.validarEtiquetas(lecuraEtiqueta) == "embalador")
            {
                if (this.txt_personal.Text != "")
                {
                    this.txt_error_emnalador.Text = "La etiqueta de uo ya fue leida";
                    this.txt_lectura.Text = "";
                    this.txt_personal.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    this.txt_personal.Text = cargar.getEmpleado(lecuraEtiqueta);
                    this.txt_lectura.Text = "";
                    txt_personal.BackColor=System.Drawing.Color.GreenYellow;
                }


            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
