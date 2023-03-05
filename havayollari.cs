using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sezerproje
{
    class havayollari : ulasim
    {
        private string marka;
        public string secim;
        
        public string yemek;        
        public string şirket; 
        public int vade;   
           
        public string Marka
        {
            get
            {
                return marka;
            }
            set
            {
                marka = value;
            }

        }

        public override double bilethesaplama(double fiyat)
        {
            fiyat = fiyat + fiyat *0.8;               
            return fiyat;
        }
        public void ötipi(double fiyat)
        {
            Console.WriteLine("1-kredi\n2-nakit");
            Console.WriteLine("Ödeme tipinizi seçiniz :");
            secim = Console.ReadLine();
            if(secim=="nakit")
            {
                Console.WriteLine("Nakit olarak ödeyeciğniz fiyat :" + fiyat);
            }
            else if(secim=="kredi")
            {
                banka(fiyat);
               
            }
        }
        public void banka(double fiyat)
        {
            Console.WriteLine("1-İşbankası\n2-Akbank");
            Console.WriteLine("Ödeme yapacağınız bankayı seçiniz :");
            secim = Console.ReadLine();
            Console.WriteLine("vade giriniz :");
            vade = Convert.ToInt32(Console.ReadLine());
            if (secim=="işbankası")
            {
                if(vade==6)
                {
                   fiyat += fiyat * 0.2;
                    Console.WriteLine("6 vadeli fiyat : "+fiyat);
                }
                else if(vade==9)
                {
                   fiyat += fiyat * 0.3;
                }
                else if(vade==12)
                {
                    fiyat += fiyat * 0.4;
                }
                
                Console.WriteLine("Vadeli olarak kredi kartı ile ödeyeceğiniz fiyat :" + fiyat);
            }
            else if(secim=="akbank")
            {
                if (vade == 6)
                {
                    fiyat += fiyat * 0.2;

                }
                else if (vade == 9)
                {
                    fiyat += fiyat * 0.5;
                }
                else if (vade == 12)
                {
                    fiyat += fiyat * 0.6;
                }
               
                Console.WriteLine("Vadeli olarak kredi kartı ile ödeyeceğiniz fiyat :" + fiyat);
            }



        }


    }
}
