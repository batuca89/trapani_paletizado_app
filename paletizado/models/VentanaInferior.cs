using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class VentanaInferior
    {
        String codEmpaque;
        String Origen;
        String up;
        String calibre;
        decimal CantidadEnvases;

        public VentanaInferior(string codEmpaque, string origen, string up, string calibre, decimal cantidadEnvases)
        {
            this.codEmpaque = codEmpaque;
            Origen = origen;
            this.up = up;
            this.calibre = calibre;
            CantidadEnvases = cantidadEnvases;
        }

        public string CodEmpaque { get => codEmpaque; set => codEmpaque = value; }
        public string Origen1 { get => Origen; set => Origen = value; }
        public string Up { get => up; set => up = value; }
        public string Calibre { get => calibre; set => calibre = value; }
        public decimal CantidadEnvases1 { get => CantidadEnvases; set => CantidadEnvases = value; }
    }
}
