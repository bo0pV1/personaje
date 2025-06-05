using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeConsole
{
    public interface IEquipable
    {
        public void Equipar(Personaje p1);
        public void DesEquipar(Personaje p1);
    }
}
