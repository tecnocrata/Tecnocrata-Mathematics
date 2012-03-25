using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tx.Math.Tests
{
    /// <summary>
    /// Summary description for LiteralTraductorTests
    /// </summary>
    [TestClass]
    public class LiteralTraductorTests
    {
        [TestMethod]
        public void UnidadesTests()
        {
            string result = string.Empty;
            result= LiteralTraductor.ConvertToLiteral(1, CurrencyGenere.Male, CurrencyLanguage.Spanish);
            Assert.AreEqual("uno", result);
            result = LiteralTraductor.ConvertToLiteral(1, CurrencyGenere.Female);
            Assert.AreEqual("una",result);
            result = LiteralTraductor.ConvertToLiteral(0);
            Assert.AreEqual("",result);
        }

        [TestMethod]
        public void DecenasTests()
        {
            string result = string.Empty;
            result = LiteralTraductor.ConvertToLiteral(11, CurrencyGenere.Female, CurrencyLanguage.Spanish);
            Assert.AreEqual("once", result);
            result = LiteralTraductor.ConvertToLiteral(21);
            Assert.AreEqual("veintiuno", result);
            result = LiteralTraductor.ConvertToLiteral(21, CurrencyGenere.Female);
            Assert.AreEqual("veintiuna", result);
            result = LiteralTraductor.ConvertToLiteral(31, CurrencyGenere.Female);
            Assert.AreEqual("treinta y una", result);
            result = LiteralTraductor.ConvertToLiteral(42, CurrencyGenere.Female);
            Assert.AreEqual("cuarenta y dos", result);
        }

        [TestMethod]
        public void CentenasTests()
        {
            string result = string.Empty;
            result = LiteralTraductor.ConvertToLiteral(111, CurrencyGenere.Female, CurrencyLanguage.Spanish);
            Assert.AreEqual("ciento once", result);
            result = LiteralTraductor.ConvertToLiteral(266, CurrencyGenere.Female, CurrencyLanguage.Spanish);
            Assert.AreEqual("doscientas sesenta y seis", result);
            result = LiteralTraductor.ConvertToLiteral(391, CurrencyGenere.Male, CurrencyLanguage.Spanish);
            Assert.AreEqual("trescientos noventa y uno", result);
            result = LiteralTraductor.ConvertToLiteral(481, CurrencyGenere.Female, CurrencyLanguage.Spanish);
            Assert.AreEqual("cuatrocientas ochenta y una", result);
            result = LiteralTraductor.ConvertToLiteral(827, CurrencyGenere.Female, CurrencyLanguage.Spanish);
            Assert.AreEqual("ochocientas veintisiete", result);
        }

        [TestMethod]
        public void UnidadesDeMillarTests()
        {
            string result = string.Empty;
            result = LiteralTraductor.ConvertToLiteral(1091, CurrencyGenere.Female, CurrencyLanguage.Spanish);
            Assert.AreEqual("un mil noventa y una", result);
            result = LiteralTraductor.ConvertToLiteral(3560, CurrencyGenere.Female, CurrencyLanguage.Spanish);
            Assert.AreEqual("tres mil quinientas sesenta", result);
            result = LiteralTraductor.ConvertToLiteral(6978, CurrencyGenere.Male, CurrencyLanguage.Spanish);
            Assert.AreEqual("seis mil novecientos setenta y ocho", result);
        }

        [TestMethod]
        public void CentenasDeMillonTests()
        {
            string result = string.Empty;
            result = LiteralTraductor.ConvertToLiteral(31451100, CurrencyGenere.Female, CurrencyLanguage.Spanish);
            Assert.AreEqual("treinta y un millones cuatrocientas cincuenta y una mil cien", result);
            result = LiteralTraductor.ConvertToLiteral(456789012, CurrencyGenere.Male, CurrencyLanguage.Spanish);
            Assert.AreEqual("cuatrocientos cincuenta y seis millones setecientos ochenta y nueve mil doce", result);
        }
    }
}
