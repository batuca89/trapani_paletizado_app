using paletizado.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletizado.controller
{
    internal class CargarComboboxPedidos
    {
        public void cargarPedidos(ComboBox comboBox)
        {
            CargarListaString cargarLista = new CargarListaString();
            foreach (var item in cargarLista.cargarLista("SELECT cod_pedido FROM pedidos where estado = 'P' order by cod_pedido desc"))
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
