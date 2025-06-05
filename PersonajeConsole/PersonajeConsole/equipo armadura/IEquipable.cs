using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeConsole
{
    public interface IEquipable
    {
        public void Equipár(Personaje p1);
        public void DesEquipár(Personaje p1);
    }
}
