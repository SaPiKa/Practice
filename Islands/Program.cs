using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islands
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxHossz = 0;
            int szigetekSzama = 0;
            int i = 0;
            bool valid = false;

            Console.WriteLine("Adjon meg egy számsorozatot ahol 1 a szárazföldet jelképezi míg 0 a tengert:");
            string data = Console.ReadLine();

            while (!valid)
            {
                for (int k = 0; k < data.Length; k++)
                {
                    char karakter = data[k];
                    if (karakter == '1' || karakter == '0')
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                        Console.WriteLine("A számsorozatban csak 0 és 1 lehet! Kérem írjon egy új számsorozatot:");
                        data = Console.ReadLine();
                        break;
                    }
                }
            }

            while (i < data.Length)
            {
                if (data[i] == '1')
                {
                    szigetekSzama++;
                    int j = i;
                    int tmp = 0;

                    while (j < data.Length && data[j] == '1')
                    {
                        j++;
                        tmp++;
                    }

                    i = j;

                    if (tmp > maxHossz)
                    {
                        maxHossz = tmp;
                    }
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine("Szigetek száma: {0} \nLeghosszabb sziget: {1}", szigetekSzama, maxHossz);
            Console.ReadKey();
        }
    }
}
