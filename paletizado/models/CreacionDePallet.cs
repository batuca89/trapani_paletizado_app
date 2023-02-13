using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class CreacionDePallet
    {
        String fecha;
        String turno;
        String codigo;
        String codSenasa;
        String marca;
        String envase;
        decimal cantEnvase;
        decimal peso;
        String ups;
        String productos;
        String cliente;
        String calibre;
        String codPedido;
        String destino;
        String condicionEmbalado;
        String calidad;
        String color;
        String variedad;
        String ingresos;
        String embaladoAutomatico;
        String remito;
        String observaciones;
        String propietario;
        String usuarioUltAcceso;
        String fechaCarga;
        String usuario;
        String fechaUltAcceso;

        public CreacionDePallet(string fecha, string turno, string codigo, string codSenasa, string marca, string envase, decimal cantEnvase, decimal peso, string ups, string productos, string cliente, string calibre, string codPedido, string destino, string condicionEmbalado, string calidad, string color, string variedad, string ingresos, string embaladoAutomatico, string remito, string observaciones, string propietario, string usuarioUltAcceso, string fechaCarga, string usuario, string fechaUltAcceso)
        {
            this.fecha = fecha;
            this.turno = turno;
            this.codigo = codigo;
            this.codSenasa = codSenasa;
            this.marca = marca;
            this.envase = envase;
            this.cantEnvase = cantEnvase;
            this.peso = peso;
            this.ups = ups;
            this.productos = productos;
            this.cliente = cliente;
            this.calibre = calibre;
            this.codPedido = codPedido;
            this.destino = destino;
            this.condicionEmbalado = condicionEmbalado;
            this.calidad = calidad;
            this.color = color;
            this.variedad = variedad;
            this.ingresos = ingresos;
            this.embaladoAutomatico = embaladoAutomatico;
            this.remito = remito;
            this.observaciones = observaciones;
            this.propietario = propietario;
            this.usuarioUltAcceso = usuarioUltAcceso;
            this.fechaCarga = fechaCarga;
            this.usuario = usuario;
            this.fechaUltAcceso = fechaUltAcceso;
        }

        public string Fecha { get => fecha; set => fecha = value; }
        public string Turno { get => turno; set => turno = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string CodSenasa { get => codSenasa; set => codSenasa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Envase { get => envase; set => envase = value; }
        public decimal CantEnvase { get => cantEnvase; set => cantEnvase = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public string Ups { get => ups; set => ups = value; }
        public string Productos { get => productos; set => productos = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Calibre { get => calibre; set => calibre = value; }
        public string CodPedido { get => codPedido; set => codPedido = value; }
        public string Destino { get => destino; set => destino = value; }
        public string CondicionEmbalado { get => condicionEmbalado; set => condicionEmbalado = value; }
        public string Calidad { get => calidad; set => calidad = value; }
        public string Color { get => color; set => color = value; }
        public string Variedad { get => variedad; set => variedad = value; }
        public string Ingresos { get => ingresos; set => ingresos = value; }
        public string EmbaladoAutomatico { get => embaladoAutomatico; set => embaladoAutomatico = value; }
        public string Remito { get => remito; set => remito = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string Propietario { get => propietario; set => propietario = value; }
        public string UsuarioUltAcceso { get => usuarioUltAcceso; set => usuarioUltAcceso = value; }
        public string FechaCarga { get => fechaCarga; set => fechaCarga = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string FechaUltAcceso { get => fechaUltAcceso; set => fechaUltAcceso = value; }
    }
}
