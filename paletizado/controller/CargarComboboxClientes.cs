
using paletizado.models;

using System.Windows.Forms;

namespace paletizado.controller
{
    internal class CargarComboboxClientes
    {
        public void cargarClientes(ComboBox comboBox)
        {
            CargarListaString cargarLista= new CargarListaString();
            foreach (var item in cargarLista.cargarLista("SELECT descripcion FROM clientes where habilitado='S' order by descripcion asc"))
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
