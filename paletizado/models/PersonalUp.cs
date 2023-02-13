using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class PersonalUp
    {
        String up;
        String empleado;
        decimal cod_empleado;

        public string Up { get => up; set => up = value; }
        public string Empleado { get => empleado; set => empleado = value; }
        public decimal Cod_empleado { get => cod_empleado; set => cod_empleado = value; }
    }
}
