using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    public class EmbaladorUpCambioDeTapa
    {
        decimal idEmpleado;
        decimal idVolcado;
        decimal peso;
        String codEmpaque;

        public EmbaladorUpCambioDeTapa(decimal idEmpleado, decimal idVolcado, decimal peso, string codEmpaque)
        {
            this.idEmpleado = idEmpleado;
            this.idVolcado = idVolcado;
            this.peso = peso;
            this.codEmpaque = codEmpaque;
        }

        public decimal IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public decimal IdVolcado { get => idVolcado; set => idVolcado = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public string CodEmpaque { get => codEmpaque; set => codEmpaque = value; }
    }
}
