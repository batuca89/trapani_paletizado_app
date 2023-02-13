using paletizado.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletizado.controller
{
    internal class CargarComboboxTurno
    {
        public void cargarTurno(ComboBox comboBox)
        {
            CargarListaString cargarLista = new CargarListaString();
            foreach (var item in cargarLista.cargarLista("SELECT turno FROM turnos where activo = 'S'"))
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
