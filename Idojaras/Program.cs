using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] ev = new int[12, 30];
            int melegNap = 0;
            int meleg = 0;
            int hidegNap = 0;
            int hideg = 0;
            int atlag = 0;
            int melegHonap = 0;
            int melegAtlag = 0;
            int hidegHonap = 0;
            int hidegAtlag = 30;
            int combo = 0;
            bool minuszos = false;


            //Évi időjárás generálás
            for (int i = 0; i < ev.GetLength(0); i++)
            {
                for (int j = 0; j < ev.GetLength(1); j++)
                {
                    ev[i,j] = r.Next(-12, 30);
                    Console.WriteLine("Hónap: {0}, Nap: {1}, Hőmérséklet: {2}", i + 1, j + 1, ev[i,j]);
                }
            }

            //Min & Max
            for (int i = 0; i < ev.GetLength(0); i++)
            {
                for (int j = 0; j < ev.GetLength(1); j++)
                {
                    if (ev[i,j] > meleg)
                    {
                        meleg = ev[i,j];
                        melegHonap = i + 1;
                        melegNap = j + 1;
                    }
                    else if(ev[i, j] < hideg)
                    {
                        hideg = ev[i, j];
                        hidegHonap = i + 1;
                        hidegNap = j + 1;
                    }
                }
            }
            Console.WriteLine("Az év legmelegebb napja: {0}. hónap {1}. nap\nAz év leghidegebb napja: {2}. hónap {3}. nap", melegHonap, melegNap, hidegHonap, hidegNap);

            //Átlag számítás
            for (int i = 0; i < ev.GetLength(0); i++)
            {
                int osszHomerseklet = 0;
                for (int j = 0; j < ev.GetLength(1); j++)
                {
                    osszHomerseklet += ev[i, j];
                }
                atlag = osszHomerseklet / ev.GetLength(1);
                if (atlag > melegAtlag)
                {
                    melegHonap = i + 1;
                    melegAtlag = atlag;
                }
                else if (atlag < hidegAtlag)
                {
                    hidegHonap = i + 1;
                    hidegAtlag = atlag;
                }
            }
            Console.WriteLine("Az év legmelegebb hónapja: {0}. hónap {1}° fokos átlag hőmérséklettel! \nAz év leghidegebb hónapja: {2}. hónap {3}° fokos átlag hőmérséklettel!"
                , melegHonap, melegAtlag, hidegHonap, hidegAtlag);

            //Volt-e 5 egymást követő nap minusz fokban
            for (int i = 0; i < ev.GetLength(0); i++)
            {
                for (int j = 0; j < ev.GetLength(1); j++)
                {
                    if (ev[i, j] < 0)
                    {
                        combo++;
                        if (combo == 5)
                        {
                            minuszos = true;
                        }
                    }
                    else
                    {
                        combo = 0;
                    }
                }
            }
            if (minuszos)
            {
                Console.WriteLine("Volt egymást követő 5 nap úgy hogy minusz fokot mértünk.");
            }
            else
            {
                Console.WriteLine("Nem volt egymást követő 5 nap úgy hogy minusz fokot mértünk.");
            }

            Console.ReadKey();
        }
    }
}
