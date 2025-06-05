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

        public abstract void DesEquipar(Personaje p1);
        public abstract void Equipar(Personaje p1);
    }
}
