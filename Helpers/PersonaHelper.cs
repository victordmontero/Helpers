using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class PersonaHelper
    {
        public static bool ValidarCedula(string cedula)
        {
            if (cedula.All(x => x == '0'))
                return false;

            if (cedula.Any(c => char.IsLetter(c)))
                return false;

            cedula = cedula.Replace("-", "").Trim();
            string temp = string.Empty;
            if (cedula.Length == 11)
            {
                for (int i = 0; i < cedula.Length - 1; i++)
                {
                    temp += (byte)char.GetNumericValue(cedula[i]) * (i % 2 + 1);
                }
                int sigma = temp.Select(x => (byte)char.GetNumericValue(x)).Sum(x => x);
                return Math.Abs(10 - sigma % 10) == char.GetNumericValue(cedula.Last());
            }
            return false;
        }
    }
}
