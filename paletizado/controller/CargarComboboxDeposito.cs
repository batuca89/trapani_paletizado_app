using paletizado.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletizado.controller
{
    internal class CargarComboboxDeposito
    {
        public void cargarDeposito(ComboBox comboBox)
        {
            CargarListaString cargarLista = new CargarListaString();
            foreach (var item in cargarLista.cargarLista("SELECT nombre FROM depositos;"))
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
