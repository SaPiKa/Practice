using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {3, 90, 40, 2, 33, 44};
            int min = array[0];
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine("Minimum: {0} | Maximum: {1}", min, max);
            Console.ReadKey();
        }
    }
}
