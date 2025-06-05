using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeConsole
{
    public class Arma : Equipo,IEquipable
    {
        public override void DesEquipar(Personaje p1)
        {

        }
        public override void Equipar(Personaje p1)
        {

        }
        public override string ToString()
        {
            return "Espada";
        }
    }
}
