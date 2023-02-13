using paletizado.models;
using System.Windows.Forms;

namespace paletizado.controller
{
    internal class CargarComboboxCalidad
    {
        public void cargarCalidad(ComboBox comboBox)
        {
            CargarListaString cargarLista = new CargarListaString();
            foreach (var item in cargarLista.cargarLista("SELECT descripcion FROM calidades where activo='S'"))
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
