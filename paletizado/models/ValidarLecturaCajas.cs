using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace paletizado.models
{
    public class ValidarLecturaCajas : AbstractValidator<String>
    {
        public ValidarLecturaCajas(String codCospel,decimal idPallet, String marca, String marca2, String envase, String envase2, String calibre, String calibre2, int cantidadDisponlibles, String idVolcado, String empleado) {


            {
                RuleFor(x => codCospel).NotEmpty();
                RuleFor(x => idPallet).Equal(0);
                RuleFor(x => marca).Equals(marca2);
                RuleFor(x => envase).Equals(envase2);
                RuleFor(x => calibre).Equals(calibre2);
                RuleFor(x => calibre).NotEqual("MIX");
                //RuleFor(x => cantidadDisponlibles).GreaterThanOrEqualTo(0);
                RuleFor(x => idVolcado).Empty();
                RuleFor(x => empleado).Empty();
              

            }
        }
    }
}
