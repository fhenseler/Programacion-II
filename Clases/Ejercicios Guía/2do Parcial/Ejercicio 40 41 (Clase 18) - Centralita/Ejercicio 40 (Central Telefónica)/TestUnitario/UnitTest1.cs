using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_37__Central_Telefónica_;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInstancia()
        {
            Centralita c = new Centralita("Fede Center");
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void TestExcepcionLocal()
        {
            Centralita c = new Centralita("Fede Center");
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local l2 = new Local("Bernal", 45, "Rosario", 1.99f);

            c += l1;

            try
            {
                c += l2;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaException));
            }
        }

        [TestMethod]
        public void TestExcepcionProvincial()
        {
            Centralita c = new Centralita("Fede Center");
            Provincial l1 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_2, 22, "Bernal");

            c += l1;

            try
            {
                c += l2;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaException));
            }
        }

        [TestMethod]
        public void TestExcepcionAmbas()
        {
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local l2 = new Local("Bernal", 45, "Rosario", 1.99f);
            Provincial p1 = new Provincial("Bernal", Provincial.Franja.Franja_1, 21, "Rosario");
            Provincial p2 = new Provincial("Bernal", Provincial.Franja.Franja_2, 22, "Rosario");

            if (l1 == p1 || l1 == p2 || l2 == p1 || l2 == p2)
            {
                Assert.Fail("Error");
            }

            Assert.IsTrue(l1 == l2 && p1 == p2);
        }
    }
}
