using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime = Console.ReadLine().ToLower();
            if (string.IsNullOrWhiteSpace(kelime) || kelime.Length <= 1)
            {
                Console.WriteLine("no answer");
                return;
            }
            char[] kelimeHarfleri = new char[kelime.Length];
            int h = 0;
            foreach (var item in kelime)
            {
                if (char.IsLetter(item))
                {
                    kelimeHarfleri[h] = item;
                }
                h++;
            }






            char degisecekIlkHarf = ' ';
            int degisecekIlkHarfIndisi = 0;
            char degisecekIkinciHarf = ' ';
            int degisecekIkinciHarfIndisi = 0;
            for (int i = kelime.Length - 1; i > 0; i--)
            {
                byte harfAscii = Convert.ToByte(kelimeHarfleri[i]);
                byte harfAscii2 = Convert.ToByte(kelimeHarfleri[i - 1]);
                if (harfAscii > harfAscii2)
                {
                    degisecekIlkHarf = kelimeHarfleri[i];
                    degisecekIlkHarfIndisi = i;
                    degisecekIkinciHarf = kelimeHarfleri[i - 1];
                    degisecekIkinciHarfIndisi = i - 1;
                    break;
                }
            }
            if (degisecekIlkHarfIndisi != 0)
            {
                kelimeHarfleri[degisecekIkinciHarfIndisi] = degisecekIlkHarf;
                kelimeHarfleri[degisecekIlkHarfIndisi] = degisecekIkinciHarf;
                Console.WriteLine(kelimeHarfleri);
            }
            else
            {
                Console.WriteLine("no answer");
            }
            Console.ReadKey();

        }
    }
}
