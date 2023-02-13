using FluentValidation;
using FluentValidation.Results;
using paletizado.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletizado.models
{
    public  class Validaciones : AbstractValidator<String>
    {
        public Validaciones(String name)
        {


            RuleSet("up", () =>
            {
                RuleFor(x => name.Length).Equal(11);
                RuleFor(x => name.Last()).Equal('U');

            });

            RuleSet("embalador", () =>
            {
                RuleFor(x => name.Length).Equal(12);
                RuleFor(x => name.Last()).Equal('E');

            });
            RuleSet("cospel", () =>
            {
                RuleFor(x => name.Length).Equal(11);
                RuleFor(x => name.Last()).Equal('P');

            });
            RuleSet("caja", () =>
            {
                RuleFor(x => name.Length).Equal(11);
                RuleFor(x => name.Last()).Equal('C');

            });
            RuleSet("idpallet", () =>
            {
                RuleFor(x => name).NotEmpty();

            });
        }

        public String validarEtiquetas(String name)
        {

            double numericValue;
            name = name.ToUpper();
            bool isNumber = double.TryParse(name, out numericValue);
            if (!isNumber && name != "")
            {

                var validator = new Validaciones(name);

                ValidationResult result = validator.Validate(name, options => options.IncludeRuleSets("up"));
                if (result.IsValid)
                {


                    return "up";

                }
                ValidationResult result2 = validator.Validate(name, options => options.IncludeRuleSets("embalador"));
                if (result2.IsValid)
                {
                    return "embalador";
                }
                ValidationResult result3 = validator.Validate(name, options => options.IncludeRuleSets("caja"));
                if (result3.IsValid)
                {
                    return "caja";
                }
                ValidationResult result4 = validator.Validate(name, options => options.IncludeRuleSets("cospel"));
                if (result4.IsValid)
                {
                    return "cospel";
                }

                else { return "otra"; }

            }return "";
        }
        public void validarPallet(String name)
        {
            var validator = new Validaciones(name);
            ValidationResult result = validator.Validate(name, options => options.IncludeRuleSets("idpallet"));
            CambioDeTapa cambioDeTapa = new CambioDeTapa();
            if (result.IsValid)
            {
                BuscarCajas buscar = new BuscarCajas();

                decimal idPallet = buscar.getIdPalletPorCodigoBarra(name) =="" ? -1 : Convert.ToDecimal(buscar.getIdPalletPorCodigoBarra(name));

                if (idPallet == -1)
                {
                    cambioDeTapa.setTxtInfo("Pallet No encontrado" , false);
                    cambioDeTapa.Show();
                    cambioDeTapa.setTxtLeer("");

                }
                else
                {
                    List<EmbaladorUpCambioDeTapa> embaladorUp = new List<EmbaladorUpCambioDeTapa>();
                    cambioDeTapa.setTxtInfo("Pallet encontrado Nro: " + idPallet, true);
                    embaladorUp.AddRange(buscar.getEmbaladorYupCambioTapa(idPallet));
                    cambioDeTapa.setTxtCajas(embaladorUp.Count.ToString());               
                    cambioDeTapa.Show();
                    cambioDeTapa.setLista(embaladorUp);
                    cambioDeTapa.bandera = true;
                    cambioDeTapa.setTxtLeer("Por favor leer las cajas");

                }


            }
            else
            {
                cambioDeTapa.setTxtInfo("Pallet encontrado",false);
                cambioDeTapa.Show();
            }

            
        }

        }
}
