using paletizado.models;
using System.Windows.Forms;

namespace paletizado.controller
{
    internal class CargarComboboxDestino
    {
        public void cargarDestino(ComboBox comboBox)
        {
            CargarListaString cargarLista = new CargarListaString();
            foreach (var item in cargarLista.cargarLista("SELECT descripcion FROM destinos where activo='S' order by descripcion asc"))
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
