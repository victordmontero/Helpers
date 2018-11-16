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
        Dictionary<string, bool> emails;
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

            emails = new Dictionary<string, bool>();
            emails.Add("email.123456@gmail.com", true);
            emails.Add("email.123456gmail.com", false);
            emails.Add("@gmail.com", false);
            emails.Add(@"email@domain.com", true);
            emails.Add(@"firstname.lastname@domain.com", true);
            emails.Add(@"email@subdomain.domain.com", true);
            emails.Add(@"firstname+lastname@domain.com", true);
            emails.Add(@"email@123.123.123.123", true);
            emails.Add(@"email@[123.123.123.123]", true);
            emails.Add("\"email\"@domain.com", true);
            emails.Add(@"1234567890@domain.com", true);
            emails.Add(@"email@domain-one.com", true);
            emails.Add(@"_______@domain.com", true);
            emails.Add(@"email@domain.name", true);
            emails.Add(@"email@domain.co.jp", true);
            emails.Add(@"firstname-lastname@domain.com", true);
            emails.Add("plainaddress", false);
            emails.Add("#@%^%#$@#$@#.com", false);
            emails.Add("@domain.com", false);
            emails.Add("email.domain.com", false);
            emails.Add("email@domain@domain.com", false);
            emails.Add(".email@domain.com", false);
            emails.Add("Joe Smith <email@domain.com>", false);
            emails.Add("あいうえお@domain.com", false);
            emails.Add("email@domain.com (Joe Smith)", false);

        }

        [TestMethod]
        public void PruebaValidarCedula()
        {
            foreach (var cedula in cedulas)
            {
                Assert.AreEqual(cedula.Value, PersonaHelper.ValidarCedula(cedula.Key));
            }
        }

        [TestMethod]
        public void PruebaValidarEmail()
        {
            foreach (var email in emails)
            {
                Assert.AreEqual(email.Value, PersonaHelper.ValidarEmail(email.Key));
            }
        }
    }
}
