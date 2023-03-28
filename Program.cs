using System;

namespace combate
{
    class combateFinal
    {
        static void Main(string[] args)
        {
            Personaje tanjiro = new cazador("Tanjiro");
            Personaje muzan = new demonio("Muzan");

            int contador = 1;
            while (tanjiro.vivio() && muzan.vivio())
            {
                Console.WriteLine("Raund numero: " + contador + ": " + tanjiro.Nombre + " vs " + muzan.Nombre + "\n");
                Console.WriteLine("--------------------------------------------");
                tanjiro.Atacar(muzan);
                muzan.Atacar(tanjiro);
                Console.WriteLine("En este raund " + tanjiro.Nombre + " quedo con " + tanjiro.Vida + " puntos de vida.");
                Console.WriteLine("En este raund " + muzan.Nombre + " quedo con " + muzan.Vida + " puntos de vida." + "\n");
                Console.WriteLine("--------------------------------------------");
                contador++;
            }

            if (tanjiro.vivio())
            {
                Console.WriteLine(tanjiro.Nombre + " ha ganado este combate!");
            }
            else if (muzan.vivio())
            {
                Console.WriteLine(muzan.Nombre + " ha ganado este combate!");
            }
            else
            {
                Console.WriteLine("Ha habido un empate en este combate!");
            }

            Console.ReadLine();
        }
    }
}
