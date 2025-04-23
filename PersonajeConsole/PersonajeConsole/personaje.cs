using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeConsole
{
    internal class Personaje
    {
        public int Vida;
        public string Color;
        public int Defensa;
        public int Fuerza;
        public int Mana;
        public int Daño;

        public void CambiarColor(string NuevoColor)
        {

            Color = NuevoColor;

        }
        public int RecibirDaño(int FuerzaATK)
        {
            int DañoEfectivo;
            DañoEfectivo = FuerzaATK - Defensa;
            if (DañoEfectivo < 0)
            {

                DañoEfectivo = 0;
            }
            else
            {

                Vida -= DañoEfectivo;

            }
            return DañoEfectivo;

        }

        public int atacar(Personaje objetivo)
        {
            if (Mana >= 10)
            {
                Mana = Mana - 10;
                return objetivo.RecibirDaño(Fuerza);
            }

            else
            {
                return 0;
            }

        }
    }
}

