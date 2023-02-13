using paletizado.models;
using System.Windows.Forms;

namespace paletizado.controller
{
    internal class CargarComboboxCondicionesEnvalado
    {
        public void cargarCondicionesEnvalado(ComboBox comboBox)
        {
            CargarListaString cargarLista = new CargarListaString();
            foreach (var item in cargarLista.cargarLista("SELECT nombre FROM condiciones_embalado where activo='S' order by nombre asc;"))
            {
                comboBox.Items.Add(item);
            }


        }


        public void cargarCondicionesEnvaladoSegunEnvase(ComboBox comboBox, string envase)
        {

            CargarListaString cargarLista = new CargarListaString();
            comboBox.Items.Clear();
            foreach (var item in cargarLista.cargarListaSegunCondicionEmbalado(envase))
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
