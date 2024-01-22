using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müsteri Eklendi : " + musteri.Ad +" "+ musteri.SoyAd);
        }

    public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müsteri Silindi : " + musteri.Ad +" " + musteri.SoyAd);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Liste : " + musteri.Ad +" "+ musteri.Id);
        }
    }
}
