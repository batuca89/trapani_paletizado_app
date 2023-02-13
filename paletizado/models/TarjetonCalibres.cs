using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    
    public class TarjetonCalibres
    {
        String calibre;
        int cajas;

        public TarjetonCalibres(string calibre, int cajas)
        {
            this.calibre = calibre;
            this.cajas = cajas;
        }

        public string Calibre { get => calibre; set => calibre = value; }
        public int Cajas { get => cajas; set => cajas = value; }
    }
}
