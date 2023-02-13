using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class PedidosProduccion
    {
        decimal nroPedido;
        String Propietario;
        String Contramarca;
        DateTime fecha;
        String destino;
        String envase;
        String condicionEmbalado;
        String marca;
        String calibre;
        int palletPedidos;
        int palletHechos;
        int palletFaltantes;
        String cliente;
        String calidad;

        public PedidosProduccion(decimal nroPedido, string propietario, string contramarca, DateTime fecha, string destino, string envase, string condicionEmbalado, string marca, string calibre, int palletPedidos, int palletHechos, int palletFaltantes, string cliente, string calidad)
        {
            this.nroPedido = nroPedido;
            Propietario = propietario;
            Contramarca = contramarca;
            this.fecha = fecha;
            this.destino = destino;
            this.envase = envase;
            this.condicionEmbalado = condicionEmbalado;
            this.marca = marca;
            this.calibre = calibre;
            this.palletPedidos = palletPedidos;
            this.palletHechos = palletHechos;
            this.palletFaltantes = palletFaltantes;
            this.cliente = cliente;
            this.calidad = calidad;
        }

        public decimal NroPedido { get => nroPedido; set => nroPedido = value; }
        public string Propietario1 { get => Propietario; set => Propietario = value; }
        public string Contramarca1 { get => Contramarca; set => Contramarca = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Envase { get => envase; set => envase = value; }
        public string CondicionEmbalado { get => condicionEmbalado; set => condicionEmbalado = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Calibre { get => calibre; set => calibre = value; }
        public int PalletPedidos { get => palletPedidos; set => palletPedidos = value; }
        public int PalletHechos { get => palletHechos; set => palletHechos = value; }
        public int PalletFaltantes { get => palletFaltantes; set => palletFaltantes = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Calidad { get => calidad; set => calidad = value; }
    }
}
