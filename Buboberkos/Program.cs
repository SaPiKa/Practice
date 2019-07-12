using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Buborékos Rendezés
            int[] array = new int[] {76, 3, 87, 13, 21, 3, 1, 2, 66, 99, 3};
            for (int i = 0; i < array.Length - 1; ++i)
            {
                for (int j = array.Length - 1; j > i; --j)
                {
                    if (array[j - 1] > array[j])
                    {
                        int tmp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tmp;
                    }
                }
            }

            //Kiíratás Növekvő Sorrendben
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
