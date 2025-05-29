using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeConsole
{
    public class Inventario 
    {
        public Personaje Personaje { get; set; }

        public List<item> Items { get; set; } = new();
        string nombreitem { get; set; }
        string tipoitem { get; set; }
        public void Agregaritem(item it)
        {
            Items.Add(it);
           it.Inventario = this;
        }

        public void Eliminaritem(item it)
        {
            Items.Remove(it);
            it.Inventario = null;
        }

    }
}
