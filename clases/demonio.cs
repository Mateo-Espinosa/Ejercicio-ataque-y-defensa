public class demonio : Personaje
{
    private Random random = new Random();

    public demonio(string nombre)
    {
        Nombre = nombre;
        Vida = 100;
        Ataque = 0;
        Defensa = 7;
    }

      public override void Defender(int daño)
    {
        int dañoRecibido = daño - Defensa;
        if (dañoRecibido > 0)
        {
            Vida -= dañoRecibido;
            Console.WriteLine( Nombre + " recibe " + dañoRecibido + " de daño.");
        }
    }
    public override void Atacar(Personaje personaje)
    {
        int ataque = random.Next(0, 91);
        Console.WriteLine("El golpe de " + Nombre + " va con " + ataque + " puntos de magia pura.");

        int daño = ataque - personaje.Defensa;
        if (daño < 0)
            daño = 0;

        int vidaAntes = personaje.Vida;
        personaje.Defender(daño);
        int vidaDespues = personaje.Vida;
        int dañoRealizado = vidaAntes - vidaDespues;

        Console.WriteLine(Nombre + " por su golpe le quita a " +  personaje.Nombre  + " "+  dañoRealizado + " de vida" + "\n");
    }
    public override bool vivio()
    {
        return Vida > 0;
    }
}