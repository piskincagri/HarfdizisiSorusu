 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harfdizisi.UI
{
    public  class Program
    {
        public static string Buyuk(string w)
        {
            char[] dizi = w.ToCharArray();

            int i = dizi.Length - 2;
            while (i >= 0 && dizi[i] >= dizi[i + 1])
            {
                i--;
            }


            while (i >= 0)
            {
                int j = dizi.Length - 1;
                while (dizi[j] <= dizi[i])
                {
                    j--;
                }
                Degistir(dizi, i, j);

                Reverse(dizi, i + 1, dizi.Length - 1);

                string result = new string(dizi);
                if (!result.Equals(w))
                {
                    return result;
                }

                i--;
            }

            return "no answer";
        }

        private static void Degistir(char[] dizi, int i, int j)
        {
            char temp = dizi[i];
            dizi[i] = dizi[j];
            dizi[j] = temp;
        }

        private static void Reverse(char[] dizi, int start, int end)
        {
            while (start < end)
            {
                Degistir(dizi, start, end);
                start++;
                end--;
            }
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Bir kelime girin (Programdan çıkmak için 'exit' yazın): ");
                string kelime = Console.ReadLine();

                if (kelime.ToLower() == "exit")
                {
                    break;
                }

                string sonuc = Buyuk(kelime);

                Console.WriteLine("Sonuç: " + sonuc);
            }
        }
    }
}
