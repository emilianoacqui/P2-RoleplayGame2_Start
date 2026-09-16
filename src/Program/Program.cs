using Ucu.Poo.RoleplayGame;

SpellsBook book = new SpellsBook();
book.Spells = new Spell[] { new Spell() };

Mago gandalf = new Mago("Gandalf", 100);
gandalf.Libro = book;
gandalf.AgregarItem(new Staff());

Enano gimli = new Enano("Gimli", 100);
gimli.AgregarItem(new Axe());
gimli.AgregarItem(new Shield());

Juego juego = new Juego();
juego.AgregarPersonaje(gandalf);
juego.AgregarPersonaje(gimli);

Console.WriteLine($"Gimli has ❤️ {gimli.Vida}");
Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.ObtenerAtaque()}");

juego.Atacar(gandalf, gimli);

Console.WriteLine($"Gimli has ❤️ {gimli.Vida}");

juego.Curar(gimli, 20);

Console.WriteLine($"Gimli has ❤️ {gimli.Vida}");