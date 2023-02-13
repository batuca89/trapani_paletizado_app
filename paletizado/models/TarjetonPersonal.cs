using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    public class TarjetonPersonal
    {
       public String empleado;
        public int cajas;

        public TarjetonPersonal(string empleado, int cajas)
        {
            this.empleado = empleado;
            this.cajas = cajas;
        }

        public string Empleado { get => empleado; set => empleado = value; }
        public int Cajas { get => cajas; set => cajas = value; }
    }
}
