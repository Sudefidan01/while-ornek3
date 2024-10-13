using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20232907_While_Ornek3
{
    internal class Program
    {
        //Kullanıcıdan 2 adet sayı talep edelim
        //1.sayıdan 2.sayıya kadar olan sayıların toplamını ve ortalamasını ekrana yazdıralım
        static void Main(string[] args)
        {  
            int ilkSayi, ikinciSayi, toplam = 0, sayac = 0;
            double ortalama;
            Console.Write("1.Sayıyı Giriniz : ");
            ilkSayi=int.Parse(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz : ");
            ikinciSayi=int.Parse(Console.ReadLine());
            if (ilkSayi==ikinciSayi)
            {
                Console.WriteLine("Sayılar Birbirine Eşittir ");
            }
            else

            {
                //Birinci Yöntem    

                /*
                if (ilkSayi>ikinciSayi)
                {       
                    int gecici = ilkSayi;
                    ilkSayi = ikinciSayi;
                    ikinciSayi= gecici;
                }      

                while (ilkSayi<=ikinciSayi) 
                {
                    toplam += ilkSayi; // toplam = toplam +ilkSayi;
                    ilkSayi++;
                    sayac++;

                } 
                */
                
                //İkinci Yöntem
                if (ilkSayi>ikinciSayi)
                {
                    while (ilkSayi>=ikinciSayi)
                    {
                        toplam += ilkSayi;
                        ilkSayi--;
                        sayac++;

                    }
                }
                else
                {
                    while (ilkSayi<=ikinciSayi)
                    {
                        toplam += ilkSayi;
                        ilkSayi++;
                        sayac++;

                    }
                }
                Console.WriteLine("Sayıların Toplamı = " +toplam);
                ortalama=(double)toplam/sayac;
                Console.WriteLine("Sayıların Ortalaması = "+ortalama);

            }

            Console.ReadKey();

        }
    }
}
