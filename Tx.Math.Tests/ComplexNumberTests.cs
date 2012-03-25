using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tx.Math.Tests
{
    [TestClass]
    public class ComplexNumberTests
    {
        [TestMethod]
        public void SumNumbers()
        {
            ComplexNumber n1 = new ComplexNumber(1,1);
            ComplexNumber n2 = new ComplexNumber(1,1);
            ComplexNumber result = n1 + n2;
            Assert.AreEqual(2, result.Real);
            Assert.AreEqual(2, result.Imaginary);
        }

        [TestMethod]
        public void DiffNumbers()
        {
            ComplexNumber n1 = new ComplexNumber(1, 1);
            ComplexNumber n2 = new ComplexNumber(1, 1);
            ComplexNumber result = n1 - n2;
            Assert.AreEqual(0, result.Real);
            Assert.AreEqual(0, result.Imaginary);
        }

        [TestMethod]
        public void MulNumbers()
        {
            ComplexNumber n1 = new ComplexNumber(3, 5);
            ComplexNumber n2 = new ComplexNumber(2, 3);
            ComplexNumber result = n1 * n2;
            Assert.AreEqual(6, result.Real);
            Assert.AreEqual(15, result.Imaginary);
        }

        [TestMethod]
        public void DivNumbers()
        {
            ComplexNumber n1 = new ComplexNumber(3, 15);
            ComplexNumber n2 = new ComplexNumber(2, 3);
            ComplexNumber result = n1 / n2;
            Assert.AreEqual(1.5, result.Real);
            Assert.AreEqual(5, result.Imaginary);
        }

        [TestMethod]
        public void SumWithIntegers()
        {
            ComplexNumber n1 = new ComplexNumber(3, 15);
            ComplexNumber result = n1 + 5;
            ComplexNumber n2 = new ComplexNumber(2, 3);
            ComplexNumber result2 = 5 + n2;
            Assert.AreEqual(8, result.Real);
            Assert.AreEqual(15, result.Imaginary);
            Assert.AreEqual(7, result2.Real);
            Assert.AreEqual(3, result2.Imaginary);
        }
    }
}
