using System;


namespace paletizado.models
{
    public class LecturaCajas
    {
        String lectura;
        String codEmpaque;
        String fechaSenasa;
        String empleado;
        String tarea;
        String concepto;
        String observaciones;
        String up;
        String producto;
        String variedad;
        String marca;
        String calibre;
        String envase;
        String leidaEn;
        String id_volcado;
        decimal id_pallet;
        decimal peso;
        String nombreEmpleado;
        String cod_cospel;

        public LecturaCajas(string lectura, string codEmpaque, string fechaSenasa, string empleado, string tarea, string concepto, string observaciones, string up, string producto, string variedad, string marca, string calibre, string envase, string leidaEn, string id_volcado, decimal id_pallet, decimal peso, string nombreEmpleado, String cod_cospel)
        {
            this.lectura = lectura;
            this.codEmpaque = codEmpaque;
            this.fechaSenasa = fechaSenasa;
            this.empleado = empleado;
            this.tarea = tarea;
            this.concepto = concepto;
            this.observaciones = observaciones;
            this.up = up;
            this.producto = producto;
            this.variedad = variedad;
            this.marca = marca;
            this.calibre = calibre;
            this.envase = envase;
            this.leidaEn = leidaEn;
            this.id_volcado = id_volcado;
            this.id_pallet = id_pallet;
            this.peso = peso;
            this.nombreEmpleado = nombreEmpleado;
            this.cod_cospel = cod_cospel;
        }

        public string Lectura { get => lectura; set => lectura = value; }
        public string CodEmpaque { get => codEmpaque; set => codEmpaque = value; }
        public string FechaSenasa { get => fechaSenasa; set => fechaSenasa = value; }
        public string Empleado { get => empleado; set => empleado = value; }
        public string Tarea { get => tarea; set => tarea = value; }
        public string Concepto { get => concepto; set => concepto = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string Up { get => up; set => up = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Variedad { get => variedad; set => variedad = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Calibre { get => calibre; set => calibre = value; }
        public string Envase { get => envase; set => envase = value; }
        public string LeidaEn { get => leidaEn; set => leidaEn = value; }
        public string Id_volcado { get => id_volcado; set => id_volcado = value; }
        public decimal Id_pallet { get => id_pallet; set => id_pallet = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public String Cod_cospel { get => cod_cospel; set => cod_cospel = value; }
    }
}