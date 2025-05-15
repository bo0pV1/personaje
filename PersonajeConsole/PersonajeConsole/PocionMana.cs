using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeConsole
{
    public class PocionMana : Pocion
    {

        public override int usar(Personaje p1)
        {
            Random aleatorio = new Random();
            int numAL = aleatorio.Next(minimo, maximo);
            int mana = p1.Mana;
            p1.Mana = p1.Mana + numAL;
            if(p1.Mana>p1.ManaTotal)
            {

                p1.Mana = p1.ManaTotal;

            }
            restaura = p1.Mana - mana;

            return restaura;
        }

    }
}
