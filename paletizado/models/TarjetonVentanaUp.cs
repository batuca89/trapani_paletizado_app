using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class TarjetonVentanaUp
    {
        String Up;
        String Certificado;
        String Cajas;

        public TarjetonVentanaUp(string up, string certificado, string cajas)
        {
            Up = up;
            Certificado = certificado;
            Cajas = cajas;
        }

        public string Up1 { get => Up; set => Up = value; }
        public string Certificado1 { get => Certificado; set => Certificado = value; }
        public string Cajas1 { get => Cajas; set => Cajas = value; }
    }
}
