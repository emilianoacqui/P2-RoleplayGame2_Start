using JuegoDeRol;
using NUnit.Framework;

namespace JuegoDeRolTests
{
    [TestFixture]
    public class MagoTests
    {
        [Test]
        public void ObtenerAtaque_MagoSinItemsNiHechizos_DevuelveCero()
        {
            Mago mago = new Mago("Viejo de barba", 100);

            int ataque = mago.ObtenerAtaque();

            Assert.That(ataque, Is.EqualTo(0));
        }

        [Test]
        public void ObtenerAtaque_MagoConHechizos_SumaAtaqueDelSpellBook()
        {
            Mago mago = new Mago("Viejo de barba", 100);
            mago.Libro.AgregarHechizo(new Spell { AttackValue = 15, DefenseValue = 0 });
            mago.Libro.AgregarHechizo(new Spell { AttackValue = 10, DefenseValue = 5 });

            int ataque = mago.ObtenerAtaque();

            Assert.That(ataque, Is.EqualTo(25));
        }

        [Test]
        public void ObtenerDefensa_MagoConHechizosYBaston_SumaAmbasFuentes()
        {
            Mago mago = new Mago("GanViejo de barbadalf", 100);
            mago.Libro.AgregarHechizo(new Spell { AttackValue = 0, DefenseValue = 5 });
            mago.AgregarItem(new Baston { AttackValue = 8, DefenseValue = 3 });

            int defensa = mago.ObtenerDefensa();

            Assert.That(defensa, Is.EqualTo(8));
        }

        [Test]
        public void QuitarItem_BastonFueAgregado_LoRemueveYaNoSumaAtaque()
        {
            Mago mago = new Mago("Viejo de barba", 100);
            Baston baston = new Baston { AttackValue = 8, DefenseValue = 3 };
            mago.AgregarItem(baston);

            mago.QuitarItem(baston);

            Assert.That(mago.ObtenerAtaque(), Is.EqualTo(0));
        }

        [Test]
        public void Curar_MagoConVidaReducida_AumentaVidaEnLaCantidadIndicada()
        {
            Mago mago = new Mago("Viejo de barba", 60);

            mago.Curar(20);

            Assert.That(mago.Vida, Is.EqualTo(80));
        }
    }
}