using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tx.Math;

namespace Universo
{
    [TestClass]
    public class TestConjuntos
    {
        [TestMethod]
        public void TestUnion()
        {
            var conjuntoA = new Set();
            conjuntoA.Add(3);
            conjuntoA.Add(2);
            conjuntoA.Add(1);
            var conjuntoB = new Set();
            conjuntoB.Add(3);
            conjuntoB.Add(7);
            conjuntoB.Add(9);
            var conjuntoC = conjuntoA+conjuntoB;
            Assert.AreEqual(true, conjuntoC.Contains(3) );
            Assert.AreEqual(true, conjuntoC.Contains(2));
            Assert.AreEqual(true, conjuntoC.Contains(1));
            Assert.AreEqual(true, conjuntoC.Contains(7));
            Assert.AreEqual(true, conjuntoC.Contains(9));
        }

        [TestMethod]
        public void TestInterseccion()
        {
            var conjuntoA = new Set();
            conjuntoA.Add(7);
            conjuntoA.Add(2);
            conjuntoA.Add(1);
            var conjuntoB = new Set();
            conjuntoB.Add(3);
            conjuntoB.Add(7);
            conjuntoB.Add(9);
            var conjuntoC = conjuntoA^conjuntoB;
            Assert.AreEqual(true, conjuntoC.Contains(7) );
        }

        [TestMethod]
        public void TestMenos()
        {
            Set A = new Set();
            A.Add(3);
            A.Add(2);
            A.Add(1);
            Set B = new Set();
            B.Add(3);
            B.Add(7);
            B.Add(9);
            Set C = A-B;
            Assert.AreEqual(true, C.Contains(2));
            Assert.AreEqual(true, C.Contains(1) );
        }

        [TestMethod]
        public void TestLargo()
        {
            Set A = new Set();
            A.Add(1);
            A.Add(5);
            A.Add(2);
            A.Add(7);
            Set B = new Set();
            B.Add(9);
            B.Add(2);
            B.Add(1);
            B.Add(8);
            B.Add(7);
            Assert.AreEqual(4, A.NumberofElements());
            Assert.AreEqual(5, B.NumberofElements());  
        }        
    }
}
