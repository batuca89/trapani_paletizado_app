using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class VentanaCospel
    {
        String fecha;
        decimal nroCospel;
        String codVolcado;
        String up;
        String calibre;
        String envase;
        String marca;
        String condicionEmbalado;
        int cantidadCajas;
        int cajasFaltantes;
        decimal pesoEstimado;

        public VentanaCospel(string fecha, decimal nroCospel, string codVolcado, string up, string calibre, string envase, string marca, string condicionEmbalado, int cantidadCajas, int cajasFaltantes, decimal pesoEstimado)
        {
            this.fecha = fecha;
            this.nroCospel = nroCospel;
            this.codVolcado = codVolcado;
            this.up = up;
            this.calibre = calibre;
            this.envase = envase;
            this.marca = marca;
            this.condicionEmbalado = condicionEmbalado;
            this.cantidadCajas = cantidadCajas;
            this.cajasFaltantes = cajasFaltantes;
            this.pesoEstimado = pesoEstimado;
        }

        public string Fecha { get => fecha; set => fecha = value; }
        public decimal NroCospel { get => nroCospel; set => nroCospel = value; }
        public string CodVolcado { get => codVolcado; set => codVolcado = value; }
        public string Up { get => up; set => up = value; }
        public string Calibre { get => calibre; set => calibre = value; }
        public string Envase { get => envase; set => envase = value; }
        public string Marca { get => marca; set => marca = value; }
        public string CondicionEmbalado { get => condicionEmbalado; set => condicionEmbalado = value; }
        public int CantidadCajas { get => cantidadCajas; set => cantidadCajas = value; }
        public int CajasFaltantes { get => cajasFaltantes; set => cajasFaltantes = value; }
        public decimal PesoEstimado { get => pesoEstimado; set => pesoEstimado = value; }
    }
}
