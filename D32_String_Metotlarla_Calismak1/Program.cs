using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D32_String_Metotlarla_Calismak1
{
    class Program
    {
        static void Main(string[] args)//Contains.Metodu
        {
            string ad, soyad;
            bool arama_ad, arama_soyad;
            Console.WriteLine("Adınızı giriniz?");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz?");
            soyad = Console.ReadLine();
            arama_ad = rakamara(ad);
            arama_soyad = rakamara(soyad);
            if (arama_ad==true)
            {
                Console.WriteLine("Adınız içerisinde rakam olmaz!");
            }
            if (arama_soyad==true)
            {
                Console.WriteLine("Soyadınız içerisinde rakam olmaz!");
            }
            if (arama_ad==false && arama_soyad==false)
            {
                Console.WriteLine("Kayıt işlemi başarı ile tamamlanmıştır.");
            }
            Console.ReadKey();

        }

        public static bool rakamara(string aranacakmetin) 
        {
            if (aranacakmetin.Contains('0'))
                return true;
            else if (aranacakmetin.Contains('1'))
                return true;
            else if (aranacakmetin.Contains('2'))
                return true;
            else if (aranacakmetin.Contains('3'))
                return true;
            else if (aranacakmetin.Contains('4'))
                return true;
            else if (aranacakmetin.Contains('5'))
                return true;
            else if (aranacakmetin.Contains('6'))
                return true;
            else if (aranacakmetin.Contains('7'))
                return true;
            else if (aranacakmetin.Contains('8'))
                return true;
            else if (aranacakmetin.Contains('9'))
                return true;
            else
                return false;
            


        }
    }
}
