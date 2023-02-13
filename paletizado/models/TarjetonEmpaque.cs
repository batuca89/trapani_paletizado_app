using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    public class TarjetonEmpaque
    {

       public String empaque;
        public int cajas;

        public string Empaque { get => empaque; set => empaque = value; }
        public int Cajas { get => cajas; set => cajas = value; }

        public TarjetonEmpaque(string empaque, int cajas)
        {
            this.empaque = empaque;
            this.cajas = cajas;
        }
    }
}
