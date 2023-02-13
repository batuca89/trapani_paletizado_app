using Gma.QrCodeNet.Encoding.Windows.Render;
using Gma.QrCodeNet.Encoding;
using paletizado.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletizado.view
{
    public partial class Impresion_tarjeton : Form
    {
        //public decimal codPallet;
        public Impresion_tarjeton(decimal codPallet)
        {
            InitializeComponent();
            CargarDatosTarjetonMovPallet cargar = new CargarDatosTarjetonMovPallet();
            BuscarCajas buscar= new BuscarCajas();
            List<TarjetonMovPallet> lista = new List<TarjetonMovPallet>();

            
            lista.AddRange(cargar.buscarCajaSegunCodigoPallets(codPallet));

            this.txt_anio.Text = lista[0].Anio.ToString();
            this.txt_bultos.Text = lista[0].Cajas.ToString();   
            this.txt_calibre.Text = lista[0].Calibre.ToString();
            this.txt_contramarca.Text = lista[0].Contramarca.ToString() +"    " + lista[0].FechaAlReves;
            this.txt_control.Text = lista[0].CodPallet.ToString();
            this.txt_pallet_nro2.Text = codPallet.ToString();
            this.txt_pallet_nro3.Text = codPallet.ToString();
            this.txt_pallet.Text = codPallet.ToString();
            this.txt_envase_infeior.Text = lista[0].Envase.ToString();
            this.txt_peso.Text = lista[0].Peso.ToString();
            this.txt_fecha_senasa.Text = lista[0].FechaSenasa.ToString();  
            this.txt_codigo_barra_largo.Text = lista[0].CodigoSenasaLargo.ToString();
            this.txt_producto.Text = lista[0].Produncto.ToString();
            this.txt_marca.Text = lista[0].Marca.ToString();
            this.txt_pedido.Text = lista[0].Pedido.ToString();
            this.txt_id.Text = lista[0].Id.ToString();
            this.txt_envase1.Text = lista[0].Envase + " " + lista[0].Cajas.ToString() +" " + lista[0].Calibre.ToString();
            this.txt_envase2.Text = lista[0].Envase + " " + lista[0].Cajas.ToString() + " " + lista[0].Calibre.ToString();
            img_codigo_barra_largo.Image = codigoBarra(lista[0].CodigoSenasaLargo.ToString(), 312, 95, false);
            img_codigo_barrra_corto1.Image = codigoBarra(lista[0].CodigoSenasaCorto.ToString(), 312, 95, false);
            txt_codigo_barra_corto2.Text = lista[0].CodigoSenasaCorto.ToString();
            txt_codigo_barra_corto1.Text = lista[0].CodigoSenasaCorto.ToString();
            img_codigo_barra_corto2.Image = codigoBarra(lista[0].CodigoSenasaCorto.ToString(), 350, 100, false);
            codigoQr();
            img_logo.SizeMode = PictureBoxSizeMode.StretchImage; 
            img_logo2.SizeMode = PictureBoxSizeMode.StretchImage;
            img_logo3.SizeMode= PictureBoxSizeMode.StretchImage;
            txt_pagina.Text = "https://vicentetrapani.com";
            
            this.txt_envase2.SelectionStart = 0;
            dgv_ups.Columns[0].HeaderText = "Ups";
            dgv_ups.Columns[1].HeaderText = "Certificado";
            dgv_ups.Columns[2].HeaderText = "Cajas";
            dgv_calibres.Columns[0].HeaderText = "Calibres";
            dgv_calibres.Columns[1].HeaderText = "Cajas";
            dgv_ups.DataSource = buscar.getTarjetonUp(codPallet);
            dgv_calibres.DataSource = buscar.getTarjetonCalibre(codPallet);
            
            
            
        }

        private void dataGridViewConfig(DataGridView dgv)
        {
            dgv.RowHeadersVisible= false;
            dgv.ClearSelection();
            dgv.CurrentCell = null;
            //dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        public void setCodigoPallet(decimal Valor)
        {
            //codPallet= Valor;
        }
        private void codigoQr()
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode("https://vicentetrapani.com", out qrCode);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(100, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imagenTemporar = new Bitmap(ms);
            var imagen = new Bitmap(imagenTemporar, new Size(new Point(236, 218)));
            img_qr.BackgroundImage = imagen;
            this.img_qr.Image = imagen;
            img_qr.SizeMode = PictureBoxSizeMode.StretchImage;


        }
        private Image codigoBarra(String texto, int ancho, int largo, bool rotar)
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = false;
            var imgCodigo = Codigo.Encode(BarcodeLib.TYPE.CODE128, texto, Color.Black, Color.White, ancho, largo);

            if (rotar == true)
            {
                imgCodigo.RotateFlip(RotateFlipType.Rotate90FlipY);
            }
            return imgCodigo;
        }

        private void panel_general_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void img_codigo_barra_largo_Click(object sender, EventArgs e)
        {

        }

        private void img_logo2_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_barra_largo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_pallet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_control_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(panel_general.Width, panel_general.Height, panel_general.CreateGraphics());
            panel_general.DrawToBitmap(bmp, new Rectangle(0, 0, panel_general.Width, panel_general.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, 1120, factor * 1310);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                dataGridViewConfig(dgv_ups);
                dataGridViewConfig(dgv_calibres);

                //printDocument1.Print();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
