using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanYonetim.Models
{
    internal class Borc
    {
        public int Id { get; set; }
        public int DaireId { get; set; }
        public int AidatId { get; set; }

        public decimal Tutar { get; set; }

        public bool OdendiMi { get; set; }
        public DateTime? OdemeTarihi { get; set; }
        public int Ay { get; set; }
        public int Yil { get; set; }
        public string Durum { get; set; }        // "Ödendi", "Ödenmedi", "Gecikmiş"
        public DateTime SonOdemeTarihi { get; set; }
    }
}
