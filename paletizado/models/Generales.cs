using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class Generales
    {
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

        public Image ImagecodigoBarra(String texto, int ancho, int largo, bool rotar)
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
    }
}
