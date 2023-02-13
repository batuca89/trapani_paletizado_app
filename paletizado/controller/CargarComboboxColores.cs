using paletizado.models;
using System.Windows.Forms;

namespace paletizado.controller
{
    internal class CargarComboboxColores
    {
        public void cargarColores(ComboBox comboBox)
        {
            CargarListaString cargarLista = new CargarListaString();
            foreach (var item in cargarLista.cargarLista("SELECT descripcion FROM colores order by nombre asc"))
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
