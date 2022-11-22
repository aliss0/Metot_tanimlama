using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_tanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erişim belirteci - geri dönüş tipi - metot adı
            //{ 
            //    Komutlar;
            //return
            //}

            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);
            int sonuc= topla(a, b);
            Console.WriteLine(sonuc);
         
            Metotlar ornek = new Metotlar();
            ornek.Ekranayazdir(Convert.ToString(sonuc));
            int sonuc2 = ornek.ArttırVeTopla(a, b);
            ornek.Ekranayazdir(Convert.ToString(sonuc2));

            Console.ReadLine();
        }
        static int topla(int deger1,int deger2)
        {
            return (deger1 + deger2);
        }
        class Metotlar
        {
            public void Ekranayazdir(string veri)
                {
                Console.WriteLine(veri);
                }
            public int ArttırVeTopla(int deger1, int deger2)
            {
                deger1 += 1;
                deger2 += 1;
                return deger1 + deger2; 

            }

        }
        
    }
}
