using paletizado.models;
using System.Windows.Forms;

namespace paletizado.controller
{
    internal class CargarComboboxMarcas
    {
        public void cargarMarcas(ComboBox comboBox)
        {
            CargarListaString cargarLista = new CargarListaString();
            foreach (var item in cargarLista.cargarLista("SELECT descripcion FROM marcas order by descripcion asc"))
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
