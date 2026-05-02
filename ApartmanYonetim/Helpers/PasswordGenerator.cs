using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanYonetim.Helpers
{
    internal class PasswordGenerator
    {
        public static string SifreUret()
        {
            return Guid.NewGuid().ToString().Substring(0, 8);
        }
    }
}
