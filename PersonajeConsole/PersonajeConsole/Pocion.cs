using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeConsole
{
    public abstract class Pocion :Personaje
    {
        public int maximo { get; set; }
        public int minimo { get; set; }


        public abstract void usar();
        
          

        

    }
}
