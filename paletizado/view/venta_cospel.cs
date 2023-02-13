using paletizado.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletizado.view
{
    public partial class venta_cospel : Form
    {
        public venta_cospel()
        {
            InitializeComponent();
            CargarVentanaCospel ventana = new CargarVentanaCospel();
            List<VentanaCospel> listaCospel= new List<VentanaCospel>();
             adgv_cospel.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
             adgv_cospel.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16);
             adgv_cospel.RowHeadersVisible = false;
             adgv_cospel.GridColor = Color.Black;
             adgv_cospel.BorderStyle = BorderStyle.Fixed3D;
             adgv_cospel.Columns[0].Width = 170;
             adgv_cospel.Columns[1].Width = 110;
             adgv_cospel.Columns[2].Width = 150;
             adgv_cospel.Columns[3].Width = 150;
             adgv_cospel.Columns[4].Width = 170;
             adgv_cospel.Columns[5].Width = 100;
             adgv_cospel.Columns[6].Width = 180;
             adgv_cospel.Columns[7].Width = 180;
            adgv_cospel.Columns[8].Width = 180;
            adgv_cospel.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
             adgv_cospel.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            
            adgv_cospel.DataSource = ventana.cargarVentana();


            

            
        }

        private void venta_cospel_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewRow rowp in adgv_cospel.Rows)
            {
                int kia = rowp.Index;
                int cantidadCajas = Convert.ToInt16(adgv_cospel.Rows[kia].Cells[8].Value.ToString());


                if (cantidadCajas >0 )
                {
                    adgv_cospel.Rows[kia].DefaultCellStyle.BackColor = Color.FromArgb(196, 240, 139);
                }


                else 
                {
                    adgv_cospel.Rows[kia].DefaultCellStyle.BackColor = Color.FromArgb(232, 174, 174);
                }
            }

        
        }

        
        

        private void adgv_cospel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adgv_cospel_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            this.ventanaCospelBindingSource.Filter = this.adgv_cospel.FilterString;
            adgv_cospel.DataSource.ToString();
           
        }

        private void adgv_cospel_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            this.ventanaCospelBindingSource.Sort = this.adgv_cospel.SortString;
           
        }
    }
}



