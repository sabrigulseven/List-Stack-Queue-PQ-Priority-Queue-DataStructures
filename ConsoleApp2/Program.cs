using Proje2;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Proje2
{
  
    class Program
    {
        static void Main(string[] args)
        {
            string[] musteriAdi = { "Ali", "Merve", "Veli", "Gülay", "Okan", "Zekiye", "Kemal", "Banu", "İlker", "Songül", "Nuri", "Deniz" };
            int[] urunSayisi = { 8, 11, 16, 5, 15, 14, 19, 3, 18, 17, 13, 15 };
            ArrayList arrayList = new ArrayList();
            Musteri yeniMusteri;
            List<Musteri> genericList;
            Random rastgele = new Random();
            for (int i=0; i< musteriAdi.Length;)
            {
                genericList = new List<Musteri>();
                int genericListLength = rastgele.Next(1,6);
                for (int j = 0; j < genericListLength; j++)
                {
                    yeniMusteri = new Musteri(musteriAdi[i], urunSayisi[i]);
                    genericList.Add(yeniMusteri);
                    Console.Write(yeniMusteri.MusteriAdi );
                    Console.WriteLine(" - " +yeniMusteri.UrunSayisi);
                    i++;
                    if (i == musteriAdi.Length)
                        break;
                }
                arrayList.Add(genericList);            
                Console.WriteLine("____________________");
            }
            //SORU 1-C         
            double musteriSayisi = musteriAdi.Length;
            double elemanSayisi = arrayList.Count;
            Console.WriteLine( "Ortalama Eleman sayısı= {0}" , musteriSayisi/elemanSayisi);
            Console.WriteLine();

            //SORU 2
            StackX stack = new StackX((int)musteriSayisi);
            QueueX queue = new QueueX((int)musteriSayisi);
            PQDec pqdec = new PQDec((int)musteriSayisi);
            PQInc pQInc = new PQInc((int)musteriSayisi);
            foreach (List<Musteri> list in arrayList)
            {

                foreach (Musteri musteri in list)
                {
                    stack.push(musteri);
                    queue.insert(musteri);
                    pqdec.insert(musteri);
                    pQInc.insert(musteri);
                }
            }
            //Bekleme süresini hesaplayabilmek için listeler oluşturdum
            //Listeleri 2. ve 3. soruda remove metodu kullanılırken doldurdum
            List<Musteri> fifoOutput = new List<Musteri>();
            List<Musteri> pqDecOutput = new List<Musteri>();
            List<Musteri> pqIncOutput = new List<Musteri>();
            Console.WriteLine("____________________Yığıt");
            while (!stack.isEmpty())
            {
                Musteri value = stack.pop();
                Console.WriteLine(value.MusteriAdi + " - "+value.UrunSayisi);
            }
            Console.WriteLine("____________________Kuyruk");
            while (!queue.isEmpty())
            {
                Musteri value = queue.remove();
                Console.WriteLine(value.MusteriAdi + " - " + value.UrunSayisi);
                fifoOutput.Add(value);
            }
            Console.WriteLine("____________________ Öncelikli Kuyruk Azalan");
            while (!pqdec.isEmpty())
            {
                Musteri value = pqdec.remove();
                Console.WriteLine(value.MusteriAdi + " - " + value.UrunSayisi);
                pqDecOutput.Add(value);
            }
            Console.WriteLine("____________________ Öncelikli Kuyruk Artan");
            while (!pQInc.isEmpty())
            {
                Musteri value = pQInc.remove();
                Console.WriteLine(value.MusteriAdi + " - " + value.UrunSayisi);
                pqIncOutput.Add(value);
            }
            int fifoToplamBeklemeSuresi=0;
            int pqIncToplamBeklemeSuresi=0;
            int pqDecToplamBeklemeSuresi=0;
            int fifoBeklemeSuresi = 0;
            int pqDecBeklemeSuresi = 0;
            int pqIncBeklemeSuresi = 0;
            Console.WriteLine();
            Console.WriteLine("____________________ FIFO Sırada Bekleme Süresi");           
            foreach (Musteri musteri in fifoOutput)
            {
                Console.WriteLine(musteri.MusteriAdi + " - " + fifoBeklemeSuresi + " süre bekler.");
                fifoToplamBeklemeSuresi += fifoBeklemeSuresi;
                fifoBeklemeSuresi += musteri.UrunSayisi;
            }
            Console.WriteLine();
            Console.WriteLine("____________________ Öncelikli Kuyruk Azalan Sırada Bekleme süresi");
            foreach (Musteri musteri in pqDecOutput)
            {
                Console.WriteLine(musteri.MusteriAdi + "-" + pqDecBeklemeSuresi + " süre bekler.");
                pqDecToplamBeklemeSuresi += pqDecBeklemeSuresi;
                pqDecBeklemeSuresi += musteri.UrunSayisi;
            }
            Console.WriteLine();
            Console.WriteLine("____________________ Öncelikli Kuyruk Artan Sırada Bekleme Süresi");

            foreach (Musteri musteri in pqIncOutput)
            {
                Console.WriteLine(musteri.MusteriAdi + "-" + pqIncBeklemeSuresi + " süre bekler.");
                pqIncToplamBeklemeSuresi += pqIncBeklemeSuresi;
                pqIncBeklemeSuresi += musteri.UrunSayisi;
            }
            Console.WriteLine();
            Console.WriteLine("FIFO Bekleme süresi Ortalaması: " + fifoToplamBeklemeSuresi/fifoOutput.Count +
                " PQDec Bekleme süresi Ortalaması: " + pqDecToplamBeklemeSuresi /pqDecOutput.Count +
                " PQInc Bekleme süresi Ortalaması: " + pqIncToplamBeklemeSuresi / pqIncOutput.Count );
            Console.ReadKey();
        }
    }
}

