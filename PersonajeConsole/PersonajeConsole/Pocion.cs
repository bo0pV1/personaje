using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeConsole
{
    public abstract class Pocion : item
    {
        public int maximo { get; set; }
        public int minimo { get; set; }

        public int cura { get; set; }
        public int restaura { get; set; }

        public abstract override int usar(Personaje p1);

    }
}
