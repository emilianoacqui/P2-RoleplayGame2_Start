using System.Collections.Generic;

namespace JuegoDeRol
{
    public interface IPersonaje
    {
        string Nombre { get; set; }
        int Vida { get; set; }

        int ObtenerAtaque();
        int ObtenerDefensa();
        void Curar(int puntos);
    }

    public class Mago : IPersonaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }

        private List<ItemMagico> items = new();
        public LibroDeHechizos Libro { get; set; }

        public Mago(string nombre, int vida)
        {
            Nombre = nombre;
            Vida = vida;
            Libro = new LibroDeHechizos();
        }

        public void AgregarItem(ItemMagico item)
        {
            items.Add(item);
        }

        public bool QuitarItem(ItemMagico item)
        {
            return items.Remove(item);
        }

        public int ObtenerAtaque()
        {
            int total = Libro.ObtenerAtaque();

            foreach (ItemMagico item in items)
            {
                total += item.Ataque;
            }

            return total;
        }

        public int ObtenerDefensa()
        {
            int total = Libro.ObtenerDefensa();

            foreach (ItemMagico item in items)
            {
                total += item.Defensa;
            }

            return total;
        }

        public void Curar(int puntos)
        {
            Vida += puntos;
        }
    }

    public class Enano : IPersonaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }

        private List<ItemAtaque> Ataque = new();
        private List<ItemDefensa> Defensa = new();

        public Enano(string nombre, int vida)
        {
            Nombre = nombre;
            Vida = vida;
        }

        public void AgregarItemA(ItemAtaque item)
        {
            Ataque.Add(item);
        }

        public void AgregarItemD(ItemDefensa item)
        {
            Defensa.Add(item);
        }

        public bool QuitarItemA(ItemAtaque item)
        {
            return Ataque.Remove(item);
        }

        public bool QuitarItemD(ItemDefensa item)
        {
            return Defensa.Remove(item);
        }

        public int ObtenerAtaque()
        {
            int total = 0;

            foreach (ItemAtaque item in Ataque)
            {
                total += item.Ataque;
            }

            return total;
        }

        public int ObtenerDefensa()
        {
            int total = 0;

            foreach (ItemDefensa item in Defensa)
            {
                total += item.Defensa;
            }

            return total;
        }

        public void Curar(int puntos)
        {
            Vida += puntos;
        }
    }

    public class Elfo : IPersonaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }

        private List<ItemAtaque> Ataque = new();
        private List<ItemDefensa> Defensa = new();

        public Elfo(string nombre, int vida)
        {
            Nombre = nombre;
            Vida = vida;
        }

        public void AgregarItemA(ItemAtaque item)
        {
            Ataque.Add(item);
        }

        public void AgregarItemD(ItemDefensa item)
        {
            Defensa.Add(item);
        }

        public bool QuitarItemA(ItemAtaque item)
        {
            return Ataque.Remove(item);
        }

        public bool QuitarItemD(ItemDefensa item)
        {
            return Defensa.Remove(item);
        }

        public int ObtenerAtaque()
        {
            int total = 0;

            foreach (ItemAtaque item in Ataque)
            {
                total += item.Ataque;
            }

            return total;
        }

        public int ObtenerDefensa()
        {
            int total = 0;

            foreach (ItemDefensa item in Defensa)
            {
                total += item.Defensa;
            }

            return total;
        }

        public void Curar(int puntos)
        {
            Vida += puntos;
        }
    }
}