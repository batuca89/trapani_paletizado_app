using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    internal class ValidacionesLecturas : AbstractValidator<List<LecturaCajas>>
    {
        public ValidacionesLecturas(List<LecturaCajas> name, String nombreMarca, String nombreEnvase, String nombreCalibre, int envasesDisponibles)
        {
            RuleSet("lecturaCajas", () =>
            {
                RuleFor(x => name.Count()).NotEqual(0).WithMessage("La caja no existe");
                RuleFor(x => name[0].Id_pallet).Equal(0).WithMessage($"La caja ya esta asiganada al pallet Nro: {name[0].Id_pallet}");
                RuleFor(x => name[0].Marca).Equal(nombreMarca).WithMessage($"La caja No corresponde con la marca selecciona: {nombreMarca}  La etiqueta de la caja es: {name[0].Marca}");
                RuleFor(x => name[0].Envase).Equal(nombreEnvase).WithMessage($"La caja No corresponde con el envase seleccionado: {nombreEnvase}  La etiqueta de la caja es: {name[0].Envase}");
                RuleFor(x => name[0].Calibre).Equal(nombreCalibre).WithMessage($"La caja No corresponde con el calibre seleccionado: {nombreCalibre}  La etiqueta de la caja es: {name[0].Calibre}");
                RuleFor(x => envasesDisponibles).LessThanOrEqualTo(0).WithMessage("La cantidad de cajas supera la condicion de embalado");
            });

            RuleSet("lecturaVolcadoYEmpleado", () =>
            {
                RuleFor(x => name[0].Id_volcado).NotEqual("0").NotEqual("").WithMessage("La caja no tiene asignado un empleado o una up por favor leer etiqueta de up y etiqueta de personal");
                RuleFor(x => name[0].Empleado).NotEqual("0").NotEqual("");
            });
        }
    }
}