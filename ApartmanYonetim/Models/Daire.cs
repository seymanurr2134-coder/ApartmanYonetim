using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanYonetim.Models
{
    internal class Daire
    {
        public int Id { get; set; }
        public string DaireNo { get; set; }
        public int Kat { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Durum { get; set; } // Ev Sahibi / Kiracı
        public byte[] Resim { get; set; }
    }
}
