using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(31);
            sayiListesi.Add(17);
            sayiListesi.Add(7);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("sarı");
            renkListesi.Add("yeşil");

            //Count

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            // foreach ve list.foreach ile elemanlara erişim

            foreach (var sayi in sayiListesi)
                  Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //listeden eleman cıkarma 

            sayiListesi.Remove(7);
            renkListesi.Remove("kırmızı");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);



            // liste içerisinde arama 

            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içersinde bulundu..");
            }


            //eleman ile indexe erişim




            //diziyi liste çevirme

            string[] hayvanlar = { "kedi", "kopek", "kus" };

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //listeyi nasıl temizlerim

            hayvanListesi.Clear();













        }
    }
}
