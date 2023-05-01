using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТПР_ЛР1
{
    public class HodgeLehmanCriterion
    {
        const float v = 0.4f;

        public static float MinStr(ref int[,] table)
        {
            int[] min = new int[MainProgram.resh];
            int[] sum = new int[MainProgram.resh];
            for (int i = 0; i < MainProgram.resh; ++i)
            {
                sum[i] = 0;
                for (int j = 0; j < MainProgram.sost; ++j)
                {
                    min[i] = table[i, j] * Convert.ToInt32(table[i, j] < min[i]) + min[i] * Convert.ToInt32(min[i] <= table[i, j]);
                    sum[i] += table[i, j];
                }
                sum[i] /= MainProgram.sost;
            }
            float[] preresult = new float[MainProgram.resh];
            for (int i = 0; i < MainProgram.resh; ++i)
                preresult[i] = v * sum[i] + (1 - v) * min[i];
            return preresult.Max();
        }
    }
}
