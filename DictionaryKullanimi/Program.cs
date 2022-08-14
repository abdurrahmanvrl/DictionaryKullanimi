using System;
using System.Collections.Generic;

namespace DictionaryKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary sınıfı içinde sizin belirleyeceğiniz bir key e uygun olarak değer saklar
            // key türünü belirlememiz şart (stringi int vs...)

            Dictionary<int, string> DicList = new Dictionary<int, string>();
            //veri ekliyoruz

            DicList.Add(34, "İstanbul");
            DicList.Add(06, "Ankara");
            DicList.Add(07, "Antalya");
            DicList.Add(16, "Bursa");
            DicList.Add(35, "İzmir");

            Console.WriteLine("Dictionary Listesi");
            foreach (var degeroku in DicList)
            {
                Console.WriteLine(degeroku);
            }
            Console.WriteLine();
            Console.WriteLine("16 : " + DicList[16]);


            //değer sayma özelliği vardır
            var eleman = DicList.Count();
            Console.WriteLine();
            Console.WriteLine("Dictionary Listesinin Elemen Sayısı : " + eleman);

            //silme işlemide vardır
            DicList.Remove(16);
            Console.WriteLine("16 key numaralı eleman silindi");
            Console.WriteLine();
            Console.WriteLine("Dictionary Listesi");
            foreach (var degeroku in DicList)
            {
                Console.WriteLine(degeroku);
            }

            string ListedeAra(int aranacak)
            {
                //TryGetValue komutu arar bulduğunu dışarı atar
                string donenDeger;
                if (DicList.TryGetValue(aranacak, out donenDeger))
                {
                    return donenDeger;
                }
                else
                {
                    return "Listede Bu Eleman Yok";
                }
            }
            Console.WriteLine();
            Console.WriteLine("06 : " + ListedeAra(06));
            Console.WriteLine("16 : " + ListedeAra(16));


        }

    }
}
