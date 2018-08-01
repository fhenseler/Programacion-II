using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej_40;

namespace TestCentralita
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestA()
        {
            Centralita centralitaMia = new Centralita("best centralita");

            Assert.IsNotNull(centralitaMia.Llamadas);
        }
        //public void TestB()
        //{
        //    Centralita centralitaMia = new Centralita("best centralita");
        //    Local llamadaLocal = new Local("Bernal", 0.7f, "Palermo", 27.5f);
        //    Local llamadaLocal2 = new Local("Bernal", 0.7f, "Palermo", 27.5f);

        //    try
        //    {

        //    }
        //    catch(Exception e)
        //    {
        //        //aca va lo de exception centralita
        //    }
        //}

        public void TestD()
        {
            Centralita centralitaMia = new Centralita("best centralita");
            Local llamadaLocal = new Local("Bernal", 0.7f, "Palermo", 27.5f);
            Local llamadaLocal2 = new Local("Bernal", 0.7f, "Palermo", 27.5f);

            Provincial llamadaProvincial = new Provincial("Bernal", "Palermo", 0.7f, Provincial.Franja.Franja_2);
            Provincial llamadaProvincial2 = new Provincial("Bernal", "Palermo", 0.7f, Provincial.Franja.Franja_2);

            if(llamadaProvincial==llamadaLocal || llamadaProvincial2==llamadaLocal || llamadaProvincial==llamadaLocal || llamadaProvincial2==llamadaLocal2)
            {
                Assert.Fail();
            }
            Assert.IsTrue(llamadaProvincial==llamadaProvincial2 || llamadaLocal==llamadaLocal2);
        }
    }
}
