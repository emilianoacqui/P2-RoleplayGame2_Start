namespace JuegoDeRol
/*Interfaces*/
{
    public interface IItemAtaque
{
    string Nombre { get; set; }
    int Ataque { get; set; }
}
public interface IItemDefensa
{
    string Nombre { get; set; }
    int Defensa { get; set; }
}
/*Clases*/

    public class ItemAtaque : IItemAtaque
    {
    public string Nombre { get; set; }
    public int Ataque { get; set; }

    public ItemAtaque(string nombre, int ataque)
    {
        Nombre = nombre;
        Ataque = ataque;
    }
    }
    
    public class ItemDefensa : IItemDefensa
    {
    public string Nombre { get; set; }
    public int Defensa { get; set; }

    public ItemDefensa(string nombre, int Defensa)
    {
        Nombre = nombre;
        Defensa = Defensa;
    }
    }
    public class ItemMagico : IItemAtaque, IItemDefensa
{
    public string Nombre { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }

    public ItemMagico(string nombre, int ataque, int defensa)
    {
        Nombre = nombre;
        Ataque = ataque;
        Defensa = defensa;
    }
}
}