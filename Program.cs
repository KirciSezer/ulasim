using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sezerproje
{
    class Program
    {
        static void Main(string[] args)
        {
           
            havayollari h1 = new havayollari();
            h1.bilgial();
            h1.yazdır();
            Console.WriteLine("1-Turkish Airlines\n2-Pegasus Airlines\n3-Onur Air");
            Console.WriteLine("Havayolu şirketini giriniz :");
            h1.şirket = Console.ReadLine();
            Console.WriteLine("Uçak marka giriniz :");
            h1.Marka = Console.ReadLine();
            Console.WriteLine("Saat seciminizi giriniz :");
            h1.secim = Console.ReadLine();
            Console.WriteLine("Yemek seciminizi giriniz :");
            h1.yemek = Console.ReadLine();
            Console.WriteLine("Fiyat giriniz :");
            h1.fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Havayolu şirketi :" + h1.şirket);
            Console.WriteLine("Uçak marka  :"+h1.Marka);
            Console.WriteLine("Saat seciminiz :" + h1.secim);
            Console.WriteLine("Yemek seciminiz :" + h1.yemek);
            Console.WriteLine("Fiyat :" + h1.fiyat);
            if (h1.secim=="oglen" && h1.yemek=="var" )
            {

                double yenifiyat = h1.bilethesaplama(h1.fiyat);

                Console.WriteLine("Öğlen ve yemekli fiyat : " + h1.bilethesaplama(h1.fiyat));
                h1.ötipi(yenifiyat);
            }
            else if(h1.secim=="gece" && h1.yemek=="yok")
            {
                h1.bilethesaplama(h1.fiyat);
                h1.fiyat += h1.fiyat * 0.8;             
              
            }
            //h1.ötipi(h1.fiyat);
            karayollari kara = new karayollari();
            kara.kara();
            Console.ReadLine();



           
        }
    }
}
