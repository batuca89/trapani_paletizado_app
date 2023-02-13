using MySql.Data.MySqlClient.Memcached;
using paletizado.controller;
using paletizado.models;
using paletizado.view;
using System;

using System.Collections.Generic;

using System.Data;

using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Ports;
using System.Linq;

using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml.Linq;

namespace paletizado
{
    public partial class Form1 : Form
    {
        String selectDateAsStringBefore;
        String selectDateAsStringAfter;
        CargarVista cargar = new CargarVista();
        List<VentanaCospel> list = new List<VentanaCospel>();
        int index;
        char embaladoraAutomatica;
        CargarVentanaCospel ventanaCospel = new CargarVentanaCospel();
        List<VentanaInferior> ventanaInferiors = new List<VentanaInferior>();
        List<int> valores = new List<int>();
        bool bandera = false;
        decimal totalEnvases = 0;
        int cantidadDisponible = 0;
        string DataIn;
        String up;
        String fechaMenor;
        String selectDateAsStringBefore1;
        String selectDateAsStringAfter1;
        String nombreEquipo;
        public String nombreUsuario;
        public int perfilUsuario = 1;
        String lectura;
        public String usuario;
        
        public Form1()
        {


            InitializeComponent();


            btn_cerrar_dgv_pedidos.Visible = false;
            List<String> propiedad = new List<String>();
            propiedad.Add("Propio");
            propiedad.Add("Terceros");
            cofigDatagridView(adgv);
            setEmbaladoraAutomatica('N');
            int diaActual = Convert.ToInt16(DateTime.Now.ToString("dd"));

            Console.WriteLine(diaActual);
            if (diaActual >= 11)
            {
                diaActual = diaActual - 10;
            }
            Generales generales = new Generales();

            String mes = DateTime.Now.ToString("MM");
            String anio = DateTime.Now.ToString("yyyy");

            fechaMenor = anio + "-" + mes + "-" + generales.RellenarCadena(diaActual.ToString(), '0', 2, true); ;
            selectDateAsStringBefore1 = fechaMenor;
            selectDateAsStringAfter1 = (DateTime.Now.ToString("yyyy-MM-dd"));

            dtp_before.Text = fechaMenor;
            txt_hora.Text = DateTime.Now.ToString("hh:mm");
            cb_todos.Checked = true;
            cargarDatagridCospel(selectDateAsStringBefore1, selectDateAsStringAfter1);
            CargarComboboxs cargaComboboxs = new CargarComboboxs();
            cargaComboboxs.cargarComboboxs(cb_clientes, cb_envases, cb_condiciones_envalado, cb_colores, cb_destino, cb_marcas, cb_calidad, cb_camara, cb_calibre, cb_turno, cb_deposito);
            configCombobox();
            cb_tipo.DataSource = propiedad;
            cb_deposito.Text = "Principal";
            // dgv_pedidos.DataSource = ventanaCospel.cargarVentanaPedidosProduccion();
            dgv_pedidos.RowHeadersVisible = false;
            dgv_pedidos.Columns[0].Width = 100;
            dgv_pedidos.Visible = false;
            dgv_pedidos.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dgv_pedidos.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            this.txt_codigo_barra.Focus();
            nombreEquipo = System.Net.Dns.GetHostName();
            nombreUsuario = "Matias Salas";

            List<String> listaSeleccion = new List<String>();

            listaSeleccion.Add("Ultimos 7 dias");
            listaSeleccion.Add("Esta quincena");
            listaSeleccion.Add("Este mes");
            listaSeleccion.Add("Este año");

            foreach (var x in listaSeleccion)
            {
                cb_seleccion.Items.Add(x.ToString());
            }

            this.btn_cambio_tapa.Enabled = false;
            this.btn_cambio_tapa.Visible= false;
        }
        public void configCombobox()
        {
            this.cb_colores.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_colores.SelectedIndex = 0;
            this.cb_camara.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_camara.SelectedIndex = 0;
            this.cb_calidad.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_calidad.SelectedIndex = 0;
            this.cb_destino.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_envases.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_marcas.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_calibre.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_condiciones_envalado.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cargarDatagridCospel(String fechaInicial, String fechaFinal) {
            list.Clear();
            cargar.cargarpallet(list, fechaInicial, fechaFinal);
            ListttoDataTableConverter converter = new ListttoDataTableConverter();
            DataTable dt = converter.ToDataTable(list);
            this.creacionDePalletBindingSource.DataSource = dt;
            adgv.DataSource = this.creacionDePalletBindingSource;
            dgv_pedidos.DataSource = ventanaCospel.cargarVentanaPedidosProduccion();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


            cargarDatagridCospel(dtp_before.Value.ToString("yyyy-MM-dd"), dtp_after.Value.ToString("yyyy-MM-dd"));
            PintarDatagrid(valores);



        }

        private void dtp_after_ValueChanged(object sender, EventArgs e)
        {
            cargarDatagridCospel(dtp_before.Value.ToString("yyyy-MM-dd"), dtp_after.Value.ToString("yyyy-MM-dd"));
            PintarDatagrid(valores);
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //index = e.RowIndex;
            //cb_clientes.Text = list[index].Cliente.ToString();


        }

        private void advancedDataGridView1_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            this.creacionDePalletBindingSource.Sort = this.adgv.SortString;
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            this.creacionDePalletBindingSource.Filter = this.adgv.FilterString;
            adgv.DataSource.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Clear();
            // cargar.cargarpallet(list, selectDateAsStringBefore, selectDateAsStringAfter);
            cargarDatagridCospel(selectDateAsStringBefore1, selectDateAsStringAfter1);
            PintarDatagrid();
            //ListttoDataTableConverter converter = new ListttoDataTableConverter();
            //DataTable dt = converter.ToDataTable(list);
            //this.creacionDePalletBindingSource.DataSource = dt;
            //adgv.DataSource = list;
        }

        private void cargarDataGridViewVentanaInfeior(List<VentanaInferior> listaVentaIferior, String condicionEmbalado)
        {
            totalEnvases = 0;
            cantidadDisponible = 0;
            for (int i = 0; i < listaVentaIferior.Count; i++)
            {
                totalEnvases = totalEnvases + listaVentaIferior[i].CantidadEnvases1;
            }

            cantidadDisponible = cargar.buscarCantidadCajasSegunCondicionEmbalado(condicionEmbalado);

            txt_cantidad_disponible.Text = (cantidadDisponible - totalEnvases).ToString();


            txt_total_envases.Text = totalEnvases.ToString();


            ListttoDataTableConverter converter = new ListttoDataTableConverter();
            DataTable dt = converter.ToDataTable(listaVentaIferior);
            this.ventanaInferiorBindingSource.DataSource = dt;
            this.adgv_ventana_inferior.DataSource = listaVentaIferior;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_piso.Checked == true)
            {
                cb_egresos.Checked = false;
                cb_todos.Checked = false;
                list.Clear();
                // cargar.cargarPalletPorCheckbox(list, "piso");
                ListttoDataTableConverter converter = new ListttoDataTableConverter();
                DataTable dt = converter.ToDataTable(list);
                this.creacionDePalletBindingSource.DataSource = dt;
                adgv.DataSource = this.creacionDePalletBindingSource;
            }
        }

        private void cb_egresos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_egresos.Checked == true)
            {
                cb_piso.Checked = false;
                cb_todos.Checked = false;
                list.Clear();
                //cargar.cargarPalletPorCheckbox(list, "egresos");
                ListttoDataTableConverter converter = new ListttoDataTableConverter();
                DataTable dt = converter.ToDataTable(list);
                this.creacionDePalletBindingSource.DataSource = dt;
                adgv.DataSource = this.creacionDePalletBindingSource;
            }
        }

        private void cb_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_todos.Checked == true)
            {
                cb_piso.Checked = false;
                cb_egresos.Checked = false;
                list.Clear();
                // cargar.cargarPalletPorCheckbox(list, "todos");
                ListttoDataTableConverter converter = new ListttoDataTableConverter();
                DataTable dt = converter.ToDataTable(list);
                this.creacionDePalletBindingSource.DataSource = dt;
                adgv.DataSource = this.creacionDePalletBindingSource;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(DateTime.Now.ToString());
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cofigDatagridView(DataGridView dataGridView)
        {
            dataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            dataGridView.RowHeadersVisible = false;
            dataGridView.GridColor = Color.Black;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.Columns[0].Width = 170;
            dataGridView.Columns[1].Width = 110;
            dataGridView.Columns[2].Width = 150;
            dataGridView.Columns[3].Width = 150;
            dataGridView.Columns[4].Width = 130;
            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[6].Width = 180;
            dataGridView.Columns[7].Width = 180;
            dataGridView.Columns[8].Width = 180;
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //dataGridView.DataSource = ventana.cargarVentana();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PintarDatagrid();
        }

        private void PintarDatagrid([Optional] List<int> valores) {



            foreach (DataGridViewRow rowp in adgv.Rows)
            {
                int kia = rowp.Index - 1;

                if (kia >= 0)
                {
                    int cantidadCajas = Convert.ToInt16(adgv.Rows[kia].Cells[9].Value.ToString());
                    if (cantidadCajas > 0)
                    {
                        adgv.Rows[kia].DefaultCellStyle.BackColor = Color.FromArgb(232, 174, 174);

                    }

                    else
                    {
                        adgv.Rows[kia].DefaultCellStyle.BackColor = Color.FromArgb(232, 229, 135);

                    }


                }
                adgv.ClearSelection();



            }
            if (valores != null)
            {
                foreach (var index in valores)
                {
                    adgv.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(190, 242, 124);
                    adgv.ClearSelection();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // lectura formularioLectura = new lectura();
            //formularioLectura.cargarEnvasesDisponibles(cargar.buscarCantidadCajasSegunCondicionEmbalado(this.cb_condiciones_envalado.Text));
            //formularioLectura.Show();
        }

        private void adgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            
            cargarDatos(index);
        }

        private void cargarDatos(int index)
        {

            if (index >= 0)
            {
                this.txt_peso.Text = "";
                
                up = adgv.Rows[index].Cells[3].Value.ToString();
                cb_envases.Text = adgv.Rows[index].Cells[5].Value.ToString();
                cb_condiciones_envalado.Text = adgv.Rows[index].Cells[7].Value.ToString();
                cb_calibre.Text = adgv.Rows[index].Cells[4].Value.ToString();
                cb_marcas.Text = adgv.Rows[index].Cells[6].Value.ToString();
                cb_fecha.Text = adgv.Rows[index].Cells[0].Value.ToString();
                txt_provisorio.Text = adgv.Rows[index].Cells[1].Value.ToString();
                decimal nroCospel = Convert.ToDecimal(adgv.Rows[index].Cells[1].Value.ToString() == "" ? "0" : adgv.Rows[index].Cells[1].Value.ToString());
                 ventanaInferiors=ventanaCospel.cargarVentanaInferirorCospel(nroCospel);
                cargarDataGridViewVentanaInfeior(ventanaInferiors, adgv.Rows[index].Cells[7].Value.ToString());
                //cargarDataGridViewVentanaInfeior(ventanaCospel.cargarVentanaInferirorCospel(nroCospel), adgv.Rows[index].Cells[7].Value.ToString());



            }




        }
        public void setUsuario(String _usaurio, int _perfil,String _usuarioNombre)
        {
            nombreUsuario= _usuarioNombre;
            perfilUsuario= _perfil;
            this.txt_usuario.Text = _usaurio;

            if (perfilUsuario == 1)
            {
                this.btn_cambio_tapa.Enabled = true;
                this.btn_cambio_tapa.Visible = true;
            }
              
                
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_codigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cargarDataGridViewVentanaInfeior(cargar.resumenPallet(Convert.ToDecimal(cb_codigo.Text)), cb_condiciones_envalado.Text);
        }

        private void cb_condiciones_envalado_SelectedIndexChanged(object sender, EventArgs e)
        {

            totalEnvases = 0;



            foreach (DataGridViewRow rowp in adgv_ventana_inferior.Rows)
            {
                int kia = rowp.Index;
                totalEnvases = totalEnvases + Convert.ToInt16(adgv_ventana_inferior.Rows[kia].Cells[4].Value.ToString());
            }

            cantidadDisponible = cargar.buscarCantidadCajasSegunCondicionEmbalado(this.cb_condiciones_envalado.Text.ToString());

            cantidadDisponible = cantidadDisponible - Convert.ToInt16(totalEnvases);
            this.txt_total_envases.Text = totalEnvases.ToString();
            this.txt_cantidad_disponible.Text = cantidadDisponible.ToString();
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            ventana_cospel ventana_Cospel = new ventana_cospel();
            ventana_Cospel.Show();
            // this.Close();

        }

        private void dgv_pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceCospel = e.RowIndex;
            String envase = "";
            String marca = "";
            String calibre = "";
            String condicionEmbalado = "";
            btn_cerrar_dgv_pedidos.Visible = false;

            envase = dgv_pedidos.Rows[indiceCospel].Cells[5].Value.ToString();
            marca = dgv_pedidos.Rows[indiceCospel].Cells[7].Value.ToString();
            calibre = dgv_pedidos.Rows[indiceCospel].Cells[8].Value.ToString();
            condicionEmbalado = dgv_pedidos.Rows[indiceCospel].Cells[6].Value.ToString();

            this.cargarCampos(dgv_pedidos.Rows[indiceCospel].Cells[0].Value.ToString(), dgv_pedidos.Rows[indiceCospel].Cells[13].Value.ToString(), dgv_pedidos.Rows[indiceCospel].Cells[4].Value.ToString(),
                dgv_pedidos.Rows[indiceCospel].Cells[12].Value.ToString(), "AMARILLO", dgv_pedidos.Rows[indiceCospel].Cells[2].Value.ToString(), dgv_pedidos.Rows[indiceCospel].Cells[1].Value.ToString());

            valores.Clear();
            foreach (var i in ventanaCospel.buscarCodCospel(envase, calibre, marca, condicionEmbalado))
            {
                foreach (DataGridViewRow rowp in adgv.Rows)
                {
                    int kia = rowp.Index - 1;

                    if (kia >= 0)
                    {



                        if (i == adgv.Rows[kia].Cells[1].Value.ToString())
                        {
                            valores.Add(kia);

                        }


                    }

                    adgv.ClearSelection();
                }
            }
            PintarDatagrid(valores);
            dgv_pedidos.Visible = false;
            btn_peso.Visible = true;

        }
        private void dgv_pedidos_Load(object sender, EventArgs e)
        {
            dgv_pedidos.ClearSelection();
        }

        private void cargarCampos(String pedido, String calidad, String destino, String clientes, String colores, String contramarca, String tipo)
        {
            this.txt_pedido.Text = pedido;
            cb_calidad.Text = calidad;
            cb_clientes.Text = clientes;
            cb_destino.Text = destino;
            cb_colores.Text = colores;
            cb_contramarca.Text = contramarca;
            cb_tipo.Text = tipo;
            //txt_provisorio.Text = NroProvisorio;
        }

        private void cb_pedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            // dgv_pedidos.Visible = true;
        }

        private void cb_pedido_MouseClick(object sender, MouseEventArgs e)
        {

            //dgv_pedidos.Visible = true;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            dgv_pedidos.Visible = true;
            btn_cerrar_dgv_pedidos.Visible = true;
            btn_peso.Visible = false;
        }

        private void cb_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetContramarca contramarca = new GetContramarca();
            this.cb_contramarca.Text = contramarca.cargarContramarca(this.cb_clientes.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             lectura = txt_codigo_barra.Text;

            double numericValue;
            lectura = lectura.ToUpper();
            bool isNumber = double.TryParse(lectura, out numericValue);
            if (!isNumber && lectura != "")
           
            {

                

                Validaciones validations = new Validaciones(lectura);


                

                    if (validations.validarEtiquetas(lectura) == "caja" || validations.validarEtiquetas(lectura) == "cospel")
                {
                    
                        BuscarCajas buscarCajas = new BuscarCajas();
                        lectura = buscarCajas.getNroProvisorioSegunCodigoBarraCaja(lectura);
                        if (lectura != "")
                        {
                        decimal decNroCospel = Convert.ToDecimal(lectura.Substring(0, 10));
                        buscarCospel(decNroCospel.ToString());
                        this.txt_codigo_barra.Text = "";
                    }
                        else
                        {
                            this.txt_codigo_barra.Text = "";
                        valores.Clear();
                        PintarDatagrid(valores);
                        this.txt_codigo_barra.Text = "";
                    }
                
                  
                }
                else
                {
                    
                }


            }
        }

        private void buscarCospel(String nroCospel)
        {
            valores.Clear();
            
            foreach (DataGridViewRow rowp in adgv.Rows)
            {
                int kia = rowp.Index - 1;

                if (kia >= 0)
                {



                    if (nroCospel == adgv.Rows[kia].Cells[1].Value.ToString())
                    {
                        cargarDatos(kia);
                        valores.Add(kia);
                        break;

                    }


                }

                adgv.ClearSelection();
            }
            this.txt_codigo_barra.Text = "";
            this.cargarCampos("", "", "", "", "", "", "");
            PintarDatagrid(valores);
        }

        private String getUp()
        {
            return up;
        }

        private void limpiarCampos() {

            adgv_ventana_inferior.DataSource = "";
            this.txt_cod_senasa.Text = "";
            this.cb_condiciones_envalado.Text = "";
            this.cb_destino.Text = "";
            this.cb_envases.Text = "";
            this.txt_peso.Text = "";
            this.txt_cod_senasa.Text = "";
            this.txt_cod_senasa.Text = "";
        }

        public class Validar{

            public static Predicate<String> notNull = d => (d) != "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            String cliente;
            String envase;
            String calidad;
            String codigoSenasa;
            String observaciones;
            String propietario;
            String contramarca;
            String condicionEmbalado;
            String marca;
            String color;
            String variedad;
            String destino;
            String camara;
            decimal peso;
            String calibre;
            String deposito;
            int turno;
            String pedido;
            String usuario;
            CargarPallet pallet = new CargarPallet();
            decimal nroPallet = 0;
            int cantidadCajas = 0;
            String codigoEmpaque;

            BuscarCajas buscarCajas= new BuscarCajas();

            if (txt_cantidad_disponible.Text == "0") {

                if (ComprovacionDeCampos(bandera) == false)
                {
                    if (this.txt_pedido.Text == "")
                    {
                        cargarTablas();
                    }
                    else
                    {

                        bool bandera2 = false;
                        foreach(var index in valores)
                        {

                            //Console.WriteLine(index);
                            if (this.txt_provisorio.Text == (adgv.Rows[index].Cells[1].Value).ToString())
                            {
                                bandera2= true;break;
                            }
                        }
                        if (bandera2 == true)
                        {
                            cargarTablas();
                        }
                        else
                        {
                            MessageBox.Show("No cumple con las condiones de pedidos");
                        }
                       
                    }

                }
            }
            else
            {
                MessageBox.Show("La cantidad de envases no cumple la condicion de embalado");
            }
            

            

                
                

            
            
          

            void cargarTablas(){
                CargarCampos();
               /* nroPallet = pallet.getCodPallet();
                pallet.cargarTablaMovPalletCitrus(nroPallet, cliente, condicionEmbalado, marca, calibre, observaciones, propietario, turno, calidad, contramarca,
                    destino, codigoSenasa, up, color, pedido, usuario, embaladoraAutomatica, peso);*/
                List<String> listaCodEmpaque = new List<String>();

                bool bandera = false;

                foreach (DataGridViewRow rowp in adgv_ventana_inferior.Rows)
                {
                    int kia = rowp.Index;
                    listaCodEmpaque.Add(adgv_ventana_inferior.Rows[kia].Cells[0].Value.ToString());
                }
                List<String> distinctEmpaque = listaCodEmpaque.Distinct().ToList();

                int numeroProvisorio = Convert.ToInt32(this.txt_provisorio.Text);

                /* foreach (var index in distinctEmpaque)
                 {
                     int cantidadDeCajasDeMas = buscarCajas.comprobarKgDisponibles(index, numeroProvisorio, peso);

                     if (cantidadDeCajasDeMas != 0)
                     {
                         bandera= true;
                         MessageBox.Show("Error: la cantidad de cajas se excede en: " + cantidadDeCajasDeMas + " cajas. Perteneciente al codigo de volcado: " + index);
                     }

                 }*/
                String uss = nombreUsuario + "/" + nombreEquipo;
                if (bandera == false)
                {
                    nroPallet = pallet.getCodPallet();
                    
                    pallet.cargarTablaMovPalletCitrus(nroPallet, cliente, condicionEmbalado, marca, calibre, observaciones, propietario, turno, calidad, contramarca,
                        destino, codigoSenasa, up, color, pedido, uss, embaladoraAutomatica, peso);
                    foreach (DataGridViewRow rowp in adgv_ventana_inferior.Rows)
                    {

                        calibre = "";
                        cantidadCajas = 0;
                        int kia = rowp.Index;
                        codigoEmpaque = adgv_ventana_inferior.Rows[kia].Cells[0].Value.ToString();
                        cantidadCajas = Convert.ToInt16(adgv_ventana_inferior.Rows[kia].Cells[4].Value.ToString());
                        calibre = adgv_ventana_inferior.Rows[kia].Cells[3].Value.ToString();

                       //carga de datos en la tabla mov pallet citrus
                        pallet.cargarTablaMovPalletCitrusIngresos(nroPallet, codigoEmpaque, cantidadCajas, calibre);
                    }
                    pallet.updateEnvasesEtiquetasCodPallet(nroPallet, numeroProvisorio);
                    pallet.updateEstadoCospel(numeroProvisorio);
                    //MessageBox.Show("El pallet Nro: " + nroPallet + " Fue creado con exito");
                    Impresion_tarjeton impresion_Tarjeton = new Impresion_tarjeton(nroPallet);
                    
                    
                    //impresion_Tarjeton.setCodigoPallet(nroPallet);
                    impresion_Tarjeton.Show();
                    limpiarCampos();
                    //impresion_Tarjeton.setCodigoPallet(nroPallet);
                    cargarDatagridCospel(selectDateAsStringBefore1, selectDateAsStringAfter1);
                    this.cb_destino.SelectedItem = null;              
                    PintarDatagrid();
                }


            

             
               


            }


             void CargarCampos()
            {
                cliente = cb_clientes.Text;
                envase = cb_envases.Text;
                calibre = cb_calibre.Text;
                calidad = cb_calidad.Text;
                codigoSenasa = txt_cod_senasa.Text;
                propietario = cb_tipo.Text;
                contramarca = cb_contramarca.Text;
                condicionEmbalado = cb_condiciones_envalado.Text;
                marca = cb_marcas.Text;
                color = cb_colores.Text;
                variedad = cb_var.Text;
                destino = cb_destino.Text;
                camara = cb_camara.Text;
                peso = txt_peso.Text is "" ? 0 : Convert.ToInt32(txt_peso.Text);
                calibre = cb_calibre.Text;
                deposito = cb_deposito.Text;
                turno = cb_turno.Text is "" ? 0 : Convert.ToInt32(cb_turno.Text);
                pedido = txt_pedido.Text;
                usuario = "";
                observaciones = txt_obervaciones.Text;
            }
        }

    
       

        private bool verificarConbobox(ComboBox comboBox, String nombre,bool bandera)
        {
            if (bandera == false) { 
            
                if (comboBox.Text == "") {
                bandera = true;
                MessageBox.Show("El campo " + nombre + " esta vacio");
                    return bandera;
                }
                
            }
            return bandera;


        }

        private bool verificarTextbox(TextBox textBox, String nombre, bool bandera)
        {
            if (bandera == false)
            {
                
                    if (textBox.Text == "")
            {
                bandera = true;
                MessageBox.Show("El campo " + nombre + " esta vacio");
                    return bandera;
                }
        
            }
            return bandera;
        }

 

        private bool ComprovacionDeCampos(bool bandera)
        {
            if (ventanaInferiors.Count == 0)
            {
                MessageBox.Show("No se selecciono ningun pallet provisorio");
                bandera = false;
            }
            // bandera = verificarConbobox(cb_clientes, "Cliente", bandera);
            bandera = verificarConbobox(cb_envases, "Envase", bandera);
            bandera =  verificarConbobox(cb_calidad, "Calidad", bandera);
            bandera = verificarConbobox(cb_tipo, "Tipo", bandera);
           // bandera = verificarConbobox(cb_contramarca, "Contramarca", bandera);
            bandera = verificarConbobox(cb_condiciones_envalado, "Condicion de embalado", bandera);
            bandera = verificarConbobox(cb_marcas, "Marca", bandera);
            bandera = verificarConbobox(cb_colores, "Color", bandera);
            bandera = verificarConbobox(cb_destino, "Destino", bandera);
            bandera = verificarConbobox(cb_calibre, "Calibre", bandera);
            bandera = verificarConbobox(cb_deposito, "Deposito de origen", bandera);
            bandera = verificarConbobox(cb_fecha, "Fecha", bandera);
            bandera = verificarConbobox(cb_turno, "Turno", bandera);
            if (cb_destino.Text == "Unión Europea")
            {
                bandera = verificarTextbox(txt_cod_senasa, "Codigo senasa", bandera);
            }
            bandera = verificarTextbox(txt_peso, "Peso", bandera);
            bandera = verificarTextbox(txt_total_envases, "Total_Envases", bandera);

            return bandera;
        }

        private void setEmbaladoraAutomatica (char _embaladoraAutomatica){
            embaladoraAutomatica= _embaladoraAutomatica;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ck_embaladora_automatica.Checked == true)
            {
                setEmbaladoraAutomatica('S');
            }
            else
            {
                setEmbaladoraAutomatica('N');
            }
        }

        private void txt_pedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void adgv_ventana_inferior_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adgv_ventana_inferior_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adgv_ventana_inferior_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            totalEnvases = 0;
            


                foreach (DataGridViewRow rowp in adgv_ventana_inferior.Rows)
                {
                    int kia = rowp.Index;
                    totalEnvases = totalEnvases + Convert.ToInt16(adgv_ventana_inferior.Rows[kia].Cells[4].Value.ToString());
                }

            cantidadDisponible = cargar.buscarCantidadCajasSegunCondicionEmbalado(this.cb_condiciones_envalado.Text.ToString());
            
                cantidadDisponible = cantidadDisponible - Convert.ToInt16(totalEnvases);
                this.txt_total_envases.Text = totalEnvases.ToString();
                this.txt_cantidad_disponible.Text = cantidadDisponible.ToString();
           
           

        }




        private void btn_peso_Click(object sender, EventArgs e)
        {

          
            try
            {
                System.Diagnostics.Process.Start(@"C:\Configuracion Balanza\Balanza.exe");
                String line;
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Configuracion Balanza\\peso.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    this.txt_peso.Text= line;
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

        }
     
     




       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
        {
           
            String data = spPuertos.ReadExisting();
            Console.WriteLine(data);
          

        }

        private void btn_cerrar_dgv_pedidos_Click(object sender, EventArgs e)
        {
            btn_cerrar_dgv_pedidos.Visible= false;
            dgv_pedidos.Visible = false;
            btn_peso.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void cb_clientes_TextChanged(object sender, EventArgs e)
        {
            if (cb_clientes.Text == "")
                cb_contramarca.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CambioDeTapa cambioDeTapa= new CambioDeTapa();
            cambioDeTapa.Show();
        }
    }
}
