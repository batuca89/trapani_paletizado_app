using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    public class TarjetonUp
    {
        String up;
        int cajas;

        public TarjetonUp(string up, int cajas)
        {
            this.up = up;
            this.cajas = cajas;
        }

        public string Up { get => up; set => up = value; }
        public int Cajas { get => cajas; set => cajas = value; }
    }
}
