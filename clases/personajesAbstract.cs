public abstract class Personaje
{
    public string? Nombre { get; set; } // ? para que acepte valores nulos.
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }

    public abstract void Atacar(Personaje personaje);
    public abstract void Defender(int daño);
    public abstract bool vivio();
}

