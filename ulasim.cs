using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sezerproje
{
    abstract class ulasim
    {
        public string isim;
        public string soyisim;
        public string ytipi;
        private string telno;
        private string tcno;
        public double fiyat;
       
        public string Telno
        {
            get
            {
                return telno;
            }
            set
            {
                telno = value;
                if(telno.Length==3)
                {
                    Console.WriteLine("Tebrikler doğru girdiniz işleminize devam edebilirsiniz.");
                }
                else
                {
                    Console.WriteLine("Maalesef yanlış girdiniz lütfen çıkış yapıp tekrar deneyiniz.");

                }

            }

        }
        public string Tcno
        {
            get
            {
                return tcno;
            }
            set
            {
                tcno = value;
                if(tcno.Length==3)
                {
                    Console.WriteLine("Tebrikler doğru girdiniz işleminize devam edebilirsiniz.");
                }
                else
                {
                    Console.WriteLine("Maalesef yanlış girdiniz lütfen çıkış yapıp tekrar deneyiniz.");

                }
            }

        }
        public void yazdır()
        {
            Console.WriteLine("İsim  :"+ isim);
            
            Console.WriteLine("Soyisim  :"+soyisim);
        
            Console.WriteLine("Tc No  :"+Tcno);
          
            Console.WriteLine("Telefon no  :"+Telno);
         
            Console.WriteLine("Yolculuk tipiniz  :"+ytipi); 
        
        }
        public void bilgial()
        {
            Console.WriteLine("İsim  :");isim = Console.ReadLine();
            Console.WriteLine("Soyisim  :"); soyisim = Console.ReadLine();
            Console.WriteLine("Tc No  :");  Tcno=Console.ReadLine();
            Console.WriteLine("Telefon no  :"); Telno= Console.ReadLine();
            Console.WriteLine("Yolculuk tipiniz  :");  ytipi= Console.ReadLine();


        }

        public abstract double bilethesaplama(double fiyat);





    }
}
