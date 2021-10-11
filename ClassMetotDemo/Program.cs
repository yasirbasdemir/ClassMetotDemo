using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 176852;
            musteri1.Isim = "Murat";
            musteri1.soyIsim = "Başdemir";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 789542;
            musteri2.Isim = "Hasan";
            musteri2.soyIsim = "Başdemir";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 654821;
            musteri3.Isim = "Yasir";
            musteri3.soyIsim = "Başdemir";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3};

            MusteriMenager musteriMenager = new MusteriMenager();
            musteriMenager.Ekle();
            musteriMenager.Listele(musteriler);
            musteriMenager.Sil(musteri3);
        }
    }
}
