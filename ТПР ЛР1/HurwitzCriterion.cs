using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТПР_ЛР1
{
    public class HurwitzCriterion
    {
        const float c = 0.3f;

        public float Hurwitz(ref int[,] table)
        {
            int[] min = new int[MainProgram.resh];
            int[] max = new int[MainProgram.resh];
            for (int i = 0; i < MainProgram.resh; ++i)
            {
                min[i] = 100; max[i] = 0;
                for (int j = 0; j < MainProgram.sost; ++j)
                {
                    min[i] = Convert.ToInt32(table[i, j] <= min[i]) * table[i, j] + Convert.ToInt32(min[i] < table[i, j]) * min[i];
                    max[i] = Convert.ToInt32(table[i, j] >= max[i]) * table[i, j] + Convert.ToInt32(max[i] > table[i, j]) * max[i];
                }
            }
            Console.WriteLine("Min: ");
            foreach (int el in min)
                Console.WriteLine(el);
            Console.WriteLine("\nMax: ");
            foreach (int el in max)
                Console.WriteLine(el);
            float maxItem = 0;
            float[] maxRes = new float[MainProgram.resh];
            Console.WriteLine("\n Средневзвешенные значения:" );
            for (int i = 0; i < MainProgram.resh; ++i)
            {
                maxRes[i] = c * min[i] + (1 - c) * max[i];
                Console.WriteLine(maxRes[i]);
            }
            for (int i = 0; i < MainProgram.resh; ++i)
               if (maxRes[i]==maxRes.Max())
                {
                    maxItem = ++i; break;
                }
            return maxItem;
        }
    }
}
