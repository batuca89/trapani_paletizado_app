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
using static System.Net.Mime.MediaTypeNames;

namespace paletizado.view
{
    public partial class EtiquetaProvisoria : Form
    {
        public EtiquetaProvisoria()
        {
            InitializeComponent();
        }

        public void cargarComponentes(String calibre, String marca, String condEmbalado, String cospelNro, String envase)
        {
            Generales gen = new Generales();
            decimal nroCospel = Convert.ToDecimal(cospelNro);
            String codigoBarraFormato = gen.RellenarCadena(nroCospel.ToString(), '0', 10, true) + "P";
            txt_codigo_barra.Text = codigoBarraFormato;
            txt_calibre.Text = calibre;
            txt_con_embalado.Text = condEmbalado.ToString();   
            txt_marca.Text = marca;
            txt_envase.Text = envase;
            txt_cospel_nro.Text = cospelNro;
            picture.Image = gen.ImagecodigoBarra(codigoBarraFormato, 450, 150, false);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //printDocument1.Print();

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height, panel1.CreateGraphics());
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, 420, factor * 420);

            Point ulCorner = new Point(50, 50);
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
