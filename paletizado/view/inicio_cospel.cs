using paletizado.controller;
using paletizado.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletizado.view
{
    public partial class inicio_cospel : Form
    {
        bool cambioDeTapa = false;
        decimal nroPallet;
        public inicio_cospel()
        {
            InitializeComponent();
           
            CargarComboboxMarcas marcas = new CargarComboboxMarcas();
            marcas.cargarMarcas(cb_marcas);
            CargarComboboxEnvases envases= new CargarComboboxEnvases();
            envases.cargarEnvases(cb_envase);
            CargarComboboxCalibre calibre= new CargarComboboxCalibre();
            calibre.cargarCalibre(cb_calibre);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void setCambioDeTapa(bool valor)
        {
            cambioDeTapa = valor;
        }
        public void setnroPallet(decimal valor)
        {
                nroPallet = valor;
        }
        private void cb_envase_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CargarComboboxCondicionesEnvalado embalado = new CargarComboboxCondicionesEnvalado();
            embalado.cargarCondicionesEnvaladoSegunEnvase(cb_condicion_embalado ,cb_envase.Text.ToString());
        }

        private void cb_condicion_embalado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public class Validar
        {
            public static Predicate<String> notNull = (d) => d != "";
        }

        public bool validate() {
            bool bandera = false;
            List<bool> list = new List<bool>();
            list.Add(Validar.notNull(this.cb_calibre.Text));
            list.Add(Validar.notNull(this.cb_condicion_embalado.Text));
            list.Add(Validar.notNull(this.cb_envase.Text));
            list.Add(Validar.notNull(this.cb_marcas.Text));

            foreach (var index in list)
            {
                if (index == true)
                    bandera = true;
                break;
            }

            return bandera;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (validate())
            {
                lectura formularioLectura = new lectura();
                BuscarCajas buscar = new BuscarCajas();
                CargarVista cargar = new CargarVista();

                //formularioLectura.cargarEnvasesDisponibles(cargar.buscarCantidadCajasSegunCondicionEmbalado(this.cb_condicion_embalado.Text));
                formularioLectura.setPeso(cb_envase.Text);

                CargarTarjeton tarjeton = new CargarTarjeton();
                String cospelNro;

                cospelNro = tarjeton.getCodCospel();
                decimal cospelConvertido;
                formularioLectura.setMarca(cb_marcas.Text, cb_envase.Text, cb_calibre.Text, cb_condicion_embalado.Text, cospelNro);
                cospelConvertido = cospelNro is null ? 0 : Convert.ToDecimal(cospelNro);
                //tarjeton.crearCospelVacio(cospelConvertido);
                tarjeton.cargarTablaCospel(cospelConvertido, "", cb_envase.Text, "", cb_calibre.Text, 0, cb_marcas.Text, 0, "", "", cb_condicion_embalado.Text, "");
                formularioLectura.Show();
                if (cambioDeTapa == true)
                {
                    formularioLectura.setCambioDeTapa(true);
                    formularioLectura.setNroDePallet(nroPallet);
                    formularioLectura.setListaCambioDeTapa(buscar.getEmbaladorYupCambioTapa(nroPallet));
                    buscar.updateEnvasesEtiquetasNroPalletCambioTapa(nroPallet);


                }
            }
            else
            {
                MessageBox.Show("No puede haber campos vacios");
            }

          

        }
    }
}
