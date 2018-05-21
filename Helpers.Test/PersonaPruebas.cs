using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers;

namespace Helpers.Test
{
    [TestClass]
    public class PersonaPruebas
    {
        string[] cedulas;
        [TestInitialize]
        public void Setup()
        {
            cedulas = new string[] {
                "40221867555", //true
                "40221867556", //false
                "40221868555", //false
                "4022085225-1", //true
                "402-2085225-1", //true
                "412-2085225-1", //false
                "402-2186855-8", //false
                "402-218685A-8", //false
                "402-218685A-08", //false
                "000-0000000-00" //false
            };
        }

        [TestMethod]
        public void PruebaValidarCedula()
        {
            Assert.AreEqual(true, PersonaHelper.ValidarCedula(cedulas[0]));
            Assert.AreEqual(false, PersonaHelper.ValidarCedula(cedulas[1]));
            Assert.AreEqual(false, PersonaHelper.ValidarCedula(cedulas[2]));
            Assert.AreEqual(true, PersonaHelper.ValidarCedula(cedulas[3]));
            Assert.AreEqual(true, PersonaHelper.ValidarCedula(cedulas[4]));
            Assert.AreEqual(false, PersonaHelper.ValidarCedula(cedulas[5]));
            Assert.AreEqual(false, PersonaHelper.ValidarCedula(cedulas[6]));
            Assert.AreEqual(false, PersonaHelper.ValidarCedula(cedulas[7]));
            Assert.AreEqual(false, PersonaHelper.ValidarCedula(cedulas[8]));
            Assert.AreEqual(false, PersonaHelper.ValidarCedula(cedulas[9]));
        }
    }
}
