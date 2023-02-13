using paletizado.models;
using System.Windows.Forms;

namespace paletizado.controller
{
    internal class CargarComboboxEnvases
    {
        public void cargarEnvases(ComboBox comboBox)
        {
            CargarListaString cargarLista = new CargarListaString();
            foreach (var item in cargarLista.cargarLista("SELECT descripcion FROM cajas where activo='S' order by descripcion asc"))
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
