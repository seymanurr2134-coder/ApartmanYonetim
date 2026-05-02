using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanYonetim.Models
{
    internal class Aidat
    {
        public int Id { get; set; }
        public int Ay { get; set; }
        public int Yil { get; set; }
        public decimal Tutar { get; set; }
        public DateTime SonOdemeTarihi { get; set; }

        // Görüntüleme için yardımcı özellik
        public string AyYilText => $"{Ay}/{Yil}";
    }
}
