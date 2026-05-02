using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanYonetim.Models
{
    internal class OdemeGecmisi
    {
        public int Ay { get; set; }
        public int Yil { get; set; }
        public decimal Tutar { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public string Durum { get; set; } = "Ödendi"; // Görseldeki yeşil buton için
    }
    }


