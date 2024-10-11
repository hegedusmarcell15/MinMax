using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    internal class Program
    {
        public static void MinMax(int[] szam, out int min, out int max)
        {
            min = szam[0];
            max = szam[0];
            for (int i = 0; i < szam.Length; i++)
            {
                if (szam[i] < min)
                {
                    min = szam[i];
                }
                if (szam[i] > max)
                {
                    max = szam[i];
                }
            }
        }

        static void Main(string[] args)
        {
          var szam = new int[] {1,2,3,4,5,6};

          int min;
          int max;


          MinMax(szam, out min, out max);
          Console.WriteLine("Minimum: {0}, Maximum:{1}", min, max);
          Console.ReadKey();
            

        }
    }
}
