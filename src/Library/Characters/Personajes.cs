namespace Ucu.Poo.RoleplayGame;

using System.Collections.Generic;

public interface IPersonaje
{
    string Nombre { get; set; }
    int Vida { get; set; }

    void Curar(int puntos);
    int ObtenerAtaque();
    int ObtenerDefensa();
}

public class Enano : IPersonaje
{
    public string Nombre { get; set; }
    public int Vida { get; set; }

    private List<IItem> items = new List<IItem>();

    public Enano(string nombre, int vida)
    {
        Nombre = nombre;
        Vida = vida;
    }

    public void AgregarItem(IItem item)
    {
        items.Add(item);
    }

    public void Curar(int puntos)
    {
        Vida += puntos;
    }

    public int ObtenerAtaque()
    {
        int total = 0;

        foreach (IItem item in items)
        {
            if (item is IAttackItem atacante)
            {
                total += atacante.AttackValue;
            }
        }

        return total;
    }

    public int ObtenerDefensa()
    {
        int total = 0;

        foreach (IItem item in items)
        {
            if (item is IDefenseItem defensor)
            {
                total += defensor.DefenseValue;
            }
        }

        return total;
    }
}

public class Elfo : IPersonaje
{
    public string Nombre { get; set; }
    public int Vida { get; set; }

    private List<IItem> items = new List<IItem>();

    public Elfo(string nombre, int vida)
    {
        Nombre = nombre;
        Vida = vida;
    }

    public void AgregarItem(IItem item)
    {
        items.Add(item);
    }

    public void Curar(int puntos)
    {
        Vida += puntos;
    }

    public int ObtenerAtaque()
    {
        int total = 0;

        foreach (IItem item in items)
        {
            if (item is IAttackItem atacante)
            {
                total += atacante.AttackValue;
            }
        }

        return total;
    }

    public int ObtenerDefensa()
    {
        int total = 0;

        foreach (IItem item in items)
        {
            if (item is IDefenseItem defensor)
            {
                total += defensor.DefenseValue;
            }
        }

        return total;
    }
}

public class Mago : IPersonaje
{
    public string Nombre { get; set; }
    public int Vida { get; set; }

    private List<IMagicItem> items = new List<IMagicItem>();

    public SpellsBook Libro { get; set; }

    public Mago(string nombre, int vida)
    {
        Nombre = nombre;
        Vida = vida;
        Libro = new SpellsBook();
    }

    public void AgregarItem(IMagicItem item)
    {
        items.Add(item);
    }

    public void Curar(int puntos)
    {
        Vida += puntos;
    }

    public int ObtenerAtaque()
    {
        int total = Libro.AttackValue;

        foreach (IMagicItem item in items)
        {
            total += item.AttackValue;
        }

        return total;
    }

    public int ObtenerDefensa()
    {
        int total = Libro.DefenseValue;

        foreach (IMagicItem item in items)
        {
            total += item.DefenseValue;
        }

        return total;
    }
}