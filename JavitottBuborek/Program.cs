using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavitottBuborek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Javított Buborék");
            int[] tomb = new int[] { 5, 3, 6, 10, 1, 2, 4, 8, };
            int i = tomb.Length - 1;
            
            while (i >= 1)
            {
                int cs = -1;
                for (int j = 0; j <= i - 1; j++)
                {
                    if (tomb[j] > tomb[j + 1])
                    {
                        cs = j;
                        int temp = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = temp;
                        
                    }
                    
                }
                i = cs;
            }



            foreach (var sz in tomb)
            {
                Console.WriteLine($"{sz}");
            }
        }
    }
}
