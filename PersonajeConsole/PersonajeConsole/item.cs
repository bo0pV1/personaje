using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeConsole
{
    public abstract class item 
    {
        public Inventario? Inventario { get; set; }
        public abstract int usar(Personaje p1);

    }
}
