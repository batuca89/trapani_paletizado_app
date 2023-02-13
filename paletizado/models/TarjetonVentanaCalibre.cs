using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class TarjetonVentanaCalibre
    {
        String Calibres;
        String Cajas;

        public TarjetonVentanaCalibre(string calibres, string cajas)
        {
            Calibres = calibres;
            Cajas = cajas;
        }

        public string Calibres1 { get => Calibres; set => Calibres = value; }
        public string Cajas1 { get => Cajas; set => Cajas = value; }
    }
}
