using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class CambioDeTapaPorCadaCaja
    {
        decimal id_empleado;
        decimal id_empaque_volcado;
        decimal peso_caja;
        String cod_empaque;
        String codigo_barra;

        public CambioDeTapaPorCadaCaja(decimal id_empleado, decimal id_empaque_volcado, decimal peso_caja, string cod_empaque, string codigo_barra)
        {
            this.id_empleado = id_empleado;
            this.id_empaque_volcado = id_empaque_volcado;
            this.peso_caja = peso_caja;
            this.cod_empaque = cod_empaque;
            this.codigo_barra = codigo_barra;
        }

        public decimal Id_empleado { get => id_empleado; set => id_empleado = value; }
        public decimal Id_empaque_volcado { get => id_empaque_volcado; set => id_empaque_volcado = value; }
        public decimal Peso_caja { get => peso_caja; set => peso_caja = value; }
        public string Cod_empaque { get => cod_empaque; set => cod_empaque = value; }
        public string Codigo_barra { get => codigo_barra; set => codigo_barra = value; }
    }
}