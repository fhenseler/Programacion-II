using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Entidades;
using Excepciones;
using System.Collections.Generic;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void TestLanzaExcepcionSerializar()
        {
            Dictionary<string, Votacion.EVoto> participantes = new Dictionary<string, Votacion.EVoto>();
            Votacion v = new Votacion("TestLey", participantes);

            try
            {
                v.Guardar("Test.xml", v);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ErrorArchivoException));
            }
        }

        [TestMethod]
        public void TestEvento()
        {

        }
    }
}
