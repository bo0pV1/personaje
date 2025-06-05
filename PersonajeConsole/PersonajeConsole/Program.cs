using PersonajeConsole;
using System.Net;

Personaje p1 = new Personaje();
Personaje p2 = new Personaje();
Personaje personaje = new Personaje();


int seleccion=3;
Console.WriteLine("antes de comenzar crea 2 personajes");
Console.WriteLine("Personaje numero 1");
CargaPersonaje(p1);
Console.WriteLine("Personaje numero 2");
CargaPersonaje(p2);
Console.WriteLine("Personajes cargados!, disfrute del juego :v (pulse cualquier tecla para continuar)");
Console.ReadKey();

Console.Clear();

while (seleccion!=0)
{
   
    Console.WriteLine("ingrese que desea hacer! (usted juega como el personaje 1)");
    Console.WriteLine("1-cambiar color");
    Console.WriteLine("2-atacar!");
    Console.WriteLine("3-recibir daño");
    Console.WriteLine("4-crear pocion (1-Vida/2-Mana)");
    Console.WriteLine("5-utilizar item");
    Console.WriteLine("0-salir");
    seleccion = int.Parse(Console.ReadLine());
    switch (seleccion)
    {
        case 1:
            Console.WriteLine("ingrese el nuevo color del personaje 1");
            p1.CambiarColor(Console.ReadLine());

            Console.WriteLine("Color cambiado!");
            break;
        case 2: 
                Console.WriteLine("El daño causado es de: " + p1.atacar(p2)); 
            break;
        case 3:
           
            Console.WriteLine("el daño recibido es de: " + p2.atacar(p1));

            break;
        case 4:
 
            int sel=0;
            Console.WriteLine("seleccione que pocion quisiera utilizar");
            sel = int.Parse(Console.ReadLine());

            switch (sel)
            {
                case 1:
                    personaje.Inventario.Agregaritem(CrearPocionVida());
                    break;

                case 2:
                    personaje.Inventario.Agregaritem(CrearPocionMana());
                    break;
            
            }
            break;
        case 5:
            int selec = 0;
            int i = 1;
            Console.WriteLine("que item desea utilizar?");
            foreach (Item it in p1.Inventario.Items)
            {
                Console.WriteLine(i+"- "+it);
                i++;
            }
            selec = int.Parse(Console.ReadLine());
           
            Item itemselec = p1.Inventario.Items[selec - 1];
            itemselec.usar(p1);
            p1.Inventario.Eliminaritem(itemselec); 
               
            
            
            break;
    }
    MuestraPJ();
    Console.ReadKey();
    Console.Clear();
}

void CargaPersonaje(Personaje personaje)
{
    Console.WriteLine("ingrese cuanta vida tiene su personaje!");
    personaje.Vida = int.Parse(Console.ReadLine());
    personaje.VidaTotal = personaje.Vida;
    Console.WriteLine("ingrese el color del personaje");
    personaje.Color = Console.ReadLine();
    Console.WriteLine("ingrese la cantidad de mana de su personaje");
    personaje.Mana = int.Parse(Console.ReadLine());
    personaje.ManaTotal  = personaje.Mana;
    Console.WriteLine("ingrese cuanta defensa tiene su personaje!");
    personaje.Defensa = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese su fuerza!");
    personaje.Fuerza = int.Parse(Console.ReadLine());
    personaje.Inventario.Personaje = personaje;
    personaje.Inventario.Agregaritem(CrearPocionVida());
    personaje.Inventario.Agregaritem(CrearPocionMana());
}
PocionVida CrearPocionVida()
{

    PocionVida pocivida = new PocionVida();
    Console.WriteLine("ingrese un el valor maximo que puede curar tu pocion!");
    pocivida.maximo = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese un el valor minimo que puede curar tu pocion!");
    pocivida.minimo = int.Parse(Console.ReadLine());
    Console.WriteLine("Pocion Creada!");

    return pocivida;
}

PocionMana CrearPocionMana()
{
    PocionMana pocimana = new PocionMana();
    Console.WriteLine("ingrese un el valor maximo que puede reestablecer tu pocion!");
    pocimana.maximo = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese un el valor minimo que puede reestablecer tu pocion!");
    pocimana.minimo = int.Parse(Console.ReadLine());

    return pocimana;


}
void MuestraPJ()
{
    Console.WriteLine("Personaje: " + p1.Color);
    Console.WriteLine("Vida: "+p1.Vida);
    Console.WriteLine("Mana: " +p1.Mana);
    Console.WriteLine();
    Console.WriteLine("_________________inventario_____________");
    int i = 1;
    foreach (Item it in p1.Inventario.Items)
    {
        Console.WriteLine(i + "- " + it);
        i++;
    }
    Console.WriteLine("----------------------------------------");
    Console.WriteLine();
    Console.WriteLine("Personaje: " + p2.Color);
    Console.WriteLine("Vida: " + p2.Vida);
    Console.WriteLine("Mana: " + p2.Mana);
    Console.WriteLine("_________________inventario_____________");
    int f = 1;
    foreach (Item it in p2.Inventario.Items)
    {
        Console.WriteLine(i + "- " + it);
        f++;
    }
    Console.WriteLine("----------------------------------------");
}



