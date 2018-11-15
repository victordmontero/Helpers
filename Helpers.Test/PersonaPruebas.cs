using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers;
using System.Collections.Generic;

namespace Helpers.Test
{
    [TestClass]
    public class PersonaPruebas
    {
        Dictionary<string, bool> cedulas;
        [TestInitialize]
        public void Setup()
        {
            cedulas = new Dictionary<string, bool>();
            cedulas.Add("40221867555", true);
            cedulas.Add("40221867556", false);
            cedulas.Add("40221868555", false);
            cedulas.Add("4022085225-1", true);
            cedulas.Add("402-2085225-1", true);
            cedulas.Add("412-2085225-1", false);
            cedulas.Add("402-2186855-8", false);
            cedulas.Add("402-218685A-8", false);
            cedulas.Add("402-218685A-08", false);
            cedulas.Add("000-0000000-00", false);
        }

        [TestMethod]
        public void PruebaValidarCedula()
        {
            foreach (var cedula in cedulas)
            {
                Assert.AreEqual(cedula.Value, PersonaHelper.ValidarCedula(cedula.Key));
            }
        }
    }
}
