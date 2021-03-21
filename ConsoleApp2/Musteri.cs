using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Musteri
    {
        private string musteriAdi;
        private int urunSayisi;
        public string MusteriAdi { get => musteriAdi; set => musteriAdi = value; }
        public int UrunSayisi { get => urunSayisi; set => urunSayisi = value; }

        public Musteri(string ad, int sayi)
        {
            this.MusteriAdi = ad;
            this.UrunSayisi = sayi;

        }
        

    }
}
