using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeConsole
{
    public abstract class Equipo : Item, IEquipable
    {
        public bool Equipado;

        public abstract void DesEquipár(Personaje p1);
        public abstract void Equipár(Personaje p1);
    }
}
