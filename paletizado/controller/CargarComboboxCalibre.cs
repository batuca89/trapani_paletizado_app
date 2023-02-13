using paletizado.models;
using System.Windows.Forms;

namespace paletizado.controller
{
    internal class CargarComboboxCalibre
    {
        public void cargarCalibre(ComboBox comboBox)
        {
            CargarListaString cargarLista = new CargarListaString();
            foreach (var item in cargarLista.cargarLista("SELECT descripcion FROM calibres where activo='S' order by descripcion*1 asc"))
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
