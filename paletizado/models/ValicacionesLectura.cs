using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    public class ValicacionesLectura : AbstractValidator<List<LecturaCajas>>
    {
        List<String> valoresNulos = new List<String>() { "0", "" };
        public ValicacionesLectura(List<LecturaCajas> name, String codigoBarraCaja,String CodPallet, String nombreMarca, String NombreEnvase, String NombreCalibre, int envasesDisponibles) {
            RuleSet("lectura", () =>
            {
                //RuleFor(x => codigoBarraCaja.Last()).Equal('C');
               
                RuleFor(x => name[0].Cod_cospel).Equal("").WithMessage($"Error : La caja ya esta asignada al pallet provisorio Nro: {name[0].Cod_cospel}");
                RuleFor(x => envasesDisponibles).NotEqual(0).WithMessage("La cantidad de cajas supera la condicion de embalado");
                RuleFor(x => name[0].Marca).Equal(nombreMarca).WithMessage($"La caja No corresponde con la marca selecciona: {nombreMarca} la etiqueta de caja es: {name[0].Marca}");
                RuleFor(x => name[0].Envase).Equal(NombreEnvase).WithMessage($"La caja No corresponde con el envase seleccionado: {NombreEnvase} la etiqueta de caja es: {name[0].Envase}");
                RuleFor(x => name[0].Calibre).Must(validarCalibre).WithMessage($"La caja No corresponde con el calibre seleccionado: {NombreCalibre} la etiqueta de caja es: {name[0].Calibre}");
                RuleFor(x => name[0].Id_pallet).Equal(0).WithMessage($"Error : La caja ya esta asiganada al pallet Nro: {CodPallet}");
                RuleFor(x => name.Count()).NotEqual(0).WithMessage("La caja no existe");
               
            });

            RuleSet("idVolcadoIdEmpleado", () =>
            {
               
                RuleFor(x => name[0].Empleado).Must(validarNoNuloYCero);
                RuleFor(x => name[0].Id_volcado).Must(validarNoNuloYCero);
            });

            bool validarNoNuloYCero(String valor)
            {
                if(valor.Equals("0") || valor.Equals(""))
                    return true;
                else
                    return false;
            }

             bool validarCalibre(String calibre)
            {
                if (name[0].Calibre.Equals(NombreCalibre) || NombreCalibre.Equals("MIX") || NombreCalibre.Equals("Mix") || NombreCalibre.Equals("mix"))
                    return true;
                else
                    return false
;            }

        }
    }
}
