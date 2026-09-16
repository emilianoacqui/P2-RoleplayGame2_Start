using System;
using System.Collections.Generic;

namespace Ucu.Poo.RoleplayGame
{
    public class Juego
    {
        private readonly List<IPersonaje> personajes = new List<IPersonaje>();

        public IReadOnlyList<IPersonaje> Personajes
        {
            get
            {
                return personajes;
            }
        }

        public void AgregarPersonaje(IPersonaje personaje)
        {
            if (personaje == null)
            {
                throw new ArgumentNullException(nameof(personaje));
            }

            personajes.Add(personaje);
        }

        public void Atacar(IPersonaje atacante, IPersonaje objetivo)
        {
            if (atacante == null)
            {
                throw new ArgumentNullException(nameof(atacante));
            }

            if (objetivo == null)
            {
                throw new ArgumentNullException(nameof(objetivo));
            }

            int daño = Math.Max(0, atacante.ObtenerAtaque() - objetivo.ObtenerDefensa());
            objetivo.Vida = Math.Max(0, objetivo.Vida - daño);
        }

        public void Curar(IPersonaje personaje, int puntos)
        {
            if (personaje == null)
            {
                throw new ArgumentNullException(nameof(personaje));
            }

            personaje.Curar(puntos);
        }
    }
}