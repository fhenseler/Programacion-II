using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_37__Central_Telefónica_;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        Centralita c = new Centralita("Fede Center");

        [TestMethod]
        public void TestInstancia()
        {
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void TestExcepcion()
        {
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local l2 = new Local("Bernal", 45, "Rosario", 1.99f);

            try
            {
                c.Llamadas.Add(l1);
                c.Llamadas.Add(l2);
            }
            catch (CentralitaException e)
            { 
            
            }
 
            Assert.IsInstanceOfType(c, typeof(CentralitaException));
        }
    }
}
