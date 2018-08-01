using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestListaInstanciada()
        {
            Correo c = new Correo();
            Assert.IsNotNull(c.Paquetes);
        }

        [TestMethod]
        public void TestCarga()
        {
            Correo c = new Correo();
            Paquete p1 = new Paquete("Berutti 444", "111-111-1111");
            Paquete p2 = new Paquete("Bernal 555", "111-111-1111");

            c += p1;

            try
            {
                c += p2;
            }
            catch (TrackingIdRepetidoException e)
            {
                Assert.IsInstanceOfType(e, typeof(TrackingIdRepetidoException));
            }
        }
    }
}
