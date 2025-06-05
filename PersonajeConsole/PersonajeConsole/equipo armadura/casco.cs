using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeConsole
{
    public class Casco : Equipo,IEquipable
    {
        public int DefensaAgregada = 10;
        public override void DesEquipar(Personaje p1)
        {
            Equipado = false;
            p1.Defensa -= DefensaAgregada;
        }
        public override void Equipar(Personaje p1)
        {
            Equipado = true;
            p1.Defensa += DefensaAgregada;

        }
        public override string ToString()
        {
            return "Casco";
        }
    }
}
