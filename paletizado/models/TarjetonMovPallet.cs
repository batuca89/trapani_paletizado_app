using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class TarjetonMovPallet
    {
        String codigoSenasaLargo;
        String codigoSenasaCorto;
        int cajas;
        String envase;
        String codPallet;
        String calibre;
        String id;
        String marca;
        String contramarca;
        String anio;
        String fechaSenasa;
        String fechaAlReves;
        String produncto;
        String peso;
        String pedido;

        public TarjetonMovPallet(string codigoSenasaLargo, string codigoSenasaCorto, int cajas, string envase, string codPallet, string calibre, string id, string marca, string contramarca, string anio, string fechaSenasa, string fechaAlReves, string produncto, string peso, string pedido)
        {
            this.codigoSenasaLargo = codigoSenasaLargo;
            this.codigoSenasaCorto = codigoSenasaCorto;
            this.cajas = cajas;
            this.envase = envase;
            this.codPallet = codPallet;
            this.calibre = calibre;
            this.id = id;
            this.marca = marca;
            this.contramarca = contramarca;
            this.anio = anio;
            this.fechaSenasa = fechaSenasa;
            this.fechaAlReves = fechaAlReves;
            this.produncto = produncto;
            this.peso = peso;
            this.pedido = pedido;
        }

        public string CodigoSenasaLargo { get => codigoSenasaLargo; set => codigoSenasaLargo = value; }
        public string CodigoSenasaCorto { get => codigoSenasaCorto; set => codigoSenasaCorto = value; }
        public int Cajas { get => cajas; set => cajas = value; }
        public string Envase { get => envase; set => envase = value; }
        public string CodPallet { get => codPallet; set => codPallet = value; }
        public string Calibre { get => calibre; set => calibre = value; }
        public string Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Contramarca { get => contramarca; set => contramarca = value; }
        public string Anio { get => anio; set => anio = value; }
        public string FechaSenasa { get => fechaSenasa; set => fechaSenasa = value; }
        public string FechaAlReves { get => fechaAlReves; set => fechaAlReves = value; }
        public string Produncto { get => produncto; set => produncto = value; }
        public string Peso { get => peso; set => peso = value; }
        public string Pedido { get => pedido; set => pedido = value; }
    }
}
