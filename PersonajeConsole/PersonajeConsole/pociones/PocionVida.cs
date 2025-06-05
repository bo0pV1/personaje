using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeConsole
{
    public class PocionVida : Pocion
    {
        public override int Usar(Personaje p1)
        {
            Random aleatorio = new Random();
            int numAL = aleatorio.Next(minimo, maximo);
            int vida = p1.Vida;
            p1.Vida = p1.Vida + numAL;
            if (p1.Vida > p1.VidaTotal)
            {

                p1.Vida= p1.VidaTotal;

            }
            cura= p1.Vida - vida;

            return cura;
        }
        public override string ToString()
        {
            return "Pocion Vida";
        }
    }
}
