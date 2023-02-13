using FluentValidation;
using FluentValidation.Results;
using MySql.Data.MySqlClient;
using paletizado.controller;
using paletizado.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace paletizado.view
{
    public partial class lectura : Form
    {
        String lecturaScanner = "";
        String codigoCaja = "";
        public String codigoUp = "";
        public String codigoEmbalador = "";
        bool banderaCaja = false;
        bool banderaUp = false;
        bool banderaEmbalador = false;
        BuscarCajas buscar = new BuscarCajas();
        public List<LecturaCajas> caja = new List<LecturaCajas>();
        public List<LecturaCajas> comprobacion = new List<LecturaCajas>();
        ListttoDataTableConverter converter = new ListttoDataTableConverter();
        int cantidadEnvasesDisponibles =0;
        int cajasLeidas = 0;
        public String nombreEnvase;
        public String nombreMarca;
        public String nombreCalibre;
        public String condicionEmbalado;
        public String cospelNro;
        public bool cambioDeTapa = false;
        public decimal nroPallet;
        public List<EmbaladorUpCambioDeTapa> listaCambioDeTapa = new List<EmbaladorUpCambioDeTapa>();


        public lectura()
        {
            InitializeComponent();
            txt_error.ForeColor = System.Drawing.Color.Red;
            this.txt_cajas_leidas.Text = "0";
            CargarComboboxCalibre cbCalibre = new CargarComboboxCalibre();
            cbCalibre.cargarCalibre(cb_calibre);
            CargarComboboxCondicionesEnvalado cbCondicionEmbalado = new CargarComboboxCondicionesEnvalado();
            cbCondicionEmbalado.cargarCondicionesEnvalado(this.cb_condicion_embalado);
            this.cb_calibre.DropDownStyle = ComboBoxStyle.DropDownList;
            this.txt_cospel_nro.Text = cospelNro;
            if (cambioDeTapa == true && nroPallet != -1)
            {
                listaCambioDeTapa.AddRange(buscar.getEmbaladorYupCambioTapa(nroPallet));
            }

        }



        public void updateList(String up, String id_empleado)
        {
            comprobacion[0].Up = up;
            comprobacion[0].Empleado = id_empleado;

        }
        public void setNroDePallet(decimal valor)
        {
            nroPallet = valor;
        }

        public void cambioDeTapaPorCaja(List<EmbaladorUpCambioDeTapa> valor)
        {
            listaCambioDeTapa.Clear();
            listaCambioDeTapa.AddRange(valor);
            cambioDeTapa = true;
        }
        public void setListaCambioDeTapa(List<EmbaladorUpCambioDeTapa> valor)
        {
            listaCambioDeTapa.Clear();
            listaCambioDeTapa.AddRange(valor);
        }
        public void setCambioDeTapa(bool valor)
        {
            cambioDeTapa = valor;
        }

        public void setPeso(String _nombreEnvase)
        {
            nombreEnvase = _nombreEnvase;
        }

        public void setMarca(String _nombreMarca, String _nombreEnvase, String _calibre, String _CondicionEmbalado, String _cospelNro)
        {
            nombreMarca = _nombreMarca;
            this.txt_marca.Text = _nombreMarca;
            nombreEnvase = _nombreEnvase;
            nombreCalibre = _calibre;
            //this.txt_.Text = _calibre;
            this.cb_calibre.Text = _calibre;
            this.cb_condicion_embalado.Text = _CondicionEmbalado;
            this.txt_cospel_nro.Text = _cospelNro;
            cospelNro = _cospelNro;
            condicionEmbalado = _CondicionEmbalado;
        }



        public void updateTxtUp(String up)
        {

            this.txt_up.Text = up;
            this.txt_up.BackColor = System.Drawing.Color.GreenYellow;
        }



        public void cargarDataGridView(List<LecturaCajas> lista)
        {


            caja.AddRange(lista);
            this.txt_cajas_leidas.Text = caja.Count.ToString();
            this.txt_cajas_leidas.BackColor = System.Drawing.Color.GreenYellow;

            DataTable dtDatos = new DataTable();
            dtDatos = converter.ToDataTable(caja);
            dgv.DataSource = dtDatos;
            dgv.Refresh();
        }

        public void updateTxtEmpleado(String empleado)
        {

            this.txt_empleado.Text = empleado;
            this.txt_empleado.BackColor = System.Drawing.Color.GreenYellow;
        }

        public void updateTxtError(String error)
        {

            this.txt_error.Text = error;

        }
        public void updateTxtErrorDesdeLecturaUpEmbalador()
        {

            txt_error.BackColor = Color.FromArgb(150, 237, 109);
            txt_error.ForeColor = Color.Black;
            txt_error.Text = "Caja leida correctamente";

        }




       /* public void cargarEnvasesDisponibles(int envasesDisponibles, [Optional] int cantidadCajas)
        {
            cajasLeidas = cantidadCajas;
            cantidadEnvasesDisponibles = envasesDisponibles - cajasLeidas;
            this.txt_envases_disponibles.Text = cantidadEnvasesDisponibles.ToString();
        }
       */
       /* public void ActualizarEnvasesDisponibles(int envases)
      
            {
            if (envases < 5)
            {
                txt_envases_disponibles.BackColor = System.Drawing.Color.OrangeRed;
            }
            else
            {
                txt_envases_disponibles.BackColor = System.Drawing.Color.GreenYellow;
            }

           // cantidadEnvasesDisponibles = envases - 1;
            cajasLeidas = cajasLeidas +1;
           
        }
       */
        public void CargarDatos(String lectura)
        
        {
            cajasLeidas = 0;
            int cajasDisponibles = 0;
            caja.Clear();
            List<LecturaCajas> lecturaCajas= new List<LecturaCajas>();
            CargarVista cargar = new CargarVista();
            decimal buscarcospelNro = Convert.ToDecimal(lectura.Substring(0, 10));
            cospelNro = buscarcospelNro.ToString();
            List<SetHeaderDatos> listaDatos = new List<SetHeaderDatos>();
            listaDatos.AddRange(buscar.buscarCospelTablaCospel(buscarcospelNro));
            lecturaCajas = buscar.buscarCajaSegunCodigoCospel(buscarcospelNro);
            cajasLeidas = lecturaCajas.Count();
            cajasDisponibles = cargar.buscarCantidadCajasSegunCondicionEmbalado(listaDatos[0].CodicionEmbalado);
            //updatesCajasLeidasYEnvasesDisponibles(cajasLeidas.ToString(), cajasDisponibles.ToString());
            //cargarEnvasesDisponibles(cajasDisponibles,cajasLeidas);
            setMarca(listaDatos[0].Marca, listaDatos[0].Envase, listaDatos[0].Calibre, listaDatos[0].CodicionEmbalado, buscarcospelNro.ToString());
            cargarDataGridView(lecturaCajas);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void valicacionesLecturaCambioTapa(List<LecturaCajas> name, String codigoBarraCaja, String CodPallet, String nombreMarcas, String NombreEnvases, String NombreCalibres, int envasesDisponibles)
        {
            String errores = "";
            var validations = new ValicacionesLectura(name, codigoBarraCaja, CodPallet, nombreMarcas, NombreEnvases, NombreCalibres, envasesDisponibles);

            ValidationResult result = validations.Validate(name, options => options.IncludeRuleSets("lectura"));
            if (!result.IsValid)
            {

                foreach (var errors in result.Errors)
                {

                    pintarErrores(errors.ErrorMessage, errors.PropertyName);

                }


            }
            else
            {
                this.txt_error.Text = "Caja leida correctamente";
                decimal id_empleado_decimal = 0;
                decimal id_volcado_decimal = 0;
                decimal cospel_Decimal = 0;
                try
                {

                    id_empleado_decimal = Convert.ToDecimal(comprobacion[0].Empleado);
                    id_volcado_decimal = Convert.ToDecimal(comprobacion[0].Id_volcado);
                    cospel_Decimal = Convert.ToDecimal(cospelNro);
                }
                catch (Exception xe)
                {
                    System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + xe.Message);
                }

                buscar.updateEnvasesEtiquetasCambioTapa(listaCambioDeTapa[0].IdEmpleado, listaCambioDeTapa[0].IdVolcado, listaCambioDeTapa[0].Peso, Convert.ToDecimal(cospelNro), lecturaScanner);
                txt_up.Text = comprobacion[0].Up;
                txt_empleado.Text = buscar.getEmpleado(comprobacion[0].Empleado);
              
                    updateTxtErrorDesdeLecturaUpEmbalador();
                int envasesRestantes = Convert.ToInt16(txt_envases_disponibles.Text);
                //ActualizarEnvasesDisponibles(envasesRestantes);
                cargarDataGridView(comprobacion);
                listaCambioDeTapa.RemoveAt(0);
            }
        }

        private void validadionesYlecturas(List<LecturaCajas> name, String codigoBarraCaja, String CodPallet, String nombreMarcas, String NombreEnvases, String NombreCalibres, int envasesDisponibles)
        {
            String errores = "";
            var validations = new ValicacionesLectura(name, codigoBarraCaja, CodPallet, nombreMarcas, NombreEnvases, NombreCalibres, envasesDisponibles);

            ValidationResult result = validations.Validate(name, options => options.IncludeRuleSets("lectura"));
            if (!result.IsValid)
            {

                foreach (var errors in result.Errors)
                {

                    pintarErrores(errors.ErrorMessage, errors.PropertyName);

                }


            }
            else
            {
                // cuando  la etiqueta fue leida en linea 
                ValidationResult result2 = validations.Validate(name, options => options.IncludeRuleSets("idVolcadoIdEmpleado"));
                if (!result2.IsValid)
                {

                    CargarDatosLeidosScada();
                    
                    //int cajasDisponibles = Convert.ToInt16(txt_envases_disponibles.Text);
                    //cajasDisponibles -= 1;
                    //txt_envases_disponibles.Text=cajasDisponibles.ToString();   
                }
                else
                {
                    // cuando la etiqueta no fue leida por la linea
                    foreach (var errors in result.Errors)
                    {
                        this.txt_error.Text = errors.ErrorMessage;
                    }
                    CargarDatosLeidosPaletizado();

                }
            }
        }

        public void updatesCajasLeidasYEnvasesDisponibles(String _cajasLeidas, String _cajasDisponibles)
        {
            cajasLeidas=0;
            int cajasDisponibles=0;
            bool successCajasLeidas = int.TryParse(_cajasLeidas, out cajasLeidas);
            bool successCajasDisponibles = int.TryParse(_cajasDisponibles, out cajasDisponibles);

          
            cajasLeidas+= 1;
            this.txt_cajas_leidas.Text  = cajasLeidas.ToString();
            cajasDisponibles-= 1;
            this.txt_envases_disponibles.Text= cajasDisponibles.ToString();
            if (cajasDisponibles < 5)
            {
                txt_envases_disponibles.BackColor = System.Drawing.Color.OrangeRed;
            }
            else
            {
                txt_envases_disponibles.BackColor = System.Drawing.Color.GreenYellow;
            }


        }

        private void pintarErrores(String Error, String nombreError)
        {
            if (nombreError == "Calibre" || nombreError == "Marca" || nombreError == "Envase")
            {
                txt_error.BackColor = Color.FromArgb(219, 105, 105);
                txt_error.ForeColor = Color.Black;

            }
            else
            {
                txt_error.BackColor = Color.FromArgb(242, 232, 136);
                txt_error.ForeColor = Color.Black;
            }
            this.txt_error.Text = Error;

        }

        private void CargarDatosLeidosPaletizado() {
            lectura_up_personal lectura_Up_Personal = new lectura_up_personal(comprobacion);
            lectura_Up_Personal.getCodigoBarraCaja(txt_lectura.Text);
            lectura_Up_Personal.getLista(comprobacion);
            lectura_Up_Personal.saveList(caja);
            lectura_Up_Personal.getCajas(this.txt_envases_disponibles.Text);
            lectura_Up_Personal.peso(buscar.getPesoCaja(nombreEnvase));
            lectura_Up_Personal.setMarca(nombreMarca, nombreEnvase, nombreCalibre, condicionEmbalado, cospelNro);

            lectura_Up_Personal.Show();
            this.Close();
        }

        private void CargarDatosLeidosScada()
        {
            this.txt_error.Text = "Caja leida correctamente";
            decimal id_empleado_decimal = 0;
            decimal id_volcado_decimal = 0;
            decimal cospel_Decimal = 0;
            try
            {

                id_empleado_decimal = Convert.ToDecimal(comprobacion[0].Empleado);
                id_volcado_decimal = Convert.ToDecimal(comprobacion[0].Id_volcado);
                cospel_Decimal = Convert.ToDecimal(cospelNro);
            }
            catch (Exception xe)
            {
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + xe.Message);
            }




            buscar.updateEnvasesEtiquetasSegunCospel(id_empleado_decimal, id_volcado_decimal, comprobacion[0].Peso, cospel_Decimal, comprobacion[0].Lectura, false);
            txt_up.Text = comprobacion[0].Up;
            txt_empleado.Text = buscar.getEmpleado(comprobacion[0].Empleado);
            updateTxtErrorDesdeLecturaUpEmbalador();
            //int envasesRestantes = Convert.ToInt16(txt_envases_disponibles.Text);
            //ActualizarEnvasesDisponibles(envasesRestantes);
            updatesCajasLeidasYEnvasesDisponibles(this.txt_cajas_leidas.Text,this.txt_envases_disponibles.Text);
            cargarDataGridView(comprobacion);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {

            //txt_up.Text = "";
            txt_up.BackColor = Color.White;
            txt_empleado.BackColor = Color.White;
            //txt_empleado.Text = "";
            lecturaScanner = (txt_lectura.Text).Trim().ToUpper();

            if (lecturaScanner == "")
            {

            }
            else
            {

                double numericValue;

                bool isNumber = double.TryParse(lecturaScanner, out numericValue);
                if (!isNumber)
                {



                    Validaciones validations = new Validaciones(lecturaScanner);
                    if (validations.validarEtiquetas(lecturaScanner) == "caja" || validations.validarEtiquetas(lecturaScanner) == "cospel")
                    {
                        txt_error.Text = "";
                        if (lecturaScanner.Last() == 'C')
                        {
                            txt_lectura.Focus();
                            codigoCaja = txt_lectura.Text;
                            banderaCaja = true;
                            comprobacion.Clear();

                            comprobacion.AddRange(buscar.buscarCaja(codigoCaja));


                            if (comprobacion.Count == 0)
                            {
                                txt_error.Text = "La caja no existe";
                            }
                            else
                            {
                                BuscarCodPallet pallet = new BuscarCodPallet();


                                if (cambioDeTapa == true)
                                {
                                    if (listaCambioDeTapa.Count <= 0)
                                    {
                                        txt_error.Text="Supera la cantidad de cajas leidas para el cambio de tapa";
                                        txt_error.BackColor = Color.FromArgb(219, 105, 105);
                                        txt_error.ForeColor = Color.Black;
                                    }
                                    else { 
                                    //if (listaCambioDeTapa.Count > 0) {

                                        comprobacion[0].Empleado = listaCambioDeTapa[0].IdEmpleado.ToString();
                                        comprobacion[0].Id_volcado = listaCambioDeTapa[0].IdVolcado.ToString();
                                        comprobacion[0].Peso = listaCambioDeTapa[0].Peso;
                                        comprobacion[0].CodEmpaque = listaCambioDeTapa[0].CodEmpaque.ToString();
                                        valicacionesLecturaCambioTapa(comprobacion, lecturaScanner, pallet.getPallet(comprobacion[0].Id_pallet).ToString(), nombreMarca, nombreEnvase, nombreCalibre, Convert.ToInt32(this.txt_envases_disponibles.Text));
                                        //buscar.updateEnvasesEtiquetasCambioTapa(listaCambioDeTapa[0].IdEmpleado, listaCambioDeTapa[0].IdVolcado, listaCambioDeTapa[0].Peso, Convert.ToDecimal(cospelNro), lecturaScanner);

                                    //}
                                    }
                                }
                                else {

                                    validadionesYlecturas(comprobacion, lecturaScanner, pallet.getPallet(comprobacion[0].Id_pallet).ToString(), nombreMarca, nombreEnvase, nombreCalibre, Convert.ToInt32(this.txt_envases_disponibles.Text));
                                }
                            }
                        
                            txt_lectura.Text = "";



                        }
                        else
                        {

                            if (cambioDeTapa == true)
                            {
                                txt_error.Text = "No se puede leer esta etiqueta debido a que esta en cambio de tapa";
                                this.txt_lectura.Text = "";
                            }
                            else {


                                //if (lecturaScanner.Last() == 'P' && lecturaScanner.Length == 11)
                                //{
                                txt_error.BackColor = Color.White;
                                caja.Clear();
                                CargarVista cargar = new CargarVista();


                                decimal buscarcospelNro = Convert.ToDecimal(lecturaScanner.Substring(0, 10));
                                cospelNro = buscarcospelNro.ToString();





                                List<SetHeaderDatos> listaDatos = new List<SetHeaderDatos>();
                                listaDatos.AddRange(buscar.buscarCospelTablaCospel(buscarcospelNro));

                                // aqui modifique

                                //cargarEnvasesDisponibles(cargar.buscarCantidadCajasSegunCondicionEmbalado(listaDatos[0].CodicionEmbalado) - listaDatos[0].CantidadEnvases);
                                setMarca(listaDatos[0].Marca, listaDatos[0].Envase, listaDatos[0].Calibre, listaDatos[0].CodicionEmbalado, buscarcospelNro.ToString());
                                cargarDataGridView(buscar.buscarCajaSegunCodigoCospel(buscarcospelNro));
                                //updatesCajasLeidasYEnvasesDisponibles(caja.Count.ToString(), this.txt_envases_disponibles.Text);

                                txt_lectura.Text = "";
                                this.txt_cospel_nro.Text = "";
                                txt_cospel_nro.Text = buscarcospelNro.ToString();

                                //aqui modifique

                                
                               setMarca(caja[0].Marca, caja[0].Envase, caja[0].Calibre, caja[0].LeidaEn, cospelNro);
                               //cargarEnvasesDisponibles(cargar.buscarCantidadCajasSegunCondicionEmbalado(caja[0].LeidaEn) - caja.Count);
                               
                                //}


                            }

                        }

                    }
                    else
                    {
                        txt_error.Text = "Lectura incorrecta: el codigo no corresponde a una etiqueta de caja";
                        this.txt_lectura.Text = "";
                    }

                }
                /* else
                 {
                     txt_error.Text = "Lectura incorrecta: el codigo no corresponde a una etiqueta de caja  o provisorio";
                     // this.txt_lectura.Text = "";
                 }
                */






            }



        }

        private void txt_lectura_ModifiedChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_error_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_up_TextChanged(object sender, EventArgs e)
        {

        }

        public class Validar
        {
            public static Predicate<List<LecturaCajas>> notNull = d => (d).Count() != 0;
            public static Predicate<String> errorCaja = d => Convert.ToInt16((d)) < 0;
        }



 

        private void button1_Click(object sender, EventArgs e)
        {
             if (Validar.notNull(caja))
            //if (validarError())
            {
                if (!Validar.errorCaja(this.txt_envases_disponibles.Text))
                {
                    tarjeton tar = new tarjeton();

                    tar.cargarVolcadoEnTabla(caja);
                    setCambioDeTapa(false);

                    listaEmpaque();


                    //agrupacion.ForEach(i => Console.WriteLine($"palabra: {i.Text} veces: {i.Count}"));
                    if (caja.Count != 0)
                    {
                        decimal pesoTotal = 0;

                        foreach (var index in caja)
                        {
                            pesoTotal = pesoTotal + index.Peso;
                        }



                        pesoTotal = decimal.Round(pesoTotal, 2);

                        tar.CargarTarjeton(listaEmpaque(), listaPersonal(), listaCalibre(), caja[0].Envase,
                            caja[0].Variedad, caja[0].Marca, pesoTotal, caja.Count, listaUps(), caja, cospelNro, condicionEmbalado, "matias", "Esto es una obervacion");
                        tar.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Error: las cajas leidas superan la condicion de embalado");
                }
                
            }
            else { MessageBox.Show("Error: tiene que haber almenos una caja cargada"); }

          

        }

        private List<TarjetonCalibres> listaCalibre()
        {
            List<TarjetonCalibres> tarjetonCalibres = new List<TarjetonCalibres>();

            var agrupacion = caja.GroupBy(x => x.Calibre)
              .Select(g => new { Text = g.Key, Count = g.Count() }).ToList();

            tarjetonCalibres.Clear();

            for (int j = 0; j < agrupacion.Count; j++)
            {
                TarjetonCalibres empaqueYCajaCorregida = new TarjetonCalibres(agrupacion[j].Text, agrupacion[j].Count);

                tarjetonCalibres.Add(empaqueYCajaCorregida);

            }

            return tarjetonCalibres;
        }


        private List<TarjetonEmpaque> listaEmpaque()
        {
            List<TarjetonEmpaque> lista = new List<TarjetonEmpaque>();

            var agrupacion = caja.GroupBy(x => x.CodEmpaque)
              .Select(g => new { Text = g.Key, Count = g.Count() }).ToList();

            lista.Clear();

            for (int j = 0; j < agrupacion.Count; j++)
            {
                TarjetonEmpaque empaqueYCajaCorregida = new TarjetonEmpaque(agrupacion[j].Text, agrupacion[j].Count);

                lista.Add(empaqueYCajaCorregida);

            }

            return lista;
        }


        private List<TarjetonUp> listaUps()
        {
            List<TarjetonUp> lista = new List<TarjetonUp>();

            var agrupacion = caja.GroupBy(x => x.Up)
              .Select(g => new { Text = g.Key, Count = g.Count() }).ToList();

            lista.Clear();

            for (int j = 0; j < agrupacion.Count; j++)
            {
                TarjetonUp empaqueYCajaCorregida = new TarjetonUp(agrupacion[j].Text, agrupacion[j].Count);

                lista.Add(empaqueYCajaCorregida);

            }

            return lista;
        }


        /*  private List<String> listaUp()
          {
              List<String> list = new List<String>();
              foreach(var indexcaja in caja)
              {
                  foreach(var indexvolcado in listaEmpaque())
                  {
                      if(indexcaja.CodEmpaque == indexvolcado.Empaque)
                      {
                          list.Add(indexcaja.Up);
                      }
                  }
              }

              return list;
          }
        */
        private List<TarjetonPersonal> listaPersonal()
        {
            List<TarjetonPersonal> tarjetonPersonals = new List<TarjetonPersonal>();
            var agrupacion = caja.GroupBy(x => x.NombreEmpleado)
              .Select(g => new { Text = g.Key, Count = g.Count() }).ToList();

            tarjetonPersonals.Clear();

            for (int j = 0; j < agrupacion.Count; j++)
            {
                TarjetonPersonal empaqueYCajaCorregida = new TarjetonPersonal(agrupacion[j].Text, agrupacion[j].Count);

                tarjetonPersonals.Add(empaqueYCajaCorregida);

            }

            return tarjetonPersonals;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EtiquetaProvisoria et = new EtiquetaProvisoria();
            et.cargarComponentes(nombreCalibre, nombreMarca, condicionEmbalado, cospelNro, nombreEnvase);
            et.Show();
        }

        private void txt_calibre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_calibre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            nombreCalibre = cb_calibre.Text;
            this.txt_lectura.Focus();
        }

        private void cb_condicion_embalado_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                CargarVista cargar = new CargarVista();
            int cajasDisponibles = cargar.buscarCantidadCajasSegunCondicionEmbalado(this.cb_condicion_embalado.Text);
            int cajasResultates = cajasDisponibles - cajasLeidas;
            this.txt_envases_disponibles.Text= cajasResultates.ToString();
            if (cajasResultates >= 0)
            {
                condicionEmbalado = cb_condicion_embalado.Text;
            }
            else
                MessageBox.Show("Las cajas leidas superan la condicion de embalado ");
                    

            this.txt_lectura.Focus();
        }

        private void txt_envases_disponibles_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
