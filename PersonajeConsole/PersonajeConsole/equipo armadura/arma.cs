using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeConsole
{
    public class Arma : Equipo,IEquipable
    {
        public int DañoExtra = 20;
        public override void DesEquipar(Personaje p1)
        {
            Equipado = false;
            p1.Daño -= DañoExtra;
        }
        public override void Equipar(Personaje p1)
        {
            Equipado = true;
            p1.Daño +=DañoExtra;

        }
        public override string ToString()
        {
            return "Espada";
        }
    }
}
