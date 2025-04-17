using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personaje
{
    internal class Personaje
    {
        public int Vida;
        public string Color = "blanco";
        public int Defensa;
        public int Fuerza;
        public int Mana = 10;
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
                Console.WriteLine("el ataque fue mitigado!");
                DañoEfectivo = 0;
            }
            else
            {

                Vida = Vida - DañoEfectivo;

            }
            return DañoEfectivo;

        }

        public int atacar(Personaje objetivo)
        {
            if (Mana > 0)
            {
                Mana = Mana - 1;
                return objetivo.RecibirDaño(Fuerza);

            }
            else
            {
                Console.WriteLine("No tenes mana flaco");
                return 0;
            }


        }
    }
}
