using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriMenager
    {
        public void Ekle()
        {
            Console.WriteLine("Müsteriler Eklenmiştir.");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri liste in musteriler)

            {
                Console.WriteLine(liste.Isim + " " + liste.soyIsim + " " + liste.Id);
            }
        }
        public void Sil(Musteri musteri1)
        {
            Console.WriteLine(musteri1.Id + " " + musteri1.Isim + " " + musteri1.soyIsim + " " + "Kullanıcı silinmiştir.");
        }
    }
}
