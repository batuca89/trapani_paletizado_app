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
    public partial class CambioTapaPorCaja : Form
    {
        List<CambioDeTapaPorCadaCaja> comprobacion = new List<CambioDeTapaPorCadaCaja>();
        List<CambioDeTapaPorCadaCaja> caja = new List<CambioDeTapaPorCadaCaja>();
        BuscarCajaCambioTapaPorCaja buscarCaja = new BuscarCajaCambioTapaPorCaja();
        ListttoDataTableConverter converter = new ListttoDataTableConverter();

        public CambioTapaPorCaja()
        {
            InitializeComponent();
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                
                if (this.txt_lectura.Text != "") {
                if (this.txt_lectura.Text.Length> 10)
                {
                    String lectura = this.txt_lectura.Text;
                    Validaciones validations = new Validaciones(lectura);
                    if (validations.validarEtiquetas(lectura) == "caja")
                    {
                        this.txt_lectura.Text = "";
                        
                        
                            comprobacion = buscarCaja.buscarCajaCambioTapaporCaja(lectura);
                        
                        if (comprobacion.Count != 0)
                        {
                            bool isRepetida = false;

                            if (caja.Count > 0)
                            {
                                foreach(var index in caja)
                                {
                                    if (index.Codigo_barra == comprobacion[0].Codigo_barra)
                                    {
                                       isRepetida = true;
                                        break;
                                    }
                                   
                                }
                            }
                      


                            if (isRepetida==false)
                            {
                                caja.AddRange(comprobacion);
                                DataTable dtDatos = new DataTable();
                                dtDatos = converter.ToDataTable(caja);
                                dgva.DataSource = dtDatos;
                                dgva.Refresh();
                                this.txt_error.BackColor = Color.GreenYellow;
                                this.txt_error.Text = "Caja leida correctamente";
                            }
                            else
                            {
                                this.txt_error.BackColor = Color.Red;
                                this.txt_error.Text = "La caja ya fue leida";
                            }

                        }
                        else
                        {
                            this.txt_error.BackColor = Color.Red;
                            this.txt_error.Text = "Caja no encontada";
                        }
                    }
                    else
                    {
                        this.txt_error.BackColor = Color.Red;
                        this.txt_error.Text = "La etiqueta no corresponde a una etiqueta de caja";
                    }
                }
            }
            


            
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            List<EmbaladorUpCambioDeTapa> list = new List<EmbaladorUpCambioDeTapa>();
            foreach(var index in caja)
            {
                EmbaladorUpCambioDeTapa lectura = new EmbaladorUpCambioDeTapa(index.Id_empleado,index.Id_empaque_volcado,index.Peso_caja,index.Cod_empaque);
                list.Add(lectura);
                buscarCaja.borrarCajaCambioTapaporCaja(index.Codigo_barra);
            }
            Buscar_cospel cospel = new Buscar_cospel();
            cospel.setCambioDeTapaPorCaja(list);
            cospel.Show();
        }
    }
}
