using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Entidades;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CheckMaxPedidos()
        {
            Pedido p = new Pedido();
            ProductoA prod = new ProductoA("desc", 10, Material.Aluminio);

            for (int i = 0; i < 10; i++)
            {
                p += prod;
            }

            Assert.IsTrue(p.Productos.Count <= 5);          
        }
    }
}
