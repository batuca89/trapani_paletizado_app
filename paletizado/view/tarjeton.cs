using paletizado.controller;
using paletizado.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletizado.view
{
    public partial class tarjeton : Form
    {

        List <String> calibre = new List <String> ();
        int cospelNro;
        List<LecturaCajasReducidas> listaReducida = new List<LecturaCajasReducidas>();
        decimal codigoBarra = 0;


        public tarjeton()
        {
            InitializeComponent();
            configDatagridView(dgv_empaques,300,80);
            configDatagridView(dgv_empleado,400,80);
            configDatagridView(dgv_calibres, 180, 160);
            configDatagridView(dgv_up, 180, 120);
            dgv_empaques.ClearSelection();
            dgv_empleado.ClearSelection();
            dgv_calibres.ClearSelection();
            dgv_up.ClearSelection();
         
            
        }

        public  void cargarVolcadoEnTabla(List<LecturaCajas> lista)
        {
            
            
            
            if (lista.Count > 0 && listaReducida.Count==0)
            {
                LecturaCajasReducidas lectura = new LecturaCajasReducidas(lista[0].Lectura, lista[0].CodEmpaque, lista[0].FechaSenasa,
                         lista[0].Empleado, lista[0].Tarea, lista[0].Concepto, lista[0].Observaciones, lista[0].Up,
                         lista[0].Producto, lista[0].Variedad, lista[0].Marca, lista[0].Calibre, lista[0].Envase,
                         lista[0].LeidaEn, lista[0].Id_volcado, lista[0].Id_pallet, lista[0].Peso, lista[0].NombreEmpleado, 0);
                listaReducida.Add(lectura);

            }

                foreach(var indice2 in lista)
                {
                bool confirmacion = false;
                int indice = -1;
                foreach (var indice1 in listaReducida)
                {
                    indice++;
                    if (indice1.Id_volcado == indice2.Id_volcado && indice1.Up == indice2.Up && indice1.Calibre == indice2.Calibre)
                    {

                        confirmacion= true;
                        break;
                       
                    }

                }

                if (confirmacion == false)
                {
                    LecturaCajasReducidas lectura = new LecturaCajasReducidas(lista[indice].Lectura, lista[indice].CodEmpaque, lista[indice].FechaSenasa,
                        lista[indice].Empleado, lista[indice].Tarea, lista[indice].Concepto, lista[indice].Observaciones, lista[indice].Up,
                        lista[indice].Producto, lista[indice].Variedad, lista[indice].Marca, lista[indice].Calibre, lista[indice].Envase,
                        lista[indice].LeidaEn, lista[indice].Id_volcado, lista[indice].Id_pallet, lista[indice].Peso, lista[indice].NombreEmpleado,0);
                    listaReducida.Add(lectura);

                }

                
            }
           
        }



      /*  public void cantidadCajas(List<LecturaCajas> listaCompleta)
        {

                 List<LecturaCajasReducidas> lecturaCajasReducidas = new List<LecturaCajasReducidas>();

            foreach(var indice1 in listaCompleta)
            {
                int cont = 0;
                foreach(var indice2 in listaReducida)
                {
                    if (indice1.Id_volcado == indice2.Id_volcado && indice1.Up == indice2.Up && indice1.Calibre == indice2.Calibre)
                    {
                        cont++;
                        indice2.CantidadCajas =  cont;
                    }
                }
            }

            foreach (var i in listaReducida)
            {
                Console.WriteLine(i.CantidadCajas.ToString());
            }
        }
      */

    

        private void configDatagridView(System.Windows.Forms.DataGridView tarjeton, int anchoColuma1, int anchoColuma2)
        {
            tarjeton.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            tarjeton.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16);
            tarjeton.RowHeadersVisible = false;
            tarjeton.GridColor = Color.Black;
            tarjeton.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tarjeton.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tarjeton.BorderStyle = BorderStyle.None;
            tarjeton.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            tarjeton.Columns[0].Width = anchoColuma1;
            tarjeton.Columns[1].Width = anchoColuma2;
            tarjeton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tarjeton.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public string RellenarCadena(string cadenaARellenar, char caracterDeRelleno, int longitud, bool izquierda)
        {
            //dependiendo hacia donde queramos rellenar, es lo que devolvemos
            if (izquierda)
            {
                return cadenaARellenar.PadLeft(longitud, caracterDeRelleno);
            }
            else
            {
                return cadenaARellenar.PadRight(longitud, caracterDeRelleno);
            }
        }
        public void CargarTarjeton( List<TarjetonEmpaque> lista, List<TarjetonPersonal> listaPersonal, List<TarjetonCalibres> listaCalibre,String envase, String variedad, String marca, decimal peso, int cajas, List<TarjetonUp> listaUp,List<LecturaCajas> caja, String cospelNro,String condicionEmbalado, String usuario, String observacion)
        {
            
            dgv_empaques.DataSource = lista;
           
           dgv_empleado.DataSource = listaPersonal;

            dgv_calibres.DataSource = listaCalibre;


            dgv_up.DataSource= listaUp;
            txt_envase.Text = envase;
            txt_variedad.Text = variedad;
            txt_marca.Text = marca;
            decimal pesoContarima = peso + 30;
            txt_peso.Text = pesoContarima. ToString();
            txt_cajas.Text = cajas.ToString();
            txt_fecha.Text = DateTime.Now.ToString();
            dgv_empaques.ClearSelection();
            dgv_empleado.ClearSelection();
            dgv_calibres.ClearSelection();
            SetTextbox txt = new SetTextbox();
            CargarTarjeton tarjeton = new CargarTarjeton();
            Generales gen = new Generales();
            //txt.CargarTexbox(this.txt_cospel, tarjeton.getCodCospel());
            // variables
            decimal nroCospel = Convert.ToDecimal(cospelNro);
            String codigoBarraFormato = gen.RellenarCadena(nroCospel.ToString(), '0', 10, true) + "P";
            txt_codigo_barra.Text = codigoBarraFormato;
            image.Image = gen.ImagecodigoBarra(codigoBarraFormato, 450, 150, false);


            //Comprobacion de los calibres, si hay mas de uno se colocara mix

            String idVolcado = "";
            String calibre = "";
            CargarTarjeton cargar = new CargarTarjeton();
            cargar.limpiarCodCospel(nroCospel);

            if (lista.Count() >= listaCalibre.Count())
            {
                foreach (var i in lista)
                {
                    foreach (var j in caja)
                    {
                        if (i.empaque == j.CodEmpaque)
                        {
                            calibre = j.Calibre;
                            break;
                        }
                    }
                   
                    cargar.cargarTablaCospel(nroCospel, i.empaque, envase, codigoBarraFormato, calibre, i.Cajas, marca, peso, observacion, usuario, condicionEmbalado, usuario);
                }
            }
            else
            {

            
            foreach(var i in listaCalibre)
            {
                foreach (var j in caja)
                {
                    if(i.Calibre == j.Calibre)
                    {
                        idVolcado = j.CodEmpaque;
                        break;
                    }
                }
               
                cargar.cargarTablaCospel(nroCospel, idVolcado, envase, codigoBarraFormato, i.Calibre, i.Cajas, marca, peso, observacion, usuario, condicionEmbalado, usuario);
            }
            }

        }

     
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tarjeton_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height, panel1.CreateGraphics());
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, 800, factor * 800);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                dgv_empaques.ClearSelection();
                dgv_empleado.ClearSelection();
                dgv_calibres.ClearSelection();
                dgv_up.ClearSelection();
                //printDocument1.Print();
               
            }
           
        }

        private void dgv_up_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_up_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_impresora_Click(object sender, EventArgs e)
        {
            dgv_empaques.ClearSelection();
            dgv_empleado.ClearSelection();
            dgv_calibres.ClearSelection();
            dgv_up.ClearSelection();

        }

        private void txt_codigo_barra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cospel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
