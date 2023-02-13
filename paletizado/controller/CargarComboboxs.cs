using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletizado.controller
{
    internal class CargarComboboxs
    {
        public void cargarComboboxs(ComboBox cliente, ComboBox envases,ComboBox condicionesEnvalado, ComboBox colores, ComboBox destino,ComboBox marcas, ComboBox calidad, ComboBox camara, ComboBox calibre, ComboBox turno, ComboBox deposito)
        {
            CargarComboboxEnvases comboboxEnvases= new CargarComboboxEnvases();
            CargarComboboxClientes comboboxClientes = new CargarComboboxClientes();
            CargarComboboxCondicionesEnvalado comboboxCondicionesEnvalado = new CargarComboboxCondicionesEnvalado();
            CargarComboboxColores comboboxColores = new CargarComboboxColores();
            CargarComboboxDestino comboboxDestino = new CargarComboboxDestino();
            CargarComboboxMarcas comboboxMarcas = new CargarComboboxMarcas();
            CargarComboboxCalidad comboboxCalidad = new CargarComboboxCalidad();
            CargarComboboxCamara comboboxCamara = new CargarComboboxCamara();
            CargarComboboxCalibre comboboxCalibre= new CargarComboboxCalibre();
            CargarComboboxTurno comboboxTurno= new CargarComboboxTurno();
            CargarComboboxDeposito comboboxDeposito= new CargarComboboxDeposito();

          
            comboboxClientes.cargarClientes(cliente);
            comboboxEnvases.cargarEnvases(envases);
            comboboxCondicionesEnvalado.cargarCondicionesEnvalado(condicionesEnvalado);
            comboboxColores.cargarColores(colores);
            comboboxDestino.cargarDestino(destino);
            comboboxMarcas.cargarMarcas(marcas);
            comboboxCalidad.cargarCalidad(calidad);
            comboboxCamara.cargarCamara(camara);
            comboboxCalibre.cargarCalibre(calibre);
            comboboxTurno.cargarTurno(turno);
            comboboxDeposito.cargarDeposito(deposito);
            //comboboxPedidos.cargarPedidos(pedidos);

        }
    }
}
