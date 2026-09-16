using System.Collections.Generic;

namespace JuegoDeRol
{
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

        private List<ItemNoMagico> items = new List<ItemNoMagico>();

        public Enano(string nombre, int vida)
        {
            Nombre = nombre;
            Vida = vida;
        }

        public void AgregarItem(ItemNoMagico item)
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

            foreach (ItemNoMagico item in items)
            {
                total += item.Ataque;
            }

            return total;
        }

        public int ObtenerDefensa()
        {
            int total = 0;

            foreach (ItemNoMagico item in items)
            {
                total += item.Defensa;
            }

            return total;
        }
    }

    public class Elfo : IPersonaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }

        private List<ItemNoMagico> items = new List<ItemNoMagico>();

        public Elfo(string nombre, int vida)
        {
            Nombre = nombre;
            Vida = vida;
        }

        public void AgregarItem(ItemNoMagico item)
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

            foreach (ItemNoMagico item in items)
            {
                total += item.Ataque;
            }

            return total;
        }

        public int ObtenerDefensa()
        {
            int total = 0;

            foreach (ItemNoMagico item in items)
            {
                total += item.Defensa;
            }

            return total;
        }
    }

    public class Mago : IPersonaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }

        private List<ItemMagico> items = new List<ItemMagico>();

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

        public void Curar(int puntos)
        {
            Vida += puntos;
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
    }
}