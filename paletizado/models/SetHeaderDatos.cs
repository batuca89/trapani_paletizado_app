using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class SetHeaderDatos
    {
        String marca;
        String codicionEmbalado;
        String envase;
        String calibre;
        int cantidadEnvases;

        public SetHeaderDatos(string marca, string codicionEmbalado, string envase, string calibre, int cantidadEnvases)
        {
            this.marca = marca;
            this.codicionEmbalado = codicionEmbalado;
            this.envase = envase;
            this.calibre = calibre;
            this.cantidadEnvases = cantidadEnvases;
        }

        public string Marca { get => marca; set => marca = value; }
        public string CodicionEmbalado { get => codicionEmbalado; set => codicionEmbalado = value; }
        public string Envase { get => envase; set => envase = value; }
        public string Calibre { get => calibre; set => calibre = value; }
        public int CantidadEnvases { get => cantidadEnvases; set => cantidadEnvases = value; }
    }
}
