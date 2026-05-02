using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanYonetim.Models
{
    internal class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; } // Yonetici / Kullanici
        public int DaireId { get; set; } // Kullanıcı ise bağlı olduğu daire
        public string Email {  get; set; }
    }
}
