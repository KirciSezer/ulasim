using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sezerproje
{
    class karayollari : ulasim
    {
        public string arac;
        public string internet;
        public int akbil;
        public double ücret;
        public string aracdurumu;
        public string secim;
        public int uzaklık;
        public int duraksayısı;

       
        public karayollari()
            {
             Console.WriteLine("Seciminizi kara araçlarından yapınız!!!");
            }
        public override double bilethesaplama(double fiyat)
        {
            return fiyat;
        }

        public virtual void kara()
        {
            Console.WriteLine("1-Otobüs\n2-Taksi\n3-Metrobüs");
            arac = Console.ReadLine();
            Console.WriteLine("uzaklık :");
            uzaklık = Convert.ToInt32(Console.ReadLine());
            if(arac=="otobüs")
            {
                Console.WriteLine("Otobüste internet var mı?");
                Console.WriteLine("Akbilinde para var mı?");
                secim = Console.ReadLine();
                Console.WriteLine("Yatırılacak tutarı giriniz :");
                akbil = Convert.ToInt32(Console.ReadLine());
                if(secim=="var" && akbil>20 && internet=="var")
                {
                    Console.WriteLine("Otobüse binebilirisiniz");
                }
            }
            else if(arac=="metrobüs")
            {
                
                Console.WriteLine("Durak sayısını giriniz :");
                duraksayısı= Convert.ToInt32(Console.ReadLine());
                ücret = 2.50;
                Console.WriteLine("Sabit ücret =" + ücret);
                if(duraksayısı<20)
                {
                    for(int i=0;i<2;i++)
                    {
                        Console.WriteLine("Akbil basınız");
                    }
                    ücret = ücret * 2;
                }
                else if(duraksayısı>20)
                {
                    for(int i=0;i<3;i++)
                    {
                        Console.WriteLine("Akbil basınız");
                    }
                    ücret = ücret * 3;
                   
                }

                Console.WriteLine("Ödeyeceğiniz ücret=" + ücret);             
            }
            else if(arac=="taksi")
            {
                ücret = 10;
                Console.WriteLine("Taksimetre =" + ücret);
                taksihesap();
            }
       }

        public void taksihesap()
        {
           switch(uzaklık)
            {
                case 100:
                    ücret = ücret * 0.10;
                break;

                case 200:
                    ücret = ücret * 0.20;
                    break;
            }
            Console.WriteLine("Ödeyeceğiniz ücret =" + ücret);
            
        }


















        
    }
}
