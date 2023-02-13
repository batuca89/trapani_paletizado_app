using paletizado.models;
using System.Windows.Forms;

namespace paletizado.controller
{
    internal class CargarComboboxCamara
    {
        public void cargarCamara(ComboBox comboBox)
        {
            CargarListaString cargarLista = new CargarListaString();
            foreach (var item in cargarLista.cargarLista("SELECT medidas FROM camaras  where activo='S'"))
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
