using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanYonetim.Models
{
    internal class ProfilModel
    {
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int DaireNo { get; set; }
        public byte[] Resim { get; set; }
    }
}
